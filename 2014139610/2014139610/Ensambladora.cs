using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139610
{
    public class Ensambladora
    {
        private TipoAuto _ta;
        private TipoBus _tb;
        private TipoCarro _tc;
        private Carro _carro;
        public Ensambladora(){
            _carro = new Carro();
        }
        public Ensambladora (TipoAuto tipoAuto, TipoBus tipoBus, TipoCarro tipoCarro){
            _tc = tipoCarro;
            _ta = tipoAuto;
            _tb = tipoBus;
        }
        public Carro carro { get { return _carro; } }
    }
}
