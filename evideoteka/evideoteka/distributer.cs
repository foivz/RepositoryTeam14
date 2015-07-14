using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evideoteka
{
    class distributer
    {
        public int idDistributer { get; set; }
        public string naziv { get; set; }
        public string adresa { get; set; }
        public string telefon { get; set; }
        public string faks { get; set; }
        public string email { get; set; }
        public string oib { get; set; }
        public int status { get; set; }

        public override string ToString()
        {
            return naziv;
        }

    }
}
