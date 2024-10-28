using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triathlon_Atleti
{
    public class Race
    {
        private List<TriathlonParticipant> _triathlonParticipant;
        private List<TriathlonFinalist> _triathlonFinalist;
        private SwimSort _s;
        private BikeSort _b;
        private RunSort _r;

        public List<TriathlonParticipant> TriathlonParticipant
        { 
            get { return _triathlonParticipant; } 
        }

        public List<TriathlonFinalist> TriathlonFinalist
        { 
            get { return _triathlonFinalist; } 
        }

        public Race (List<TriathlonParticipant> tp, List<TriathlonFinalist> tf)
        {
            _triathlonParticipant = tp;
            _triathlonFinalist = tf;
        }

        public string TriathlonParticipantsList()
        {
            string list = string.Empty;
            for(int i = 0; i < _triathlonParticipant.Count; i++)
            {
                list += _triathlonParticipant[i].ToString();
                list += ";";
            }
            return list;    
        }

        public string TriathlonFinalistsList()
        {
            string list = string.Empty;
            for (int i = 0; i < _triathlonFinalist.Count; i++)
            {
                list += _triathlonFinalist[i].ToString();
                list += ";";
            }
            return list;
        }

        public void AssignPrizeForSwim()
        {
            for(int i=0; i < _triathlonParticipant.Count;i++)
            {

            }
        }

        public void AssignPrizeForBike()
        {

        }

        public void AssignPrizeForRun()
        {

        }

        public void AssignPrizeForFirstFiveFinalist()
        {

        }
    }
}
