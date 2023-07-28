namespace Kamp
{
	class Program
	{
		static void Main(string[] args)
		{
			// type safety - tip güvenliğiğ
			string kategoriEtiketi = "Kategoriler";
			int ogrenciSayisi = 32000;
			double faizOrani = 1.45;
			bool sistemeGirisYapmismi = true;
			double dolarDun = 7.35;
			double dolarBugun = 7.45;

			if (dolarDun>dolarBugun)
			{
				Console.WriteLine("Azalış Butonu");
			}
			else if (dolarDun<dolarBugun)
			{
				Console.WriteLine("Artış butonu");
			}
			else
			{
				Console.WriteLine("Değişmedi butonu");
			}
			

			if (sistemeGirisYapmismi == true) 
			{
				Console.WriteLine("Kullanıcı ayarları butonu");
			}
			else
			{
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
		}
	}
}  