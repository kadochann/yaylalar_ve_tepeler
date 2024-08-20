using charClasses;
using System;

namespace Dusmanlar
{
    public class Eskıya:Karakterler
    {
        public Eskıya()
        {
            this.attackValue = 2;
            this.defenseValue = 1;
            this.healValue = 1;
            energy = 10;
        }
        public override void Heal()
        {
            base.Heal();
            Console.WriteLine($"eşkıya{healValue} kadar kendini iyileştirdi");
        }
        public override void Defense(int gelenSaldırı)
        {
            if (gelenSaldırı < defenseValue)
            {
                Console.WriteLine($"\neşkıya kendine gelen atağı +{defenseValue} gücüyle savundu!");
            }
            else
            {
                int zarar = gelenSaldırı - defenseValue;
                Console.WriteLine($"\neşkıya kendini savunamadı!\nalınan hasar: {zarar}");
                Energy(zarar);
            }
        }
    }//endof eskıya
}

