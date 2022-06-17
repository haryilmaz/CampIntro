using System;

namespace program.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            bool SistemeGirişYapmışMı = true;

            if (SistemeGirişYapmışMı == true) 
            {
                Console.WriteLine("hoşgeldiniz harun bey :)");
            }
            else
            {
                Console.WriteLine("Sisteme giriş yapınız");
            }

            double DünDolar = 15.80;
            double BugunDolar = 18.12;
            if (DünDolar < BugunDolar)
            {
                Console.WriteLine("dolar artmış butonu");
            }

            else if (DünDolar > BugunDolar )
            {
                Console.WriteLine("dolar düştü butonu");
            }
            else
            {
                Console.WriteLine("değişiklik yok butonu");
            }


        }
    }
}
