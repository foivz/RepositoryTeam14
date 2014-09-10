using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evideoteka
{
    class model
    {
        public int idKorisnik { get; set; }
        public string naziv { get; set; }
        public string opis { get; set; }
        public float cijena { get; set; }
        public int trajanje { get; set; }

        public override string ToString()
        {
            return naziv;
        }
    }
}
