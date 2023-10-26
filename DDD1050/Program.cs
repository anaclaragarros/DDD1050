using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DDD1050
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int ddd;

            string DDD = Console.ReadLine();
 

            if (int.TryParse(DDD, out ddd))
            {
               
                switch (ddd) { 
                        case 61:
                    Console.WriteLine("Brasilia");
                        break;
                    case 71:
                        Console.WriteLine("Salvador");
                        break;
                    case 11:
                        Console.WriteLine("Sao Paulo");
                        break;
                    case 21:
                        Console.WriteLine("Rio de Janeiro");
                        break;
                    case 32:
                        Console.WriteLine("Juiz de Fora");
                        break;
                    case 19:
                        Console.WriteLine("Campinas");
                        break;
                    case 27:
                        Console.WriteLine("Vitoria");
                        break;
                    case 31:
                        Console.WriteLine("Belo Horizonte");
                        break;
                    default:
                        Console.WriteLine("DDD nao cadastrado");
                        break;

                }

            }
            else { Console.WriteLine("invalido"); }
            Console.ReadKey();
        }
        
    }
}


