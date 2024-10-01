using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spedizioni
{
    public class PackList // : Pacco
    {
        //come fare a collegare l'erediotarietá
        public List<Pack> _pacchi;

        public List<Pack> Pacchi // : base ()
        {
            get { return _pacchi; } 
        }

        public PackList () 
        {
            _pacchi = new List<Pack> ();
        }
        
        public void AddPackage(Pack pack)
        {
            _pacchi.Add (pack);
        }
    }
}
