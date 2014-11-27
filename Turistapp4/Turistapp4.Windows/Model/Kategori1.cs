using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turistapp4.Model
{
    public class Kategori1
    {

        public Kategori1(string kategorinavn, string beskrivelse, string billede)
        {
            this.kategorinavn = kategorinavn;
            this.beskrivelse = beskrivelse;
            this.billede = billede;
        }


        public string kategorinavn { get; set; }
        public string beskrivelse { get; set; }
        public string billede { get; set; }

        public override string ToString()
        {
            return "";
        }
    }
}
