using System.Collections.Generic;

namespace LinguaLeo.Reader
{
    abstract class Reader
    {
        protected string filePath;
        public Reader(string filePath)
        {
            this.filePath = filePath;
        }
        public abstract List<Word> Read();
    }
}
