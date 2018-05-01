using LinguaLeo.Api;
using LinguaLeo.Forms;
using LinguaLeo.Logs;
using LinguaLeo.Reader;
using LinguaLeo.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinguaLeo.Controller
{
    class MainFormController
    {
        API api;
        Logger logger;
        List<Word> words;
        ProgressBar progBar;

        public MainFormController(ProgressBar pb,TextBox tb)
        {
            this.progBar = pb;
            logger = new Logger(tb);
            logger.Clear();
        }

        public void Auth(string email,string password) {
            api = new API();
            logger.Add(Serrialize.Auth(api.Auth(email, password)));
        }

        public List<Word> OpenFile() {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Files (*.txt;*.xls;*.xlsx)|*.txt;*.xls;*.xlsx|" +
                        "All Files (*.*)|*.*";
            fd.Multiselect = false;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    switch (fd.FileName.Substring(fd.FileName.LastIndexOf('.')))
                    {
                        case ".txt":
                            words = new NotepadReader(fd.InitialDirectory + fd.FileName,progBar).Read();
                            break;
                        case ".xls":
                        case ".xlsx":
                            words = new ExcelReader(fd.InitialDirectory + fd.FileName, progBar).Read();
                            break;
                        default:
                            words = new List<Word>();
                            break;
                    }
                }
                catch (Exception e){ throw e; }
            }
            return words;
        }

        public void AddWord() {
            logger.Add("Please wait...");
            logger.Add(words[0].word + Serrialize.AddWord(api.AddWord(words[0].word, words[0].tword)));
            progBar.Value += 1;
        }

        public void AddWords() {
            logger.Add("Please wait...");
            int c = 0, k = 49;

            while (c < words.Count)
            {
                if (words.Count - c < 49)
                    k = words.Count - c;
                List<Word> w = words.GetRange(c, k);
                c += k;
                foreach (var item in Serrialize.AddWords(api.AddWords(w), w.Count))
                    logger.Add(item);
                progBar.Value += k;
            }
        }
    }
}
