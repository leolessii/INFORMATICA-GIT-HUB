using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingAndWritingFile
{
    public class WritingFile
    {
        private string _file;

        public WritingFile(string file)
        {
            _file = file;
        }

        public void WriteMoveAndResult(string move, string result, int roundNumber)
        {
            string Move = move;
            string Result = result;
            string RoundNumber = roundNumber.ToString();

            string Line = $"Round number: {RoundNumber} | Player move: {Move} | Result: {Result}";
            using (StreamWriter sw = new StreamWriter(_file, true))
            {
                sw.WriteLine(Line);
            }
        }
    }
}
