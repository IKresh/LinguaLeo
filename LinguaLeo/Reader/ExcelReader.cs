using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LinguaLeo.Reader
{
    class ExcelReader:Reader
    {
        ProgressBar pb;
        public ExcelReader(string filePath) : base(filePath) { }
        public ExcelReader(string filePath, ProgressBar pb) : base(filePath)
        {
            this.pb = pb != null ? pb : null;
            if (pb != null)
                pb.Maximum = 0;
        }

        public override List<Word> Read()
        {
            var xlApp = new Microsoft.Office.Interop.Excel.Application();
            List<Word> words = new List<Word>();
            try
            {
                var wb = xlApp.Workbooks.Open(filePath);
                var ws = wb.Worksheets[1];
                var range = ws.UsedRange;
                var cells = range.Cells;

                for (int rw = 1; rw <= cells.Rows.Count; rw++)
                {
                    for (int cl = 1; cl <= cells.Columns.Count; cl++)
                        try
                        {
                            if ((int)cells[rw, cl].Value.ToString()[0] < 255)
                                if (!words.Contains(new Word(cells[rw, cl].Value.ToString())))
                                {
                                    words.Add(new Word(cells[rw, cl].Value.ToString()));
                                    if (pb != null && cl % 3 == 0)
                                    {
                                        pb.Maximum += 1;
                                        pb.Value += 1;
                                        Console.WriteLine(pb.Maximum+" "+pb.Value);
                                    }
                                }
                        }
                        catch (Exception) { }
                }

                cells = null;
                range = null;
                wb.Close();
                return words;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            xlApp.Quit();
            return null;
        }

        /*Read with translates
         for (int rw = 1; rw <= cells.Rows.Count; rw++)
                try
                {
                    string word = null, tword = null;
                    if ((int)cells[rw, wordColumn].Value.ToString()[0] < 255)
                        word = cells[rw, wordColumn].Value.ToString();
                    if ((int)cells[rw, wordColumn].Value.ToString()[0] >= 1040)
                        tword = cells[rw, twordColumn].Value.ToString();
                    if (word != null && !words.Contains(new Word(word, tword)))
                        words.Add(new Word(word, tword));
                }
                catch (Exception e) { Console.WriteLine(rw); }
         */
    }
}
