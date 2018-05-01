namespace LinguaLeo.Interfaces
{
    interface ILogger
    {
        void Add(string line);
        void Clear();
        void NewLine();
    }
}
