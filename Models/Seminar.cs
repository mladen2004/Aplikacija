using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aplikacija.Models
{
    public class Seminar
    {
        public int IdSeminar { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public DateTime? Datum { get; set; }
        public bool Popunjen { get; set; }
    }
}