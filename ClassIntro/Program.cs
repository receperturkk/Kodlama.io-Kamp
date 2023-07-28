using System.Security.Cryptography;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Recep";
            int yas = 20;

            Kurs kurs1 = new Kurs();
            kurs1.kursAdi = "C#";
            kurs1.egitmen = "Engin Demiroğ";
            kurs1.izlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.kursAdi = "Java";
            kurs2.egitmen = "Kerem Varış";
            kurs2.izlenmeOrani = 58;
            
            Kurs kurs3 = new Kurs();
            kurs3.kursAdi = "Python";
            kurs3.egitmen = "Recep Kadir Ertürk";
            kurs3.izlenmeOrani = 80;

            //Console.WriteLine(kurs1.kursAdi + " : " + kurs1.egitmen); //tek tek yazdırma

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 }; //dizi oluşturup for each ile yazdırma

            foreach (var kurs in kurslar)
            {
                Console.WriteLine("Kurs Adı: " + kurs.kursAdi);
                Console.WriteLine("Eğitmen: " + kurs.egitmen);
                Console.WriteLine("İzlenme Oranı: %" + kurs.izlenmeOrani);
                Console.WriteLine("-------------------------------------");
                    
            }
        }   

        class Kurs
        {
            public string kursAdi { get; set; }
            public string egitmen { get; set; }
            public int izlenmeOrani { get; set; }
        }
    }
}