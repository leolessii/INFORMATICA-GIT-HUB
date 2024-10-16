using System.Text;
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
            using (StreamReader s = new StreamReader(filePath))
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

                    id = line.Split(" ")[0];
                    name = line.Split(" ")[1];
                    surname = line.Split(" ")[2];

                    try
                    {
                        n1 = line.Split(" ")[3];
                        int swim = Convert.ToInt32(n1);

                        try
                        {
                            n2 = line.Split(" ")[4];
                            int bike = Convert.ToInt32(n2);

                            try
                            {
                                n3 = line.Split(" ")[5];
                                int run =Convert.ToInt32(n3);

                                TriathlonFinalist tf = new TriathlonFinalist(name, surname, id, swim, bike, run);
                                break;
                            }
                            catch
                            {
                                TriathlonParticipant tp = new TriathlonParticipant(name, surname, id, swim, bike);
                                triathlonParticipants.Add(tp);
                                break;
                            }
                        }
                        catch
                        {
                            TriathlonParticipant tp = new TriathlonParticipant(name, surname, id, swim);
                            triathlonParticipants.Add(tp);
                            break;
                        }
                    }
                    catch
                    {
                        TriathlonParticipant tp = new TriathlonParticipant(name, surname, id);
                        triathlonParticipants.Add(tp);
                        break;
                    }
                }
            }
        }
    }
}
