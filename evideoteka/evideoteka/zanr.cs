using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evideoteka
{
    class zanr
    {
        public int idZanr { get; set; }
        public string naziv { get; set; }
        public string opis { get; set; }

        public int status { get; set; }

        public override string ToString()
        {
            return naziv;
        }
    }
}
