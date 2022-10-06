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
           
            Byte [] text = File.ReadAllBytes("hola.txt");
            Console.WriteLine(Encoding.UTF8.GetString(text));
            Console.ReadKey();

            /*

            // Convertim l'string a un array de bytes
            //byte[] bytesIn = UTF8Encoding.UTF8.GetBytes(text);
            // Instanciar classe per fer hash
            SHA512Managed SHA512 = new SHA512Managed();
            // Calcular hash
            byte[] hashResult = SHA512.ComputeHash(bytesIn);
            // Si volem mostrar el hash per pantalla o guardar-lo en un arxiu de text
            // cal convertir-lo a un string
            String textOut = BitConverter.ToString(hashResult, 0);
            Console.WriteLine("Hash {0}", textOut);
            Console.ReadKey();
            // Eliminem la classe instanciada
            SHA512.Dispose();*/
        }
    }
}
