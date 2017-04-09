using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139610
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*Volante vol1 = new Volante("avol001");
            Parabrisas par1= new Parabrisas("apar001");
            Propietario pers1 = new Propietario("70874455", "Roberto", "Aranguren", "ABC120");
            Carro carro1 = new Carro(vol, par, 4, 5,
            pers1, TipoCarro.Automovil);*/
            var a = new Ensambladora();
            var c = new Carro();
            Console.WriteLine("Volante: ");
            string vol = Console.ReadLine();
            Volante vol1 = new Volante(vol);
            Console.WriteLine("Parabrisas: ");
            string par = Console.ReadLine();
            Parabrisas par1 = new Parabrisas(par);
            Console.WriteLine("Nombre: ");
            string nom = Console.ReadLine();
            Console.WriteLine("Apellido: ");
            string ape = Console.ReadLine();
            Console.WriteLine("Licencia: ");
            string lic = Console.ReadLine();
            Console.WriteLine("Dni: ");
            string dni = Console.ReadLine();
            Propietario per = new Propietario(dni, nom, ape, lic);
            Carro carro = new Carro(vol1, par1, per, TipoCarro.Automovil);
            a.Agregar(carro);
            c.AsientosyLLantas();
        }
    }
}
