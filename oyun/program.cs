using System;
using charClasses;
using Kahramanlar;
using Dusmanlar;
using Mekanlar;
using Items;
using System.Globalization;


namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            dagKoyu dagKoyu = new dagKoyu();
            Koylu koylu = new Koylu();
            Eskıya eskiya = new Eskıya();
            Console.WriteLine("Yaylalar ve Tepeler oyununa hoşgeldin  \nköylü çocukla macera başlayabilirsin.");
            //Console.WriteLine(dagKoyu.hikaye1);
            while (eskiya.energy != 0)
            {
                Console.WriteLine(dagKoyu.saldırı);
                string? secim = Console.ReadLine();

                if (secim == "1")
                {
                    koylu.Attack1(eskiya.defenseValue);
                    eskiya.Defense(koylu.attackValue);
                    eskiya.Heal();
                    eskiya.Saldır(koylu.defenseValue, "bıçak");
                    koylu.Heal();
                }

                else if (secim == "2")
                {
                    koylu.Attack2(eskiya.defenseValue);
                    eskiya.Defense(koylu.attackValue);
                    eskiya.Heal();
                    eskiya.Saldır(koylu.defenseValue,"bıçak");
                    koylu.Heal();
                }
                else
                {
                    Console.WriteLine("lütfen geçerli bir seçenek girin:");
                }
                

            }
                Console.WriteLine("eşkıyadan bir eşya düştü! onu çantaya koydun. \n ");
                
                Hancer hancer = new Hancer();
                hancer.Use(koylu);
                Console.WriteLine(dagKoyu.kazanma);    



                //koylu.Heal();
            
        }
    }
}