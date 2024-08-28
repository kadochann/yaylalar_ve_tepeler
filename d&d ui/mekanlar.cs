using System;

namespace Mekanlar
{
    class dagKoyu
    {
        public string hikaye1 = @"
Kahramanımız Köylü Çocuk ile Tanışın:

Sıradan bir Anadolu köyünde, dağların eteklerinde saklı küçük bir yerleşim yerinde, 10 yaşlarında cesur bir çocuktur. 
Annesi, evin işlerini idame ettiren güçlü bir kadındır, ancak kahramanımız da elinden geldiğince ona yardımcı olur. 
Babası, savaş için çağrıldığından beri, köydeki diğer yaşıtları gibi o da ailesine destek olmak için sorumluluklar üstlenmiştir.

Bir gün, annesi beklenmedik bir şekilde hastalanır. Köyün şifacısına danıştıklarında, şifacı nine hastalığın ciddiyetini anlar 
ve özel bir ilaca ihtiyaç olduğunu söyler. Ancak bu ilaç ne köyde ne de yakın çevrede bulunabilir. 
Şifacı, kahramanımıza anakaraya gitmesini, oradaki güvenilir bir dostuna bu notu iletmesini ve ilacı almasını tembih eder.

Böylece, köylü çocuğumuz için zorlu bir yolculuk başlar. Anakaraya giden yol uzun ve tehlikelidir. 

Köyün sonuna yaklaştığında, ahırların ve evlerin azalmasıyla artık güvenli bölgenin dışına çıkmak üzere olduğunu fark eder. 
Dağların eteklerinde kurulu köy, düşman saldırılarına ve vahşi hayvanların istilasına karşı oldukça savunmasızdır. 
Köy sınırında nöbet tutan korucular, bu tehlikelere karşı sürekli tetikte olmak zorundadırlar.

Korucuyla karşılaştığında, korucu ona artık güvenli sınırı aştığını ve tehlikelere karşı artık tek başına olduğunu söyler. 
Cesur köylü çocuk, yoluna devam eder. Bir süre sonra, ormanın derinliklerinde bir eşkıya aniden yolunu keser.

Kahramanımızın elinde sadece taş ve sopa vardır; ancak içinde büyük bir cesaret barındırmaktadır. 
Şimdi, karşısındaki düşmana karşı koymak ve yolculuğunu sürdürmek zorundadır.
";
        public string saldırı = "Saldırmak için birini seç:\n1-Taş (+2 hasar, +2 savunma) \n2-Sopa(+3 hasar, +1 savunma)";
        public string kazanma = "\t \t \t _____________tebrikler!!!___________________";

        public string hikaye2= @"
eşkıyayı yendin. yoluna devam etmeden önce arkadan bir ses duyulur. çalıların arasından  elinde sopası sırtında abasıyla bir çoban çıkageliyor. bu tehlikeli yerlerde ne yaptığını sorar.
hikayeni anlattığında sana yolunun bir kısmında eşlik edebileceğini ve tehlikelere karşı seni koruyabileceğini söyler.
kabul edersin ve yola birlikte devam edilir.



Yeni karakter: Çoban (yaylaların yalnız koruyucusu)
Saldırı: Sürünün Hücumu - Koyunlar ve keçiler düşmana hücum eder.
İyileştirme: Kavalın Büyüsü - Kaval çalarak arkadaşlarının moralini yükseltir ve hafif yaraları iyileştirir.

Enerj:15 Saldırı:+5 Savunma:+3 İyileşme: 3
";
    }//endof dagkoyu
    class kervanSaray
    {
        public string hikaye = "dfafa";
        public string saldırı = "saldırmak icin birini seç: \n1-taş(+2 hasar, +2 savunma) \n2-Sopa(+3 hasar, +1 savunma) \n3-ç3-çobanın sürüsünün hücümu(+5 hasar, +3 savunma)  \n4-demirci ustanın erimiş demiri";
        public string kazanma = "\t\t\tkazandın";
        public string esya = "eşya kullanmak istiyorsan I tuşuna bas";
    }//endof kervansaray
    class torosDagları
    {
        public string hikaye = "toroslara gelindi cartcurt";
        public string saldırı = "saldırmak icin birini seç:\n1-taş(+2 hasar, +2 savunma) \n2-Sopa(+3 hasar, +1 savunma) \n3-çobanın sürüsünün hücümu(+5 hasar, +3 savunma)";
        public string kazanma = "\t\t\tskazandın";
        public string esya = "eşya kullanmak istiyorsan I tuşuna bas";
    }//endof toroslar
}
