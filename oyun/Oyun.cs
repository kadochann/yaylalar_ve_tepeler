using System;
using charClasses;
using Kahramanlar;
using Dusmanlar;
using Mekanlar;
using Items;
using System.Globalization;


namespace program
{
    public class GameEngine
    {
        public void StartGame()
        {
            dagKoyu dagKoyu = new dagKoyu();
            Koylu koylu = new Koylu();
            Eskıya eskiya = new Eskıya();
            Console.WriteLine("Yaylalar ve Tepeler oyununa hoşgeldin  \nköylü çocukla macera başlayabilirsin.");
            Console.WriteLine(dagKoyu.hikaye1);
            while (eskiya.energy != 0)
            {
                Console.WriteLine(dagKoyu.saldırı);
                string? secim = Console.ReadLine();

                if (secim == "1")
                {
                    koylu.Attack1(eskiya.defenseValue);
                    eskiya.Defense(koylu.attackValue);
                    eskiya.Saldır(koylu.defenseValue, "bıçak");
                }

                else if (secim == "2")
                {
                    koylu.Attack2(eskiya.defenseValue);
                    eskiya.Defense(koylu.attackValue);
                    eskiya.Saldır(koylu.defenseValue, "bıçak");
                }
                else
                {
                    Console.WriteLine("lütfen geçerli bir seçenek girin:");
                }


            }
            Console.WriteLine("eşkıyadan bir eşya düştü! onu çantaya koydun. \n "); //ilk bölüm sonu
            Hancer hancer = new Hancer();
            Coban coban = new Coban();

            hancer.Use(koylu);
            Console.WriteLine(dagKoyu.kazanma);
            Console.WriteLine(dagKoyu.hikaye2);

            torosDagları toros = new torosDagları();
            Console.WriteLine(toros.hikaye);
            Cadı cadı = new Cadı();
            while (cadı.energy > 0)
            {
                Console.WriteLine(toros.saldırı);
                string? secim2 = Console.ReadLine();
                Console.WriteLine(toros.esya);
                koylu.Envanter(hancer);
                string? opt = Console.ReadLine();

                if (secim2 == "1")
                {
                    if (opt == "I")
                    {
                        koylu.UseItem(hancer);
                    }
                    koylu.Attack1(cadı.defenseValue);
                    cadı.Defense(koylu.attackValue);

                }
                else if (secim2 == "2")
                {
                    if (opt == "I")
                    {
                        koylu.UseItem(hancer);
                    }
                    koylu.Attack2(cadı.defenseValue);
                    cadı.Defense(koylu.attackValue);

                }
                else if (secim2 == "3")
                {
                    if (opt == "I")
                    {
                        coban.UseItem(hancer);
                    }
                    coban.Attack1(cadı.defenseValue);
                    cadı.Defense(coban.attackValue);

                }
                else
                {
                    Console.WriteLine("lütfen geçerli bir seçenek yaz:");
                }
                if (coban.energy > 0)
                {
                    cadı.Attack1(coban.defenseValue);
                    coban.Defense(cadı.attackValue);
                }
                else if (koylu.energy > 0)
                {
                    cadı.Attack1(koylu.defenseValue);
                    koylu.Defense(cadı.attackValue);
                }
                else
                {
                    Console.WriteLine("kaybettin");
                }
            }//cadıyı yenme turu (while dongüsü sonu)
        }//main sonu
    }
}
