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
        { string numChasis;
            Volante vol1 = new Volante("avol001");
            Parabrisas par1 = new Parabrisas("apar001");
            Propietario pers1 = new Propietario("70874455", "Roberto", "Aranguren", "ABC120");
            numChasis = "achasis01";

            var a = new Ensambladora();
            var c = new Carro();

            /*Console.WriteLine("Volante: ");
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
            string dni = Console.ReadLine();*/

            Carro carro1 = new Carro(vol1, par1, pers1, TipoCarro.Automovil);

            a.Agregar(carro1, numChasis);
            

            Volante vol2 = new Volante("avol002");
            numChasis = "achasis02";
            Parabrisas par2 = new Parabrisas("apar002");
            Propietario pers2 = new Propietario("70874480", "Roberto", "Milla", "ABC121");
            Carro carro2 = new Carro(vol2, par2, pers2, TipoCarro.Automovil);
            a.IniciarPersonalizacion(numChasis);
            a.Agregar(carro2, numChasis);
            

            Volante vol3 = new Volante("avol003");
            Parabrisas par3 = new Parabrisas("apar003");
            numChasis = "achasis03";
            Propietario pers3 = new Propietario("06692345", "Johny", "Cuya", "ABC122");
            Carro carro3 = new Carro(vol1, par1, pers1, TipoCarro.Automovil);
            a.IniciarPersonalizacion(numChasis);
            a.Agregar(carro3, numChasis);
            

            Volante vol4 = new Volante("avol004");
            Parabrisas par4 = new Parabrisas("apar004");
            Propietario pers4 = new Propietario("70874460", "Consuelo", "Egoavil", "ABC123");
            Carro carro4 = new Carro(vol4, par4, pers4, TipoCarro.Automovil);
            numChasis = "achasis04";
            a.IniciarPersonalizacion(numChasis);
            a.Agregar(carro4, numChasis);
            

            Volante vol5 = new Volante("bvol005");
            Parabrisas par5 = new Parabrisas("bpar005");
            Propietario pers5 = new Propietario("06752810", "Deissy", "Cuya", "ABC124");
            Carro carro5 = new Carro(vol5, par5, pers5, TipoCarro.Bus);
            numChasis = "bchasis05";
            a.IniciarPersonalizacion(numChasis);
            a.Agregar(carro5,numChasis);
            

            Volante vol6 = new Volante("bvol006");
            Parabrisas par6 = new Parabrisas("bpar006");
            Propietario pers6 = new Propietario("06795134", "Rosario", "Milla", "ABC125");
            Carro carro6 = new Carro(vol5, par5, pers5, TipoCarro.Bus);
            numChasis = "bchasis06";
            a.IniciarPersonalizacion(numChasis);
            a.Agregar(carro5,numChasis);
            
        }
    }
}
