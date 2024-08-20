using charClasses;
using System;

namespace Kahramanlar
{
    public class Koylu : Karakterler
    {
        public Koylu()
        {
            this.attackValue = 2;
            this.defenseValue = 2;
            this.healValue = 2;
            this.item = false;
            energy = 10;
        }// koylu constructor

        public override void Attack(int gelenDefense)
        {
            base.Attack(gelenDefense);
            if (gelenDefense < attackValue)
            {
                int zarar = attackValue - gelenDefense;
                Console.WriteLine($"köylü çocuğun atağı başarılı!!\ndüşmanın savunmasına rağmen aldığı hasar: {zarar}");
                Energy(zarar);
            }
            else
            {
                Console.WriteLine("köylü çocuk saldırdı ancak düşman savunmasıyla hasarı savuşturdu!");
            }

        }//attack override
        
        public override void Defense(int gelenSaldırı)
        {
            base.Defense(gelenSaldırı);
            if (gelenSaldırı < defenseValue)
            {
                Console.WriteLine("\nköylü çocuk gelen atağı geri püskürttü!");
            }
            else
            {
                int zarar = gelenSaldırı - defenseValue;
                Console.WriteLine($"\nköylü çocuğun savunması yetersiz!\nalınan hasar: {zarar}");
                Energy(zarar);
            }
        }//defense override

        public override void Heal()
        {
            base.Heal();
            Console.WriteLine("köylü çocuk topladığı otları kullanarak iyileşti");
            Console.WriteLine($"enerji: {energy}");
        }//heal override

    }//endof koylu
}
