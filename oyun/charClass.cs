/* Kadriye HARMANCI, 19.08.2024
 * elde edilen itemlerın listesi string array olarak saklanabilir
 * item kullan fonksiyonu arg olarak item obj alır ve bulunduğu sınıfın özelliklerine item objesinin özelliklerini ekleyerek kullanmış olabilir.
 * her bir item icin tek tek fonk çağrılması gerekir, çok fazla item elde edildiğinde bu işlem maliyetli olabilir.
 */
using Items;
using System;

namespace charClasses
{
    public abstract class Karakterler:Itemler
    {
        public int attackValue;
        public int defenseValue;
        public int healValue;
        public List<Itemler> item= new List<Itemler>();
        public int energy;
        public virtual void Attack1(int gelenDefense)
        {
            if (attackValue > gelenDefense)
            {
                Console.WriteLine("saldırı başarılı!");
            }
            else
            {
                Console.WriteLine("saldırı başarısız");
            }

        }
        public virtual void Attack2(int gelenDefense)
        {
            if (attackValue > gelenDefense)
            {
                Console.WriteLine("saldırı başarılı!");
            }
            else
            {
                Console.WriteLine("saldırı başarısız");
            }

        }

        public virtual void Defense(int gelenSaldırı)
        {
            Console.WriteLine("SAVUNMA");
            if (gelenSaldırı < defenseValue)
            {
                Console.WriteLine("savunma başarılı");
            }
            else
            {
                Console.WriteLine("savunma başarısız. enerji azaldı.");
            }
        }

        public virtual void Heal()
        {
            energy += healValue;
            Console.WriteLine($"iyileşme sağlandı\nenerji:{energy}");
        }

        public virtual void Energy(int hasar)
        {
            energy-=hasar;
        }
        public  over
    }
}


