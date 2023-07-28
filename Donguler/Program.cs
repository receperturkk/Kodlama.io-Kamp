
namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";
            string kurs5 = "C++";
            
            Console.WriteLine("Tek tek yazdırma");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);
            Console.WriteLine("----------------------------------------------");

            //array - dizi
            string[] kurslar = new string[] {   "Yazılım Geliştirici Yetiştirme Kampı",
                                                "Programlamaya Başlangıç İçin Temel Kurs",
                                                "Java", "Python", "C++"};

            Console.WriteLine("Dizinin içinden for dögüsü ile yazdırma");
            Console.WriteLine("----------------------------------------------");
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("----------------------------------------------");

            Console.WriteLine("Dizinin içinden foreach dögüsü ile yazdırma");
            Console.WriteLine("----------------------------------------------");
            foreach (string kurs in kurslar) //verilen dizi içerisinde dolaşır.
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Sayfa sonu - footer");
        }
    }
}