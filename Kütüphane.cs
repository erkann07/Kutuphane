class Kitap
{
    //Proprrtyler
    public string Ad { get; set; }
    public string YazarAd { get; set; }
    public string YazarSoyad { get; set; }
    public int Sayfa { get; set; }
    public string YayinEvi { get; set; }
    public DateTime KayitZamani { get; set; }
    //Kayıt zamanı ayarlayan metot
    private void ZamanAyarla()
    {
        KayitZamani = DateTime.Now;
    }
    //Default constructor
    public Kitap()
    {
     ZamanAyarla();
    }
    //Parametreli constructor
    public Kitap(string ad, string yazarAd, int sayfaSayisi, string yayinevi)
    {
        Ad = ad;
        YazarAd = yazarAd;
        Sayfa = sayfaSayisi;
        YayinEvi = yayinevi;
        ZamanAyarla();
    }
    //Kitap bilgilerini yazdıran metot
    public void BilgileriYazdir()
    {
        ZamanAyarla();
        Console.WriteLine($"Kitap Adı: {Ad}");
        Console.WriteLine($"Yazar Adı: {YazarAd}");
        Console.WriteLine($"Yazar Soyadı: {YazarSoyad}");
        Console.WriteLine($"Sayfa Sayısı: {Sayfa}");
        Console.WriteLine($"Yayın Evi: {YayinEvi}");
        Console.WriteLine($"Kayıt Zamanı: {KayitZamani}");
    }

}
class Program
{
    static void Main(string[] args)
    {
        //Kitap nesnesi oluşturma
        Kitap kitap1 = new Kitap("Bir Kitap", "Ahmet", 320, "Alfa Yayınları");
        kitap1.YazarSoyad = "Yılmaz";
        //Kitap bilgilerini yazdırma
        kitap1.BilgileriYazdir();
        Console.WriteLine("-----------------------------------------");
        //Parametreli constructor ile kitap nesnesi oluşturma
        Kitap kitap2 = new Kitap("Başka Bir Kitap", "Ayşe", 215, "Beta Yayınları");
        kitap2.YazarSoyad = "Karan";
        kitap2.BilgileriYazdir();
        Kitap kitap3 = new Kitap();
        Console.WriteLine("-----------------------------------------");
        kitap3.Ad = "Daha Başka Kitap";
        kitap3.YazarAd = "Mehmet";
        kitap3.YazarSoyad = "Demir";
        kitap3.Sayfa = 450;
        kitap3.YayinEvi = "Gamma Yayınları";
        kitap3.BilgileriYazdir();
        Console.WriteLine("-----------------------------------------");
        Kitap kitap4 = new Kitap("Son Kitap", "Elif", 275, "Delta Yayınları");
        kitap4.YazarSoyad = "Şahin";
        kitap4.BilgileriYazdir();
        Console.WriteLine("-----------------------------------------");
        Kitap kitap5 = new Kitap("Örnek Kitap", "Selin", 198, "Epsilon Yayınları");
        kitap5.YazarSoyad = "Yurt";
        kitap5.BilgileriYazdir();
    }
}