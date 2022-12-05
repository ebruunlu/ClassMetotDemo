namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Musteri musteri1= new Musteri();
            musteri1.Adi = "Ömer Faruk";
            musteri1.Soyadi = "Geriş";
            musteri1.Tckn= "38763567999";

            Musteri musteri2= new Musteri();
            musteri2.Adi = "Ebru";
            musteri2.Soyadi = "Geriş";
            musteri2.Tckn = "387867555";

            MusteriManager yonetim= new MusteriManager();
            yonetim.Ekle(musteri1);
            yonetim.Ekle(musteri2);

            yonetim.Listele(musteri1);
            yonetim.Listele(musteri2);

            yonetim.Sil(musteri1);
            yonetim.Sil(musteri2);

        }

    }
}