using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aplikacija.Models
{
    public class Zaposlenik
    {
        public int IdZaposlenik { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Password { get; set; }

    }
}