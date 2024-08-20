using System;
using charClasses;
using Kahramanlar;
using Dusmanlar;
using Mekanlar;
using System.Globalization;


namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Mekanlar.dagKoyu);
            Console.WriteLine("Yaylalar oyununa hoşgeldin \nhikaye cartcurt \nköylü çocukla macera başlayabilirsin.");
            Console.WriteLine();
            Koylu koylu= new Koylu();
            Eskıya eskiya= new Eskıya();

            koylu.Attack(eskiya.defenseValue);
            eskiya.Heal();
            eskiya.Attack(koylu.defenseValue);

            koylu.Heal();


            

        }
    }
}