/* Kadriye HARMANCI, 19.08.2024
 * elde edilen itemlerın listesi string array olarak saklanabilir
 * item kullan fonksiyonu arg olarak item obj alır ve bulunduğu sınıfın özelliklerine item objesinin özelliklerini ekleyerek kullanmış olabilir.
 * her bir item icin tek tek fonk çağrılması gerekir, çok fazla item elde edildiğinde bu işlem maliyetli olabilir.
 */
using Items;
using System;

namespace charClasses
{
    public abstract class Karakterler : Itemler
    {
        public int attackValue;
        public int defenseValue;
        public int healValue;
        public List<Itemler> itemList = new List<Itemler>();
        public int energy;
        public string? charName;

        public Karakterler(string name, int attack, int defense, int heal, int energy)
        {
            this.charName = name;
            this.attackValue = attack;
            this.defenseValue = defense;
            this.healValue = heal;
            this.energy = energy;
        }//karakterler constructor
        public virtual void Saldır(int gelenDefense, string silah) {
            Console.WriteLine($"{charName} {silah} ile saldırdı");
            if (this.attackValue >= gelenDefense)
            {
                Console.WriteLine($"{charName} saldırısında başarılı!");
            }
            else
            {
                Console.WriteLine($"{charName} saldırısında başarısız");
            }
        }
        public virtual void Defense(int gelenSaldırı)
        {
            if (gelenSaldırı <= defenseValue)
            {
                Console.WriteLine($"\n{charName} savunmada başarılı");
            }
            else
            {
                Console.WriteLine($"\n{charName} savunmada başarısız. enerjisi azaldı.\n");
                int hasar= gelenSaldırı-defenseValue;
                this.Energy(hasar);
                this.Heal();
            }
        }

        public virtual void Heal()
        {
            energy += healValue;
            Console.WriteLine($"{charName} {healValue} kadar iyileşme sağladı\nenerji:{energy}");
        }

        public virtual void Energy(int hasar)
        {
            energy -= hasar;
            Console.WriteLine($"{charName} hasar aldı! enerji: {energy}");
        }
        public void UseItem(Itemler itemler)
        {
            
            itemler.Use(this);
            itemList.Remove(itemler);
            
        }
        public virtual void Envanter(Itemler item)
        {
            itemList.Add(item);
            Console.WriteLine("\nenvanterindekiler:");
            foreach (Itemler itemler in itemList)
            {
                Console.WriteLine(itemler.Name);
            }
            //public  over
        }
    }
}


