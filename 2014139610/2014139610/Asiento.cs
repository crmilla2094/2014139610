using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139610
{
    public class Asiento
    {
        public string NumSerie {get; set;}
        
        private Cinturon _cinturon;
        public Asiento() {
            _cinturon = new Cinturon();
        }
        public Asiento(string numser) {
            NumSerie = numser;
            
        }
        public Cinturon cinturon { get {return _cinturon;} }
    }
}
