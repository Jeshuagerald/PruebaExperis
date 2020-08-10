using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppTalent.Models
{
    public class Candidates
    {
        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
    }
}