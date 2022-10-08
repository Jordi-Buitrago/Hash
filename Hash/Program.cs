using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Runtime.CompilerServices;

namespace Hash
{

    class Program
    {
        static void Main(string[] args)
        {
            Encripta encripta = new Encripta();
            Byte[] text = Encoding.UTF8.GetBytes("");
            try
            {
                text = File.ReadAllBytes("hola.txt");
                ReadDocument(text);
            }
            catch 
            {
                Console.WriteLine("Error al llegir el document");
            }
            
            Console.ReadKey();
            encripta.CreateHash(text);
            


            void ReadDocument(Byte[] text)
            {
                Console.WriteLine(Encoding.UTF8.GetString(text));
                Console.ReadKey();
            }
        }
    }
}
