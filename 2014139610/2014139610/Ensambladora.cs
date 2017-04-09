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
        private Carro car;
        private int _numLlantas;
        private int _numAsientos;
        public Ensambladora(){
         _carro = new List<Carro>();
            _ta = new List<TipoAuto>();
            car = new Carro();
        }
        public void Agregar(Carro carro, string numero) {
            if (numero[0] == 'a')
            {
                if (numero[1] == 's')
                {
                    _carro.Add(new Automovil(carro.volante, carro.parabrisas, carro.propietario, TipoCarro.Automovil,
                    TipoAuto.Sedan));
                    Console.WriteLine("Es un: Sedan");
                }
                else {
                    if (numero[1] == 'p')
                    {
                        _carro.Add(new Automovil(carro.volante, carro.parabrisas, carro.propietario, TipoCarro.Automovil,
                        TipoAuto.PickUp));
                        Console.WriteLine("Es un: PickUp");
                    }
                    else {
                        if (numero[1] == 'c')
                        {
                            _carro.Add(new Automovil(carro.volante, carro.parabrisas, carro.propietario, TipoCarro.Automovil,
                            TipoAuto.Coupe));
                            Console.WriteLine("Es un: Coupe");
                        }
                        else {
                            if (numero[1] == 'h')
                            {
                                _carro.Add(new Automovil(carro.volante, carro.parabrisas, carro.propietario, TipoCarro.Automovil,
                                TipoAuto.HatchBack));
                                Console.WriteLine("Es un: HatchBack");
                            }
                            else {
_carro.Add(new Automovil(carro.volante, carro.parabrisas, carro.propietario, TipoCarro.Automovil,
                    TipoAuto.NoDefinido));
                                Console.WriteLine("Es un: No definido");
                            }
                        }
                    }
                }
                
            }
            else {
                
                if (numero[1] == '1') {
                    _carro.Add(new bus(carro.volante, carro.parabrisas, carro.propietario, TipoCarro.Bus,
                    TipoBus.Publico));
                    Console.WriteLine("Es un: Bus Público");
                }
                else {
                    if (numero[1] == '2')
                    {
                        _carro.Add(new bus(carro.volante, carro.parabrisas, carro.propietario, TipoCarro.Bus,
                            TipoBus.Privado));
                        Console.WriteLine("Es un: Bus privado");
                    }
                    else {
                        _carro.Add(new bus(carro.volante, carro.parabrisas, carro.propietario, TipoCarro.Bus,
                    TipoBus.NoDefinido));
                        Console.WriteLine("Es un: Bus no definido");
                    }
                }
            }
            }

            
                
       public void Eliminar(Carro carro, string numero) {
            Carro car = new Carro();
            Carro carrito = _carro.Find(c => c.NumSerieChasis == numero);
            if (numero[0] == 'a')
            {
                if (numero[1] == 's')
                {
                    _carro.Remove(new Automovil(carro.volante, carro.parabrisas, carro.propietario, TipoCarro.Automovil,
                    TipoAuto.Sedan));

                }
                else
                {
                    if (numero[1] == 'p')
                    {
                        _carro.Remove(new Automovil(carro.volante, carro.parabrisas, carro.propietario, TipoCarro.Automovil,
                        TipoAuto.PickUp));
                    }
                    else
                    {
                        if (numero[1] == 'c')
                        {
                            _carro.Remove(new Automovil(carro.volante, carro.parabrisas, carro.propietario, TipoCarro.Automovil,
                            TipoAuto.Coupe));
                        }
                        else
                        {
                            if (numero[1] == 'h')
                            {
                                _carro.Remove(new Automovil(carro.volante, carro.parabrisas, carro.propietario, TipoCarro.Automovil,
                                TipoAuto.HatchBack));
                            }
                            else
                            {
                                _carro.Remove(new Automovil(carro.volante, carro.parabrisas, carro.propietario, TipoCarro.Automovil,
                                                    TipoAuto.NoDefinido));
                            }
                        }
                    }
                }

            }
            else
            {

                if (numero[1] == '1')
                {
                    _carro.Remove(new bus(carro.volante, carro.parabrisas, carro.propietario, TipoCarro.Bus,
                    TipoBus.Publico));
                }
                else
                {
                    if (numero[1] == '2')
                    {
                        _carro.Remove(new bus(carro.volante, carro.parabrisas, carro.propietario, TipoCarro.Bus,
                            TipoBus.Privado));
                    }
                    else
                    {
                        _carro.Remove(new bus(carro.volante, carro.parabrisas, carro.propietario, TipoCarro.Bus,
                    TipoBus.NoDefinido));
                    }
                }
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

       
       

        
    

