using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139610
{
    public class Automovil : Carro
    {
        public TipoAuto TipoAuto { get; set; }
        private Volante _volante;
        private Parabrisas _parabrisas;
        private int _numLlantas;
        private int _numAsientos;
        private Propietario _propietario;
        private TipoCarro _tipoCarro;
        public Automovil() { }
        public Automovil (Volante volante, Parabrisas parabrisas, 
            Propietario propietario, TipoCarro tipoCarro, TipoAuto tipoAuto){
            _volante = volante;
            _parabrisas = parabrisas;
            //_numLlantas = numLlantas;
            //_numAsientos = numAsientos;
            _propietario = propietario;
            _tipoCarro = tipoCarro;
        }

        }
    
}
