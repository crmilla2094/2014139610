using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139610
{
    public class bus : Carro
    {
        public TipoBus _tipoBus { get; set;}
        private int _numAsientos { get; set; }
        public bus() { 
        }
        public bus(TipoBus tipoBus, int numAsientos) {
            _tipoBus = tipoBus;
            _numAsientos = numAsientos;
        }
    }
}
