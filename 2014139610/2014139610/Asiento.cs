using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139610
{
    class Asiento
    {
        public string NumSerie {get; set;}
        
        private Cinturon _cinturon;
        public Asiento() { }
        public Asiento(string numser) {
            NumSerie = numser;
            _cinturon = new Cinturon();
        }
        public Cinturon cinturon { get {return _cinturon;} }
    }
}
