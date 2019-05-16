using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DartLeagueManager.Models
{
    public class PlayerCricketStats
    {
        public int Id { get; set; }

        public DateTime GameDate { get; set; }

        public int DartCount { get; set; }

        public int Points { get; set; }

        public bool Won { get; set; }
    }
}
