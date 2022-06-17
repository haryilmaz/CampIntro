using System;
using System.Collections.Generic;

namespace donguler
{
    class Program
    {
        private static int length;

        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("merhaba dünya");
            }
            for (int i = 0; i < 10; i = i + 2)
            {
                Console.WriteLine("nasılsın dünya sana bunu kaç defa sordum?");
            }
            string kurs1 = "java öğrenmek güzel";
            string kurs2 = "python öğrenmek basit";
            string kurs3 = "c# bu dilin babası :)";

            string[] kurslar = new string[] { "python", "java", "c#" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            List<string> kurslar1 = new List<string>();
            for (int i = 0; i < kurslar.Length; i++)
            {
                kurslar1.Add(kurslar[i]);

            }
            /***Console.WriteLine(kurslar1);
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar1[i]);
            }***/
            foreach (string kurs in kurslar1)
            {
                Console.WriteLine(kurs);
            }
        }


    }
}
