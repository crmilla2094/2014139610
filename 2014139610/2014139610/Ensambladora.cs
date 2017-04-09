using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139610
{
    public class Ensambladora
    {   private string tipo;
        private List<TipoAuto> _ta;
        private List<TipoBus> _tb;
        private List<TipoCarro> _tc;
        private List<Carro> _carro;
        private int _numLlantas;
        private int _numAsientos;
        public Ensambladora(){
         _carro = new List<Carro>();
            _ta = new List<TipoAuto>();
        }
        public void Agregar(Carro carro) {
            _carro.Add(new Automovil(carro.volante, carro.parabrisas, carro.propietario, TipoCarro.Automovil,
                TipoAuto.Coupe));
            }

            
           }        
       /* public void Eliminar(Carro carro) {

        }
        public bool IniciarPersonalizacion(string numero) {
            if (numero[0] == 'a') {
                return true;
            }
            else {return true;  }
                }
        public bool FinalizarPersonalizacion()
        {
            return true;
        }
        public void EnsamblarCarro()
        {
            
        }*/
    }

       
       

        
    

