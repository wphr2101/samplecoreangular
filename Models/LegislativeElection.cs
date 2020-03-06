using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class LegislativeElection
    {
        public string CityDistrict { get; set; }
        public int CandidateNumber { get; set; }
        public string CandidateName { get; set; }
        public string Party { get; set; }
        public int Votes { get; set; }
        public bool Elect { get; set; }
    }
}
