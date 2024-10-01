using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spedizioni
{
    internal class Agency
    {
        public List<PackList> _packLists;

        public List<PackList> PackLists
        {
            get { return _packLists; }
        }

        public Agency()
        {
            _packLists = new List<PackList>();
        }

        public void AddPack(PackList packList)
        {
            _packLists.Add(packList);
        }

        public Pack FindPackWithId(string id)
        {
            for(int i=0; i <_packLists.Count; i++)
            {
                for (int j=0; j<_packLists.) //non trova la lista di pacchi all'interno della lista di liste di pacchi
            }

        }
    }
}
