using System;
using System.Collections.Generic;

namespace CricketWebApp.Models
{
    public partial class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string Continent { get; set; }
        public int? CountryCode { get; set; }
    }
}
