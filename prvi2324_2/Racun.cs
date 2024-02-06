using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prvi2324_2
{
    public class Racun
    {
        public DateTime Datum { get; set; }
        public string Naziv { get; set; }
        public string Ukupno {
            get
            {
                decimal ukupno = 0;
                foreach (var artikl in artikli) {
                    ukupno += artikl.cijena * (1 - artikl.popust);
                }
                return ukupno.ToString("0.00") + " EUR";
            }
        }
        public List<Artikl> artikli = new List<Artikl>();
        
        //konstruktor:
        public Racun(string naziv, DateTime datum, 
            List<Artikl> artikli)
        {
            Datum = datum;
            Naziv = naziv;
            this.artikli = artikli;
        }
    }
}
