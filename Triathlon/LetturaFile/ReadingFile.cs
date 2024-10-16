using Triathlon_Atleti;
namespace ReadingFile
{
    
    public class ReadingFile
    {
        public string filePath;
        public List<TriathlonParticipant> triathlonParticipants;
        public List<TriathlonFinalist> triathlonFinalist;

        public ReadingFile()
        {
            Readfile();
        }

        public void Readfile()
        {
            using (StramReader s = new StramReader(filePath))
            {
                string line;

                while((line = s.ReadLine()) != null)
                {
                    string id;
                    string name;
                    string surname;
                    string n1;
                    string n2;
                    string n3;

                    id = line.Split('');
                    name = line.Split('');
                    surname = line.Split('');

                    try
                    {
                        n1 = line.Split('');
                        Convert.ToInt32(n1);
                    }
                    catch
                    {
                        TriatlonParticipant tp = new TriatlonParticipant(name, surname, id);
                        triathlonParticipants.Add(tp);
                    }

                    try
                    {
                        n2 = line.Split('');
                        Convert.ToInt32(n2);
                    }
                    catch
                    {
                        TriatlonParticipant tp = new TriatlonParticipant(name, surname, id, n1);
                        triathlonParticipants.Add(tp);
                    }

                    try
                    {
                        n3 = line.Split('');
                        Convert.ToInt32(n3);
                    }
                    catch
                    {
                        TriatlonParticipant tp = new TriatlonParticipant(name, surname, id, n1, n2);
                        triathlonParticipants.Add(tp);
                    }

                    TriathlonFinalist tf = new TriathlonFinalist(name, surname, id, n1, n2, n3);
                }
            }
        }
    }
}
