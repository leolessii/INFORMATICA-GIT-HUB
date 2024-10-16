using ReadingFile;
using Triathlon_Atleti;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReadingFile r = new ReadingFile();
            Race race = new Race(r.triathlonParticipant, r.triathlonFinalist);

            r.TriathlonParticipantsList();
            r.TrithlonFinalistsList();
        }
    }
}
