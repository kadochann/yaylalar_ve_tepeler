using charClasses;
using System;
using Items;

namespace Kahramanlar
{
    public class Koylu : Karakterler
    {
        public Koylu(): base ("köylü çocuk", 3, 3, 2, 10) { }
      // koylu constructor
        public void UseItem(Itemler itemler) { 
            itemler.Use(this);
            itemList.Add(itemler);
        }

        public void Attack1(int gelenDefense)//taş
        {
            Saldır(defenseValue, "taş");

        }//attack override
        public void Attack2(int gelenDefense)//sopa
        {
            Saldır(defenseValue, "sopa");
            }

            //}//attack override

            //public override void Defense(int gelenSaldırı)
            //{
            //    base.Defense(gelenSaldırı);
            //    if (gelenSaldırı < defenseValue)
            //    {
            //        Console.WriteLine("\nköylü çocuk gelen atağı geri püskürttü!");
            //    }
            //    else
            //    {
            //        int zarar = gelenSaldırı - defenseValue;
            //        Console.WriteLine($"\nköylü çocuğun savunması yetersiz!\nalınan hasar: {zarar}");
            //        Energy(zarar);
            //    }
            //}//defense override

            //public override void Heal()
            //{
            //    base.Heal();
            //    Console.WriteLine("köylü çocuk topladığı otları kullanarak iyileşti");
            //    Console.WriteLine($"enerji: {energy}");
            //}//heal override

        }//endof koylu
   
    

}
