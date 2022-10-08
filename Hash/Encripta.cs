using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel;

namespace Hash
{
    class Encripta
    {
        public void CreateHash (Byte[] text)
        {

            // Convertim l'string a un array de bytes
            byte[] bytesIn = text;
            // Instanciar classe per fer hash
            SHA512Managed SHA512 = new SHA512Managed();
            // Calcular hash
            byte[] hashResult = SHA512.ComputeHash(text);
            // Si volem mostrar el hash per pantalla o guardar-lo en un arxiu de text
            // cal convertir-lo a un string
            String textOut = BitConverter.ToString(hashResult, 0);
            Console.WriteLine("Hash {0}", textOut);
            Console.ReadKey();
            // Eliminem la classe instanciada
            SHA512.Dispose();
            File.WriteAllBytes("hola.hash", hashResult);
        }   
    }
}
