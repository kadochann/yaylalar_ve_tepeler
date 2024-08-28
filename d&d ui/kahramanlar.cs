using charClasses;
using System;
using Items;

namespace Kahramanlar
{
    public class Koylu : Karakterler
    {
        public Koylu(): base ("köylü çocuk", 3, 3, 2, 10) { }
      // koylu constructor
        //public void UseItem(Itemler itemler) { 
        //    itemler.Use(this);
        //    itemList.Add(itemler);
        //}

        public void Attack1(int gelenDefense)//taş
        {
            Koylu koylu = new Koylu();
            Saldır(defenseValue, "taş");
            koylu.attackValue = 2;
            koylu.defenseValue = 2;


        }//attack override
        public void Attack2(int gelenDefense)//sopa
        {
            Koylu koylu = new Koylu();
            Saldır(defenseValue, "sopa");
            koylu.attackValue = 3;
            koylu.defenseValue = 1;
            }
        }//endof koylu
    
    public class Coban: Karakterler
    {
        public Coban(): base ("Çoban", 5, 3, 3, 15) { }
        public void Attack1(int gelenDefense)
        {
            base.Saldır(gelenDefense, "sürünün hücumu");
        }
    }//endof çoban
    
    public class Demirci: Karakterler
    {
        public Demirci(): base("Demirci Ustası", 6, 7, 3, 18) { }
        public void Attack1(int gelenDefense)
        {
            base.Saldır(gelenDefense, "Erimiş Demir");
        }
    }
        
}
