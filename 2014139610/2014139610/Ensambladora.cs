using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139610
{
    public class Ensambladora
    {   private string tipo;
        private string a;
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
        public void Agregar(Carro carro, string numero) {
            if (numero[0] == 'a')
            {
                Console.WriteLine("Seleccionar tipo de Auto: \n" +
                    "[1]Sedan\n"+
        "[2]PickUp\n"+
        "[3]Coupe\n" +
        "[4]HatchBack\n" +
        "[5]NoDefinido\n");
                string selec = Console.ReadLine();
                if (selec == "1")
                {
                    _carro.Add(new Automovil(carro.volante, carro.parabrisas, carro.propietario, TipoCarro.Automovil,
                    TipoAuto.Sedan));
                }
                else {
                    if (selec == "2")
                    {
                        _carro.Add(new Automovil(carro.volante, carro.parabrisas, carro.propietario, TipoCarro.Automovil,
                        TipoAuto.PickUp));
                    }
                    else {
                        if (selec == "3")
                        {
                            _carro.Add(new Automovil(carro.volante, carro.parabrisas, carro.propietario, TipoCarro.Automovil,
                            TipoAuto.Coupe));
                        }
                        else {
                            if (selec == "4")
                            {
                                _carro.Add(new Automovil(carro.volante, carro.parabrisas, carro.propietario, TipoCarro.Automovil,
                                TipoAuto.HatchBack));
                            }
                            else {
_carro.Add(new Automovil(carro.volante, carro.parabrisas, carro.propietario, TipoCarro.Automovil,
                    TipoAuto.NoDefinido));
                            }
                        }
                    }
                }
                
            }
            else {
                Console.WriteLine("Seleccionar tipo de Bus: \n" +
                    "[1]Público\n" +
        "[2]Privado\n" +
        "[3]NoDefinido\n");
                string selec = Console.ReadLine();
                if (selec=="1") {
                    _carro.Add(new bus(carro.volante, carro.parabrisas, carro.propietario, TipoCarro.Bus,
                    TipoBus.Publico));
                }
                else {
                    if (selec == "2")
                    {
                        _carro.Add(new bus(carro.volante, carro.parabrisas, carro.propietario, TipoCarro.Bus,
                            TipoBus.Privado));
                    }
                    else {
                        _carro.Add(new bus(carro.volante, carro.parabrisas, carro.propietario, TipoCarro.Bus,
                    TipoBus.NoDefinido));
                    }
                }
            }
            }

            
                
       public void Eliminar(Carro carro, string numero) {
            if (numero[0] == 'a')
            {
                _carro.Remove(new Automovil(carro.volante, carro.parabrisas, carro.propietario, TipoCarro.Automovil,
                    TipoAuto.Coupe));
            }
            else
            {
                _carro.Remove(new bus(carro.volante, carro.parabrisas, carro.propietario, TipoCarro.Bus,
                    TipoBus.Privado));
            }
        }
        public void IniciarPersonalizacion(string numero) {
            Carro c = new Carro();
            c.NumSerieChasis = numero;
                }
        public void FinalizarPersonalizacion()
        {
            
        }
        public void EnsamblarCarro()
        {
            
        }

    }   
    }

       
       

        
    

