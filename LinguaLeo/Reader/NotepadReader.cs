using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace LinguaLeo.Reader
{
    class NotepadReader : Reader
    {
        ProgressBar pb;
        public NotepadReader(string filePath) : base(filePath) { }
        public NotepadReader(string filePath, ProgressBar pb) : base(filePath)
        {
            this.pb = pb != null ? pb : null;
            if (pb != null)
                pb.Maximum = 0;
        }

        public override List<Word> Read()
        {
            filePath = File.Exists(filePath) ? filePath : throw new FileNotFoundException();

            Stream str = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            string raw = "";
            byte[] data = new byte[256];
            int i = 0;
            while ((i = str.Read(data, 0, data.Length)) > 0)
                raw += Encoding.UTF8.GetString(data, 0, data.Length);

            raw = RemoveChars(raw, "\t\r&\\,./':\"/*-+[]{}");

            List<Word> Words = new List<Word>();

            if (raw.Split('\n')[0].Split(' ').Length > 2)
                throw new Exception("Data is not normalized.\r\n\"word tword\"");
            else if (raw.Split(' ').Length < 2)
            {
                string[] w = raw.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                for (int a = 0; a < w.Length; a++)
                {
                    Words.Add(new Word(w[a], null));
                    if (pb != null)
                    {
                        pb.Maximum += 1;
                        pb.Value += 1;
                    }
                }
            }
            else
            {
                string[] lines = raw.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);                
                for (int k = 0; k < lines.Length; k++)
                {
                    Words.Add(new Word(lines[k].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[0],
                                       lines[k].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[1]));
                    if (pb != null)
                    {
                        pb.Maximum += 1;
                        pb.Value += 1;
                    }
                }
            }
            return Words;
        }

        private static string RemoveChars(string input, string pattern)
        {
            string Str = "";
            bool add = true;

            foreach (var i in input)
            {
                foreach (var it in pattern + '\0')
                    if (i == it)
                    {
                        add = false;
                        break;
                    }
                if (add == true)
                    Str += i;
                add = true;
            }
            return Str;
        }
    }
}
