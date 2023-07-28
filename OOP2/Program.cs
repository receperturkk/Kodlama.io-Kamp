namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Recep Kadir Ertürk
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Recep Kadir";
            musteri1.Soyadi = "Ertürk";
            musteri1.TcNo = "1234578910";

            //Shadow Store
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Shadow Store";
            musteri2.VergiNo = "1234567890";

            //miras(inheratance):ortak bir class oluştururken ortak değerleri tek bir classtan miras almak.
            //ortak özellikler olan class ebevyndir.
            //Musteri sınıfı ebeveyn olduğu için ikisinide referans alabiliyor.

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

        }
    }
}