using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al programa del super mercado,porfavor elija su forma de revisar las compras:");
            Console.WriteLine("1:Metodo manual.");
            Console.WriteLine("2:Metodo random.");
            Console.WriteLine("3:Salir");
            int choice;
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice==1)
            { Console.WriteLine("Empieze creando a los clientes:");
                int ns = Convert.ToInt32(Console.ReadKey());
                while (ns==1)
                { Console.WriteLine("Introduzca el nombre:");
                    string ncn = Console.ReadLine();
                    Console.WriteLine("Introduzca el apellido:");
                    string ncl= Console.ReadLine();
                    Console.WriteLine("Introduzca el RUT:");
                    string ncr= Console.ReadLine();
                    Console.WriteLine("Introduzca la fecha de nacimiento");
                    string ncd = Console.ReadLine();
                    Person cl = new Person(ncn, ncl, ncd, ncr);
                    Console.WriteLine("Seleccione 1 para volver a crear otro cliente,si quiere continuar presione otro numero");
                    ns = Convert.ToInt32(Console.ReadKey());
                }
            }
            else if (choice == 2)
            {
                List<string> randomnames = new List<string>() { "Juan","Filiberto","Octavio","Alejandro","Ramon","Hermelinda","Ana","Marta","Florentina",
                "Odila","Francisco","Luis","Vilma","Cristina","Ruperta","Jose","Alvaro","Alfonso","Tania","Carmen","Laura","Cristina","Raquel","Marcelino",
                "Medardo","Fabian","Andres","Famara","Damaris","Isabel","Josefa",};
                List<string> randomlastnames = new List<string>() {"Mata Morato","Rojano","Manuel Tomas","Cañamero","Alcantara","Marichal","Costoya",
                "Gañan","Arcos","Malagon","Junco","Orea","Ortiz","Dolores","Zaldua","Orduña","Ruzafa","Parron","Iniesta","Pernia","Jane","Nasarre","Bodas",
                "Arques","Castaño","Mayans","Vivas","Moneo","Borrallo","Montaner"};
                Random rnd = new Random();
                int nom = rnd.Next(0, 32);
                int ape = rnd.Next(0, 31);
                int dy = rnd.Next(1, 32);
                int mnt = rnd.Next(1, 13);
                int yr = rnd.Next(1950, 2011);
                int st = rnd.Next(100);
                int pr = rnd.Next(5000, 25001);

                }
            else if (choice==3)
            { Console.WriteLine("Gracias por usar el programa");
                Console.ReadKey();
            }
            else
            { Console.WriteLine("Input invalido");
                Console.ReadKey();
            }
        }   
    }
}
