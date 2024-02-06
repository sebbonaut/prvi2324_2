using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prvi2324_2
{
    public class Artikl
    {
        public string Naziv {  get; set; }
        public decimal cijena;
        public string Cijena => cijena.ToString("0.00") + " EUR";
        public decimal popust;
        public string Popust
            => (popust * 100).ToString("0.00") + "%";

        //konstruktor:
        public Artikl(string naziv, decimal cijena,
            decimal popust)
        {
            Naziv = naziv;
            this.cijena = cijena;
            this.popust = popust;
        }
    }
}
