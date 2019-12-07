﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aplikacija.Models
{
    public class Predbiljezba
    {
        public int IdPredbiljezba { get; set; }
        public DateTime? Datum { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public int IdSeminar { get; set; }
        public string Status { get; set; }
    }
}