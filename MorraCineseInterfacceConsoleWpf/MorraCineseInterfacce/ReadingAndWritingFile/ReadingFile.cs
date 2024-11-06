namespace ReadingAndWritingFile
{
    public class ReadingFile
    {
        private string _file;
        private bool _empty;

        public void CheckIfFileIsEmpty()
        {
            string line = "";
            int counter = 0;
            using(StreamReader sr  = new StreamReader(line))
            {
                while(sr.ReadLine() != null)
                {
                    counter++;
                }
            }
            if(counter > 0) _empty = false;
            _empty = true;
        }

        public ReadingFile(string file)
        {
            _file = file;
            CheckIfFileIsEmpty();
        }

        public int? ReadMove()
        {
            string lineMove = "";
            if (_empty == false)
            {
                using (StreamReader sr = new StreamReader(_file))
                {
                    lineMove=sr.ReadLine();
                }
            }

            lineMove.ToLower();
            Char[] c = lineMove.ToCharArray();
            string s = c[0].ToString();
            s.ToUpper();
            c[0] = s.ToCharArray()[0];
            lineMove = c.ToString();

            if (lineMove == "Rock") return 0;
            if (lineMove == "Paper") return 1;
            if (lineMove == "Scissor") return 2;
            else return null;
        }
    }
}
