using System;
using System.Collections.Generic;
using System.Text;

namespace JurnalModul4_103082400034
{
    internal class KodeBuah
    {
        public static void getKodeBuah(string nama)
        {
            string[] kodeBuah = {"A00","B00","C00","D00","E00","F00","H00","I00","J00" };
            string[] namaBuah = { "Apel", "Aprikot", "Alpukat", "Pisang", "Paprika", "Blueberry", "Ceri","Kelapa", "Jagung"};
            for (int i = 0; i < kodeBuah.Length; i++)
            {
                if (nama.Equals(namaBuah[i]))
                {

                    Console.WriteLine("Nama Buah: " + namaBuah[i]);
                    Console.WriteLine("Kode Buah : " + kodeBuah[i]);

                }
                
            }

            
           
        }
            
    }
}
