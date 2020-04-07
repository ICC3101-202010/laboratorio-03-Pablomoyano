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

            if (choice == 1)
            {
                Console.WriteLine("Eliga lo que quiere crear:");
                Console.WriteLine("1:Cliente");
                Console.WriteLine("2:Producto");
                Console.WriteLine("3:Trabajador");
                Console.WriteLine("4:Editar Trabajador");
                Console.WriteLine("5:Realizar compras");
                int ns = Convert.ToInt32(Console.ReadKey());
                if (ns == 1)
                {
                    while (ns == 1)
                    {
                        Console.WriteLine("Introduzca el nombre:");
                        string ncn = Console.ReadLine();
                        Console.WriteLine("Introduzca el apellido:");
                        string ncl = Console.ReadLine();
                        Console.WriteLine("Introduzca el RUT:");
                        string ncr = Console.ReadLine();
                        Console.WriteLine("Introduzca la fecha de nacimiento");
                        string ncd = Console.ReadLine();
                        Console.WriteLine("Introduzca la nacionalidad");
                        string ncna = Console.ReadLine();
                        Person cl = new Person(ncn, ncl, ncr, ncd, ncna);
                        cl.addinfo(ncn, ncl, ncr, ncd, ncna);
                        Console.WriteLine("Seleccione 1 para volver a crear otro cliente,2 para crear un producto,3 para crear un trabajador,4 para editar a un trabajador o 5 para realizar compras");
                        ns = Convert.ToInt32(Console.ReadKey());
                    }
                }
                else if (ns == 2)
                {
                    while (ns == 2)
                    { }
                }
                else if (ns == 3)
                {
                    while (ns == 3)
                    { }
                }
                else if (choice == 2)
                {
                    List<string> randomnames = new List<string>() { "Juan","Filiberto","Octavio","Alejandro","Ramon","Hermelinda","Ana","Marta","Florentina",
                "Odila","Francisco","Luis","Vilma","Cristina","Ruperta","Jose","Alvaro","Alfonso","Tania","Carmen","Laura","Cristina","Raquel","Marcelino",
                "Medardo","Fabian","Andres","Famara","Damaris","Isabel","Josefa",};
                    List<string> randomlastnames = new List<string>() {"Mata Morato","Rojano","Manuel Tomas","Cañamero","Alcantara","Marichal","Costoya",
                "Gañan","Arcos","Malagon","Junco","Orea","Ortiz","Dolores","Zaldua","Orduña","Ruzafa","Parron","Iniesta","Pernia","Jane","Nasarre","Bodas",
                "Arques","Castaño","Mayans","Vivas","Moneo","Borrallo","Montaner"};
                    List<string> randomproduct = new List<string>() {"arroz","papas","aceite","detergente","jabon","ketchup","bebida","jugo","pure","dulces","sal",
                "pimienta","oregano","queso","leche","carne","vienesas","carbón","cebollas","pan","pimientos","papel confort","","","","","","","",""};
                    List<string> randombrand = new List<string>() { "soprole","savory","milo","colun","ambrosoli","columbia","ziploc","nova","super pollo"
                ,"nescafe","chandelle","pepsodent"};
                    Random rnd = new Random();
                    int nom = rnd.Next(0, 32);
                    int ape = rnd.Next(0, 31);
                    int dy = rnd.Next(1, 32);
                    int mnt = rnd.Next(1, 13);
                    int yr = rnd.Next(1950, 2011);
                    int st = rnd.Next(100);
                    int pr = rnd.Next(5000, 25001);

                }
                else if (choice == 3)
                {
                    Console.WriteLine("Gracias por usar el programa");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Input invalido");
                    Console.ReadKey();
                }
            }
        }
    }
}
