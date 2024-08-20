using System;
using Dusmanlar;
using Kahramanlar;

namespace Items
{
    public class Itemler: Karakterler
    {
        public string? Name { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Heal { get; set; }

        public virtual void Use(Karakterler karakterler)
        {

            Console.WriteLine($"{itemler.Name} itemı kullanıldı!");
            Console.WriteLine($"itemın gücü:\nsaldırı: +{itemler.Attack}\nsavunma: +{itemler.Defense}\niyileşme: +{itemler.Heal}");
            karakterler.attackValue += Attack;
            karakterler.defenseValue += Defense;
            karakterler.healValue += Heal;
        }
    }
    public class Hancer: Itemler
    {
        string name => "Efsunlu Hançer";
        public int attack => 3;
        public int defense => 2;
        public int heal => 1;

        public override void Use(Karakterler karakterler)
        {
            Itemler itemler = new Hancer();

            base.Use(karakterler);
        }
    }
    public class Kusak : Itemler
    {
        string name => "Şifalı Kuşak";
        int attack => 0;
        int defense => 1;
        int heal => 5;

    }
    public class Tabanca : Itemler
    {
        string name => "Babadan yadigar beylik tabanca";
        int attack => 6;
        int defense => 0;
        int heal => 0;
    }
    public class Yuzuk : Itemler
    {
        string name => "Gümüş Sedefli Yüzük";
        int attack => 3;
        int defense => 5;
        int heal => 2;
    }
    public class Kolye : Itemler
    {
        string name => "Nazarlık kolye";
        int attack => 1;
        int heal => 5;
        int defense => 6;
    }
    public class Sopa : Itemler
    {
        string name => "Çobanın sopası";
        int attack => 5;
        int defense => 4; 
        int heal => 0;
    }
}
    
