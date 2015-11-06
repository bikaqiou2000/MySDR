using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MySDR.Web.Models
{
    public class PlanResponse
    {
        public string Packs { get;set;}
        public string Delays { get; set; }
        public bool Success { get; set; }
        public string ErrMsg { get; set; }
    }
}