﻿using System;
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
                        Console.WriteLine("Seleccione 1 para crear otro cliente,2 para crear un producto,3 para crear un trabajador,4 para editar a un trabajador o 5 para realizar compras y 6 para salir");
                        ns = Convert.ToInt32(Console.ReadKey());
                    }
                }
                else if (ns == 2)
                {
                    while (ns == 2)
                    {
                        Console.WriteLine("Introduzca el nombre del producto:");
                        string npro = Console.ReadLine();
                        Console.WriteLine("Introduzca la marca:");
                        string pbr = Console.ReadLine();
                        Console.WriteLine("Introduzca el precio:");
                        string pp = Console.ReadLine();
                        int tpp = Int32.Parse(pp);
                        Console.WriteLine("Introduzca el stock del producto");
                        string ps = Console.ReadLine();
                        int tps = Int32.Parse(ps);
                        Product newp = new Product(npro, pbr, tpp, tps);
                        newp.addpro(npro, pbr, tpp, tps);
                        Console.WriteLine("Seleccione 1 para crear otro cliente,2 para crear un producto,3 para crear un trabajador,4 para editar a un trabajador o 5 para realizar compras y 6 para salir");
                        ns = Convert.ToInt32(Console.ReadKey());


                    }
                }
                else if (ns == 3)
                {
                    while (ns == 3)
                    {
                        Console.WriteLine("Introduzca el nombre:");
                        string nwn = Console.ReadLine();
                        Console.WriteLine("Introduzca el apellido:");
                        string nwln = Console.ReadLine();
                        Console.WriteLine("Introduzca el RUT:");
                        string nwr = Console.ReadLine();
                        Console.WriteLine("Introduzca la fecha de nacimiento");
                        string nwd = Console.ReadLine();
                        Console.WriteLine("Introduzca la nacionalidad");
                        string nwna = Console.ReadLine();
                        Console.WriteLine("Introduzca el empleo:");
                        string nwj = Console.ReadLine();
                        Console.WriteLine("Introduzca el salario:");
                        string nww= Console.ReadLine();
                        int tnww = Int32.Parse(nww);
                        Console.WriteLine("Introduzca el horario");
                        string nwt= Console.ReadLine();
                        Worker newbie = new Worker(nwn, nwln, nwr, nwd, nwna, nwj, tnww, nwt);
                        newbie.infot(nwn, nwln, nwr, nwd, nwna, nwj, tnww, nwt);

                        Console.WriteLine("Seleccione 1 para crear otro cliente,2 para crear un producto,3 para crear un trabajador,4 para editar a un trabajador o 5 para realizar compras y 6 para salir");
                        ns = Convert.ToInt32(Console.ReadKey());
                    }
                }
                else if (ns==4)
                {while (ns == 4)
                    {

                        Console.WriteLine("Introduzca el rut del trabajador:");
                        string rwo = Console.ReadLine();

                        Console.WriteLine("Introduzca el nuevo empleo:");
                        string jwo = Console.ReadLine();
                        Console.WriteLine("Introduzca el salario:");
                        string wwo = Console.ReadLine();
                        int twwo = Int32.Parse(wwo);
                        Console.WriteLine("Introduzca el horario");
                        string tswo = Console.ReadLine();
                        Worker ch = new Worker();
                        int t = ch.findworker(rwo);
                        string a = ch.findname(t);
                        string b = ch.findln(t);
                        string c = ch.finddob(t);
                        string d = ch.findnat(t);
                        ch.changejob(t, jwo, twwo, tswo);
                        ch.cambiaempleo(a, b, rwo, c, d,jwo,twwo,tswo);
                        

                        Console.WriteLine("Seleccione 1 para crear otro cliente,2 para crear un producto,3 para crear un trabajador,4 para editar a un trabajador o 5 para realizar compras y 6 para salir");
                        ns = Convert.ToInt32(Console.ReadKey());
                    }
                }
                else if(ns==5)
                {while (ns==5)
                    { Product nc = new Product();
                        nc.showproducts();
                        Console.WriteLine("Quiere comprar? presione 7 para comprar o 8 para salir:");
                        int lc = Convert.ToInt32(Console.ReadKey());
                        if (lc==7)
                        {while (lc==7)
                            { Console.WriteLine("Escriba el rut del cliente:");
                                string rc = Console.ReadLine();
                                Console.WriteLine("Escriba el rut del cajero:");
                                string rs = Console.ReadLine();
                                Person client = new Person();
                                Worker cajero = new Worker();
                                int indexcliente= client.findclient(rc);
                                int indexcajero = cajero.findworker(rs);
                                string fn = client.namegot(indexcliente);
                                string lastn = client.lngot(indexcliente);
                                string wfn = cajero.findname(indexcajero);
                                string wln = cajero.findln(indexcajero);
                                string nombrecliente = fn + "" + lastn;
                                string nombrecajero = wfn + "" + wln;
                                List<string> carroproductos = new List<string>();
                                List<string> carromarcas = new List<string>();
                                List<int> mercado = new List<int>();
                                Console.WriteLine("Se empezara a usar el carro,presione 1 para continuar.");
                                int carro = Convert.ToInt32(Console.ReadKey());
                                while (carro == 1)
                                {
                                    Product now = new Product();
                                    Console.WriteLine("Escriba el numero del producto que desea agregar al carro:");
                                    int adc = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Escriba la cantidad que desea agregar:");
                                    int adcn = Convert.ToInt32(Console.ReadLine());
                                    int q=now.changestock(adc, adcn);
                                    if (q>0)
                                    { now.stockchanged(q, adc);
                                        string p = now.addcarro(adc);
                                        string m = now.addcarro2(adc);
                                        carroproductos.Add(p);
                                        carromarcas.Add(m);
                                        int pr = now.precios(adc);
                                        mercado.Add(pr);
                                    }
                                    else
                                    { Console.WriteLine("No ha sido posible agregar el producto debido a falta de stock"); }
                                    Console.WriteLine("Presione 1 para seguir añadiendo al carro,presione otra tecla para ir al final.");
                                    carro = Convert.ToInt32(Console.ReadKey());
                                }
                                Console.WriteLine("Estas han sido sus compras");
                                int i = carroproductos.Count();
                                int f = 0;
                                int g = 0;
                                while (f<i)
                                { Console.WriteLine(carroproductos[f]+""+carromarcas[f]+""+mercado[f]);
                                    g = g + mercado[f];
                                    f = f + 1;

                                }
                                DateTime hora = DateTime.Now;
                                DateTime fecha = DateTime.UtcNow;
                                Console.WriteLine("El precio total es: " + g);
                                Console.WriteLine("Hora de la compra: " + hora + " Fecha de la compra: " + fecha);
                                Console.WriteLine("El cliente fue: "+ nombrecliente);
                                Console.WriteLine("El cajero fue:" + nombrecajero);
                                Console.WriteLine("Gracias por usar el servicio,tenga un buen dia.");


                            }
                        }

                    }
                }
                else if (ns==6)
                { Console.WriteLine("Gracias por usar nuestro servicio."); }
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
                    List<string> randomnationality = new List<string>() {"chilena","argentina","peruana","canadiense","mexicana","australiana",
                    "boliviana","brasileña"};
                    List<string> randonvn = new List<string>() {"1","2","3","4","5","6","7","8","9","k" };
                    Random rnd = new Random();
                    int nom = rnd.Next(0, 32);
                    int ape = rnd.Next(0, 31);
                    int dy = rnd.Next(1, 32);
                    int mnt = rnd.Next(1, 13);
                    int yr = rnd.Next(1950, 2011);
                    int st = rnd.Next(100);
                    int wg = rnd.Next(400000, 2500001);
                    int pr = rnd.Next(5000, 25001);
                    int nt = rnd.Next(9);
                    int clients = rnd.Next(23);
                    int rt = rnd.Next(19000000, 31000001);
                    int rvn = rnd.Next(10);
                    


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
