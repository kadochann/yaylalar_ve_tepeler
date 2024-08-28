using System;
using Dusmanlar;
using charClasses;
namespace Items
{
    public abstract class Itemler
    {
        public string? Name { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Heal { get; set; }
        public virtual void Use(Karakterler karakter)
    {
            karakter.attackValue += this.Attack;
            karakter.defenseValue += this.Defense;
            karakter.healValue += this.Heal;

            Console.WriteLine($"{Name} itemı kullanıldı!");
            Console.WriteLine($"Itemın gücü: Saldırı: +{Attack}, Savunma: +{Defense}, İyileşme: +{Heal}");
        }
    }

    

    public class Hancer : Itemler
    {
        public Hancer()
        {
            Name = "Efsunlu Hançer";
            Attack = 3;
            Defense = 2;
            Heal = 1;
        }
    }

    public class Kusak : Itemler
    {
        string name = "Şifalı Kuşak";
        int attack = 0;
        int defense = 1;
        int heal = 5;

    }
    public class Tabanca : Itemler
    {
        public Tabanca()
        {
            Name = "Babadan yadigar beylik tabanca";
            Attack = 6;
            Defense = 0;
            Heal = 0;
        }
    }
    public class Yuzuk : Itemler
    {
        public Yuzuk()
        {
            Name = "Gümüş Sedefli Yüzük";
            Attack = 3;
            Defense = 5;
            Heal = 2;
        }
    }
    public class Kolye : Itemler
    {
        public Kolye()
        {
            Name = "Nazarlık kolye";
            Attack = 1;
            Defense = 5;
            Heal = 6;
        }
    }
    public class Sopa : Itemler
    {
        public Sopa()
        {
            Name = "Çobanın sopası";
            Attack = 5;
            Defense = 4;
            Heal = 3;
        }
    }

}
