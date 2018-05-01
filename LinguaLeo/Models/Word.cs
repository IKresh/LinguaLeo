using System.Collections.Generic;

namespace LinguaLeo
{
    class Word
    {
        public string word { get; set; }
        public string tword { get; set; }
        //public string src_lang { get; set; }
        //public string targ_lang { get; set; }
        public Word(string word)
        {
            this.word = word;
        }

        public Word(string word, string tword)
        {
            this.word = word;
            this.tword = tword;
        }

        public static bool operator !=(Word w1, Word w2)
        {
            return w1.word != w2.word && w1.tword != w2.tword ? true : false;
        }

        public static bool operator ==(Word w1,Word w2) {

            return w1.word == w2.word && w1.tword == w2.tword ? true : false;
        }

        public override bool Equals(object obj)
        {
            return (obj as Word).word == word && (obj as Word).tword == tword ? true : false;
        }

        public override int GetHashCode()
        {
            var hashCode = 1994168772;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(word);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(tword);
            return hashCode;
        }
    }
}
