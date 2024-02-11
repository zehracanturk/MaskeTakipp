
using Business.Concrete;
using Entities.Concrete;
using System;
using System.Transactions;

namespace Workaround
{ 
    class Program
    {
        static void Main(string[] args)
        {
            // Degiskenler();

            //Vatandas vatandas1 = new Vatandas();

            SelamVer(isim: " Engin");
            SelamVer(isim: " Ahmet");
            SelamVer(isim: " Ayşe");
            SelamVer();

            int sonuc = Topla(6,58);

            //Diziler / Arrays

            string ogrenci1 = "Engin";
            string ogrenci2 = "Kerem";
            string ogrenci3 = "Berkay";

            //Console.WriteLine(ogrenci1);
            //Console.WriteLine(ogrenci2);
            //Console.WriteLine(ogrenci3);

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";

            ogrenciler = new string[4]; // referans tipler; stack, heap, garbage collector, array,
            ogrenciler[3] = "İlker";    // class, abstract,interface

            for (int i =0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana"; // referans tipler (referans numarasını atarız.
            Console.WriteLine(sehirler2[0]);


            int sayi1 = 10;
            int sayi2 = 20;
            sayi2 = sayi1;
            sayi1 = 30;
            //sayi2=??? cevap 10 burası int, float, double, bool veri tipleri değer tiplerdir.  
            //deger tiplerde olay tamamen stack herşey ordadır ve herşey değer üzerinden girilir.

            // string aslında referans tiptir. Ama çalışma şekli değer tip gibi çalışır ama arka planda refarans tiptir.
            //string aslında bir char arraydir.


            Person person1 = new Person();
            person1.FirstName = "ENGİN";
            person1.LastName = "DEMİROĞ";
            person1.DateOfBirthYear = 1985;
            person1.NationalIdentity = 123;
           
            
            Person person2 = new Person();
            person2.FirstName = "Murat";



            foreach (string sehir in sehirler1) // sırayla dolaşıyor fakat her geçtiğine takma isim veriyor erişmek için.
            {
                Console.WriteLine(sehir); // her bir elamanı gezerken ona verdiğimiz takma isim.  
            }

            //MyList
            List<string> yeniSehirler1 = new List<string> { "Ankara 1 ", "İstanbul 1", "İzmir 1" };
            yeniSehirler1.Add(item: "Adana 1"); //burdaki add fonksiyonu 4 tane elamanımı koruyor. sıkıntı yok.
            //add:newledigimiz zaman önce gidiyor eski verileri cebe atıyor newledigimiz zaman yeniliyor
            // o cebe attıklarımızın yerine koyuyor, yeni elemanıda sonuna ekliyor.
            
            
            
            foreach(var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }


            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);



            //Generic Collections

            Console.ReadLine();
        }

        static void SelamVer(string isim ="isimsiz")
        {
            Console.WriteLine("Merhaba" + isim);
        }

        static int Topla(int sayi1=5, int sayi2=10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam :"+ sonuc.ToString());
            return sonuc;
        }
        
        
        private static void Degiskenler()
        {
            string mesaj = "Merhaba";
            double tutar = 100000;// db den gelir
            int sayi = 100;
            bool girisYapmisMi = false;

            string ad = "Engin";
            string soyad = "Demiroğ";
            int dogumYili = 1985;
            long tcNo = 12345678910;


            
            Console.WriteLine(tutar * 1.18);

            Console.WriteLine(tutar * 1.18);
        }
    }

    
  //pascal casing  
    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }
}


//interfaceler= belli method imzalarını barındırırlar bir birinin alternatifi
//olan sistemlerin farklı implementasyonlarını sağlarlar.yani yabancı uyrukluyu ben farklı check ederim
//onun kuralları farklıdır. Ama onu kontrol etmem lazım. yabancı uyruklu başvurabilir,listeleyebilirim aynı şey TC. vatandaşı içinde geçerli
//tek sınıfta yaparsam spagetti kod, yani çorba olur.

//Bir projede ne kadar çok if varsa yazılım geliştirme prensiplerinden o kadar uzak deriz.

//sonarqube=yazılım kalite ölçüm aracı.

//interfaceler newlenemez.
//interfaceler refarans tutucudurlar.


