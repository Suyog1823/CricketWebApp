using System;
using System.Collections.Generic;

namespace CricketWebApp.Models
{
    public partial class Stadium
    {
        public int StadiumId { get; set; }
        public int? StadiumCountry { get; set; }
        public string StadiumName { get; set; }
        public int? NoOfMatchesAllowed { get; set; }
    }
}
