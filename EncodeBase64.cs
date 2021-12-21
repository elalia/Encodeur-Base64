using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodeurBase64
{
    public class EncodeBase64
    {
        private readonly static string[] tab = {"A","B","C","D","E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z",
                             "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z",
                             "0","1","2","3","4","5","6","7","8","9","+","/"};        
        
        public static string Encode(byte[] source)
        {
            if (!(source.Length % 3 == 0))
            {
                throw new Exception("Le tableau doit avoir une longueur qui sera un multiple de 3 afin de simplifier le test.");
            }

            StringBuilder stringOfBits = new StringBuilder();
 
            foreach (var bit in source)
            {
                var nbrbit = Convert.ToString(bit, 2).Length;
                while (nbrbit < 8)
                {
                    stringOfBits.Append('0');
                    nbrbit++;
                }
                stringOfBits.Append(Convert.ToString(bit, 2));
            }
           

            StringBuilder result = new StringBuilder();
            string VBG;
            while(stringOfBits.Length>0)
            {
                VBG = stringOfBits.ToString().Substring(0, 6);
                int B = Convert.ToInt32(VBG, 2);
                result.Append(tab[B]);
                stringOfBits = stringOfBits.Remove(0, 6);
            }
           
            return result.ToString();
        }
    }
}
