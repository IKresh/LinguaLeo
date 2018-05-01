using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LinguaLeo.Serialization
{
    class Serrialize//not actually a serrializer... just some response check
    {
        public static bool isAuthed = false;
        public static string Auth(string data)
        {
            if (!data.Contains("error_code"))
            {
                isAuthed = true;
                return "Successfully logged.";
            }
            else
            {
                isAuthed = false;
                return data.Substring(data.IndexOf("\"error_msg\":\"")).Split(':')[1].Split(',')[0].Trim('"');
            }
        }

        public static string Authorized(string data)
        {
            return data.Contains("\"is_authorized\":true") ? "Authorization succeed." : data.Contains("\"is_authorized\":false") ? "Authorization failed." : "Error occured!";
        }

        public static List<Word> Translates(string data)
        {
            List<Word> words = new List<Word>();
            if (data.Contains("error_code"))
            {
                words.Add(new Word(data.Substring(data.IndexOf("\"error_msg\":\"")).Split(':')[1].Split(',')[0]));
                return words;
            }

            string[] str = data.Substring(data.IndexOf("id")).Split('{');
            foreach (var item in str)
            {
                string w = item.Substring(item.IndexOf("value")).Split(':')[1].Split(',')[0];
                w = w.Contains("(") ? w.Remove(w.LastIndexOf('(')) : w;
                words.Add(new Word(w.Trim('"')));
            }
            return words;
        }

        public static string AddWord(string data)
        {
            if (data.Contains("\"is_new\":0"))
                return " exists.";
            else
                return " added.";
        }

        public static List<string> AddWords(string data,int words)
        {
            List<string> list = new List<string>();
            if (data.IndexOf("word_id\":") == -1)
            {
                list.Add(data);
                return list;
            }
            string []str = data.Substring(data.IndexOf("word_id\":")).Split(',');
            var strr = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Contains("word_value\":"))
                    strr = str[i].Split(':')[1].Trim('"');
                if (str[i].Contains("is_user_word_created\":1"))
                    list.Add(strr + " added.");
                else if (str[i].Contains("is_user_word_created\":0"))
                    list.Add(strr + " exists.");
            }
            return list;
        }
    }
}
