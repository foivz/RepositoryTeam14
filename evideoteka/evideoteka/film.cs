using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evideoteka
{
    class film
    {
        public int idFilm { get; set; }
        public string naziv { get; set; }
        public string godina { get; set; }
        public string trajanje { get; set; }
        public string jezik { get; set; }
        public string zemlja { get; set; }
        public string putanja { get; set; }
        public int distributer { get; set; }
        public int status { get; set; }

        public override string ToString()
        {
            return naziv;
        }

    }
}
