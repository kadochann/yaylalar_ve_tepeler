using charClasses;
using System;
using Items;

namespace Kahramanlar
{
    public class Koylu : Karakterler
    {
        public Koylu()
        {
            this.attackValue = 2;
            this.defenseValue = 2;
            this.healValue = 2;
            energy = 10;
        }// koylu constructor

        public override void Attack1(int gelenDefense)
        {
            Console.WriteLine("köylü çocuk taş ile saldırdı!");
            base.Attack1(gelenDefense);
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
        public override void Attack2(int gelenDefense)
        {
            Console.WriteLine("Köylü çocuk sopa ile saldırdı!");
            base.Attack1(gelenDefense);
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
        //public void useItem(Itemler items)
        //{
            
        //    items.Use();

        //}

    }//endof koylu
}
