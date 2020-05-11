using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2s_lab1
{
    class ConcertStorage
    {
        public List<Concert> consertList = new List<Concert>();

        public ConcertStorage()
        {
        }

        public void addConsert(Concert concert)
        {
            consertList.Add(concert);
        }

        //public void addPerformance(Performance performance)
        //{
        //    consertList[0].addPerformance(performance);
        //}

        //public void addPerformance(Performance performance)
        //{
        //    eventList.Add(performance);
        //}

        //public void addPerfomer(Performer perfomer)
        //{
        //    perfomerList.Add(perfomer);
        //}
    }
}
