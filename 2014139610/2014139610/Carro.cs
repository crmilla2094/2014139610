using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139610
{
    public class Carro
    {
        private Volante _volante;
        private Parabrisas _parabrisas;
        private int _numLlantas;
        private int _numAsientos;
        private Propietario _propietario;
        private TipoCarro _tipoCarro;
    public string NumSerieMotor { get; set; }
    public string NumSerieChasis { get; set; }
    public Carro (){
        
    }
    public Carro (Volante volante, Parabrisas parabrisas, int numLlantas, int numAsientos,
            Propietario propietario, TipoCarro tipoCarro, TipoAuto tipoAuto){
        _volante = volante;
        _parabrisas = parabrisas;
        _propietario = propietario;
        _tipoCarro = tipoCarro;
            _numLlantas = numLlantas;
            _numAsientos = numAsientos;
            
    }
    }
}
