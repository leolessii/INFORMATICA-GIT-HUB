using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spedizioni
{
    public class Agency
    {
        public List<List<Pack>> _packLists;

        public List<List<Pack>> PackLists
        {
            get { return _packLists; }
        }

        public Agency()
        {
            _packLists = new List<List<Pack>>();
        }

        public void AddPack(List<Pack> packList)
        {
            _packLists.Add(packList);
        }

        public Pack? FindPackWithId(string id)
        {
            for(int i=0; i <_packLists.Count; i++)
            {
                for (int j = 0; j < _packLists[i].Count; i++)
                {
                    if(j.Equals(id) == true)
                    {
                        return _packLists[i][j];
                    }
                }  
            }
            return null;
        }

        public List<Pack>? GeneratePackWithDateAndCity (DateOnly startDate, DateOnly endDate, string city)
        {
            List<Pack> list = new List<Pack>();
            for (int i = 0; i < _packLists.Count; i++)
            {
                for (int j = 0; j < _packLists[i].Count; i++)
                {
                    if (_packLists[i][j].SpeditionDate >= startDate && _packLists[i][j].SpeditionDate <= endDate && _packLists[i][j].City == city)
                    {
                        list.Add(_packLists[i][j]);
                    }
                }
            }
            return null;
        }

        public double? CalculateMarkedPackCost(List<Pack> list)
        {
            double markedPackCost = new double();
            for (int i = 0; i < _packLists.Count; i++)
            {
                for (int j = 0; j < _packLists[i].Count; i++)
                {
                    if (_packLists[i][j] is PackMark)
                    {
                        PackMark p = _packLists[i][j] as PackMark;
                        markedPackCost += p.Mark;
                    }
                }
            }
            return markedPackCost;
        }
    }
}
