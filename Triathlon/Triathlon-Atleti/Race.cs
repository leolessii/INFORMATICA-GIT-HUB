using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triathlon_Atleti
{
    public class Race
    {
        private List<TriathlonParticipant> triathlonParticipant_;
        private List<TriathlonFinalist> triathlonFinalist_;

        public List<TriathlonParticipant> TriathlonParticipant
        { 
            get { return triathlonParticipant_; } 
        }

        public List<TriathlonFinalist> TriathlonFinalist
        { 
            get { return triathlonFinalist_; } 
        }

        public Race (List<TriathlonParticipant> tp, List<TriathlonFinalist> tf)
        {
            triathlonParticipant_ = tp;
            triathlonFinalist_ = tf;
        }

        public string TriathlonParticipantsList()
        {
            string list = string.Empty;
            for(int i = 0; i < triathlonParticipant_.Count; i++)
            {
                list += triathlonParticipant_[i].ToString();
                list += ";";
            }
            return list;    
        }

        public string TriathlonFinalistsList()
        {
            string list = string.Empty;
            for (int i = 0; i < triathlonFinalist_.Count; i++)
            {
                list += triathlonFinalist_[i].ToString();
                list += ";";
            }
            return list;
        }
    }
}
