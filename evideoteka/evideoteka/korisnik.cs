using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evideoteka
{
    public class korisnik
    {
        public int idKorisnik { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string telefon { get; set; }
        public string email { get; set; }
        public int status { get; set; }
        public int tip { get; set; }
        public string korisnickoIme { get; set; }
        public string sifra { get; set; }
        public int adresa { get; set; }

        public override string ToString()
        {
            return korisnickoIme;
        }
    }
}
