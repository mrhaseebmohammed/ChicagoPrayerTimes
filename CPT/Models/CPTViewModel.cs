using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CPT.Models
{
    public class CPTViewModel
    {
        public int Index { get; set; }
        public string Name { get; set; }
        public string Fajr { get; set; }
        public string Zuhr { get; set; }
        public string Asr { get; set; }
        public string Maghrib { get; set; }
        public string Isha { get; set; }
        public string Jummah { get; set; }
        public string Jummah2 { get; set; }
        public string Address { get; set; }
    }
}