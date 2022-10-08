using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Runtime.CompilerServices;
using System.ComponentModel.Design;

namespace Hash
{

    class Program
    {
        static void Main(string[] args)
        {
            HashSHA hash = new HashSHA();
            Byte[] text = Encoding.UTF8.GetBytes("");
            
            Console.WriteLine("Que vols fer?");
            Console.WriteLine("1. Crear hash");
            Console.WriteLine("2. Verificar hash");
            Console.WriteLine("3. Sortir");

            int menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    try
                    {
                        text = File.ReadAllBytes("hola.txt");
                        ReadDocument(text);
                        Console.WriteLine(hash.CreateHash(text));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error al llegri l'arxiu " + e.Message);
                    }


                case 2:
                    
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opció incorrecta");
                    break;
            }

            

            


            void ReadDocument(Byte[] text)
            {
                Console.WriteLine(Encoding.UTF8.GetString(text));
                
            }

            
        }
    }
}
