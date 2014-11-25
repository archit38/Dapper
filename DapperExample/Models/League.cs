using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DapperExample.Dapper
{
    public class League
    {
        public int LeagueID { get; set; }

        public string Name { get; set; }

        public int RunPoints { get; set; }

        public int WicketPoints { get; set; }

        public int CatchPoints { get; set; }

        public int RunoutPoints { get; set; }

        public int WicketKeeperOffset { get; set; }

        public int CaptainPoints { get; set; }

        public int WinPointsPoints { get; set; }

        public int ExtraRuleID { get; set; }

        //public int List<Challenge> Challenges { get; set; }
        //public int List<Match> Matches { get; set; }
    }
}