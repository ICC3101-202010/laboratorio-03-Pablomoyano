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
            int choice;
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice==1)
            { }
            else if (choice == 2)
            {
                List<string> randomnames = new List<string>() { "Juan","Filiberto","Octavio","Alejandro","Ramon","Hermelinda","Ana","Marta","Florentina",
                "Odila","Francisco","Luis","Vilma","Cristina","Ruperta","Jose","Alvaro","Alfonso","Tania","Carmen","Laura","Cristina","Raquel","Marcelino",
                "Medardo","Fabian","Andres","Famara","Damaris","Isabel","Josefa",};
                List<string> randomlastnames = new List<string>() {"Mata Morato","Rojano","Manuel Tomas","Cañamero","Alcantara","Marichal","Costoya",
                "Gañan","Arcos","Malagon","Junco","Orea","Ortiz","Dolores","Zaldua","Orduña","Ruzafa","Parron","Iniesta","Pernia","Jane","Nasarre","Bodas",
                "Arques","Castaño","Mayans","Vivas","Moneo","Borrallo","Montaner"};

                }
            else
            { Console.WriteLine("Input invalido"); }
        }   
    }
}
