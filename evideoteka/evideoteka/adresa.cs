using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evideoteka
{
    class adresa
    {
        public int idAdresa { get; set; }
        public string postanskiBroj { get; set; }
        public string mjesto { get; set; }
        public string ulica { get; set; }
        public int status { get; set; }

        public override string ToString()
        {
            return mjesto;
        }
    }
}
