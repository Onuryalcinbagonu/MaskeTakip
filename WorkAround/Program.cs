

using Business.Concrete;
using Entities.Concrete;

SelamVer("Ali");
SelamVer("Veli");
SelamVer("Ayşe");
SelamVer();

int sonuc = Topla(76, 5);

//Diziler / Arrays
string ogrenci1 = "Engin";
string ogrenci2 = "Ali";
string ogrenci3 = "Veli";

Console.WriteLine(ogrenci1);
Console.WriteLine(ogrenci2);
Console.WriteLine(ogrenci3);

string[] ogreciler = new string[3];
ogreciler[0] = "Engin";
ogreciler[1] = "Ali";
ogreciler[2] = "Veli";

for (int i = 0; i < ogreciler.Length; i++)
{
    Console.WriteLine(ogreciler[i]);
}

string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

sehirler2 = sehirler1;
sehirler1[0] = "Adana";
Console.WriteLine(sehirler2[0]);

Person person1=new Person(); 
person1.FirstName = "ALİ";
person1.LastName = "VELİ";
person1.DateOfBirthYear = 2000;
person1.NationalIdentity = 123;


Person person2 = new Person();
person2.FirstName = "Murat";

foreach (string sehir in sehirler1)
{
    Console.WriteLine(sehir);
}

List<string> yeniSehirler1=new List<string> { "Ankara 1","İstanbul 1","İzmir 1"};
yeniSehirler1.Add("Burdur 1");

foreach (var sehir in yeniSehirler1)
{
    Console.WriteLine(sehir);
}



PttManager pttManager=new PttManager(new PersonManager());
pttManager.GiveMask(person1);

//resharper
static void SelamVer(string isim = "Kullanıcı")
{
    Console.WriteLine("Merhaba " + isim);
}

static int Topla(int sayi1, int sayi2 = 10)
{
    int sonuc = sayi2 + sayi1;
    Console.WriteLine("Toplam : " + sonuc);
    return sonuc;
}



static void Degiskenler()
{
    string mesaj = "Merhaba";
    double tutar = 100000; //db den gelir
    int sayi = 100;
    bool girisYapmisMi = false;

    string ad = "Engin";
    string soyad = "Demiroğ";
    int dogumYili = 1985;
    long tcNo = 12345678910;


    Console.WriteLine(tutar * 1.18);

}
public class Vatandas
{
    // class ların default erişim belirleyicisi internal'dır.
    // değişkenler default erişim belirleyicisi private'dır.
    // public değişkenlerin adlandırmasının ilk harfi büyük olur
    public string Ad { get; set; }
    //okuma ve yazma - get ve set
    public string Soyad { get; set; }
    public int DogumYili { get; set; }
    public long TcNo { get; set; }

}