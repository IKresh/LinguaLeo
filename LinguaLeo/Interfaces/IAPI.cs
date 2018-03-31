using System.Collections.Generic;

namespace LinguaLeo.Interfaces
{
    interface IAPI
    {
        string isAuthorized();
        string Auth();
        string Translates(string word);
        string AddWord(string word,string tword);
        string AddWords(List<Word> words);
    }
}
