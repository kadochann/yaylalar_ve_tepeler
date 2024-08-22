using charClasses;
using System;

namespace Dusmanlar
{
    public class Eskıya:Karakterler 
    {
        public Eskıya() : base("eşkıya", 2, 1, 1, 10)
        {
        }
        public override void Energy(int hasar)
        {
            base.Energy(hasar);
        }
        public override void Heal()
        {
            base.Heal();
        }
        public override void Defense(int gelenSaldırı)
        {
            base.Defense(gelenSaldırı);
        }
    }//endof eskıya
}

