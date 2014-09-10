using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evideoteka
{
    class nacionalnost
    {
        public int idNacionalnost { get; set; }
        public string naziv { get; set; }
        public override string ToString()
        {
            return naziv;
        }

    }
}
