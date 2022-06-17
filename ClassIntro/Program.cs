using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Kurs kurs1 = new Kurs();
            kurs1.KursAdı = "python";
            kurs1.Egitmen = "harun yılmaz";
            kurs1.İzlenmeOranı = 70;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdı = "c#";
            kurs2.Egitmen = "muhsin ayaz";
            kurs2.İzlenmeOranı = 35;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdı = "java";
            kurs3.Egitmen = "hüseyin akan";
            kurs3.İzlenmeOranı = 82;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdı = "c++";
            kurs4.Egitmen = "halil tongu";
            kurs4.İzlenmeOranı = 100;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdı + " : " + kurs.Egitmen);
            }

        }
    }

    class Kurs
    {
        public string KursAdı { get; set; }
        public string Egitmen { get; set; }
        public int İzlenmeOranı { get; set; }




    }
}
