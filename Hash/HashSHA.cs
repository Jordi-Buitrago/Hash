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
    class HashSHA
    {

        public String CreateHash (Byte[] text)
        {
            try
            {
                text = File.ReadAllBytes("hola.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al llegri l'arxiu " + e.Message);
            }
            // Convertim l'string a un array de bytes
            byte[] bytesIn = text;
            // Instanciar classe per fer hash
            SHA512Managed SHA512 = new SHA512Managed();
            // Calcular hash
            byte[] hashResult = SHA512.ComputeHash(text);
            // Si volem mostrar el hash per pantalla o guardar-lo en un arxiu de text
            // cal convertir-lo a un string
            String textOut = BitConverter.ToString(hashResult, 0);
            
            File.WriteAllBytes("hola.sha", hashResult);

            Console.WriteLine("Hash creat correctament", textOut);


            return textOut;
        }
        
        public String HashVerify(Byte[] text, Byte[] hash)
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
            String textOut2 = BitConverter.ToString(hash, 0);

            if (textOut == textOut2)
            {
                Console.WriteLine("Hash verificat correctament", textOut);
            }
            else
            {
                Console.WriteLine("Hash no verificat", textOut);
            }

            return textOut;
        }
    } 
}
