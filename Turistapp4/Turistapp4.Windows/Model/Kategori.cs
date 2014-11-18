using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Turistapp4.Annotations;

namespace Turistapp4.Model
{
    public class Kategori
    {
        private string _navn;
        private string _beskrivelse;
        private string _billede1;
        private string _billede2;
        private string p;

        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }

        public string Beskrivelse
        {
            get { return _beskrivelse; }
            set { _beskrivelse = value; }
        }

        public string Billede1
        {
            get { return _billede1; }
            set { _billede1 = value; }
        }

        public Kategori(string navn, string beskrivelse, string billede1, string billede2)
        {
            _navn = navn;
            _beskrivelse = beskrivelse;
            _billede1 = billede1;
            _billede2 = billede2;
        }

        public Kategori(string p)
        {
            this.p = p;
        }

        public override string ToString()
        {
            return _navn;
        }
    }
}
