using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodeurBase64
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] tt = { 0x33, 0xA6, 0xFF};
            bool compar;
            var base64 = EncodeBase64.Encode(tt);
            if (base64 == Convert.ToBase64String(tt))
                compar = true;
            else
                compar = false;
            var result = compar;           
        }        
    }
}
    


