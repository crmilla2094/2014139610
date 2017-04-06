using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139610
{
    class bus : Carro
    {
        public TipoBus TipoBus { get; set; }
        private int _numAsientos;
        public bus() { 
        }
        public bus(int numAsientos) {
            _numAsientos = numAsientos;
        }
    }
}
