using Hesaplama;
using static Hesaplama.Data;

//BirinciOrnegiUygula();
//IkinciOrnegiUygula();
UcuncuOrnegiUygula();

void BirinciOrnegiUygula()
{
    Data birinciOrnek = new Data();
    Console.WriteLine("1. Sayıyı Giriniz");
    int Sayi1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("2. Sayıyı Giriniz");
    int Sayi2 = Convert.ToInt32(Console.ReadLine());


    HesaplamaSonucu sonuc = birinciOrnek.Hesapla(Sayi1, Sayi2);
    Console.WriteLine("Sonuç;");
    Console.WriteLine("\nToplama: " + sonuc.Toplama.ToString() +
                      "\nFark: " + sonuc.Fark.ToString() +
                      "\nÇarpım: " + sonuc.Carpım.ToString() +
                      "\nBölüm: " + sonuc.Bolum.ToString());

}
void IkinciOrnegiUygula()
{
    Data birinciOrnek = new Data();
    Sayılar sayılar = new Sayılar();
    Console.WriteLine("1. Sayıyı Giriniz: ");
    sayılar.Sayı1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("2. Sayıyı Giriniz: ");
    sayılar.Sayı2 = Convert.ToInt32(Console.ReadLine());

    HesaplamaSonucu sonuc = birinciOrnek.Hesapla(sayılar);
    Console.WriteLine("Sonuç;");
    Console.WriteLine("Toplam Sonucu: " + sonuc.Toplama.ToString() +
                      "\nÇıkartma Sonucu: " + sonuc.Fark.ToString() +
                      "\nÇarpım Sonucu: " + sonuc.Carpım.ToString() +
                      "\nBölüm Sonucu: " + sonuc.Bolum.ToString());
}
void UcuncuOrnegiUygula()
{
    Rakamlar rakamlar = new Rakamlar();
    Console.WriteLine("1. Sayıyı Giriniz!");
    rakamlar.sayi1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("2. Sayıyı Giriniz!");
    rakamlar.sayi2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Üssü Giriniz!");
    rakamlar.Us = Convert.ToInt32(Console.ReadLine());

    Data birinciOrnek = new Data();

    List<UsluToplamCarpimSonucu> result = birinciOrnek.Hesapla(rakamlar);

    foreach (var deger in result)
    {
        Console.WriteLine("Toplam: " + deger.Toplam.ToString() + "\nÇarpım: " + deger.Carpim.ToString());
    }
}



