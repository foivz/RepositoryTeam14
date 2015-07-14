using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evideoteka
{
    class glumac
    {
        public int idGlumac { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string datumRodenja { get; set; }
        public int status { get; set; }

        public override string ToString()
        {
            return ime + prezime;
        }

    }
}
