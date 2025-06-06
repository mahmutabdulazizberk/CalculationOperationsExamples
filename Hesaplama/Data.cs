﻿using System.Collections.Generic;
using static Hesaplama.Data;

namespace Hesaplama;

public class Data
{
    
    public HesaplamaSonucu Hesapla(int Sayi1, int Sayi2)
    {
        HesaplamaSonucu hesaplama = new HesaplamaSonucu();
        hesaplama.Toplama = Sayi1 + Sayi2;
        hesaplama.Carpım = Sayi1 * Sayi2;
        hesaplama.Bolum = Sayi1 / Sayi2;
        hesaplama.Fark = Sayi1 - Sayi2;
        return hesaplama;
    }

    public HesaplamaSonucu Hesapla(Sayılar sayılar)
    {
        HesaplamaSonucu hesaplamaSonucu = new HesaplamaSonucu();
        hesaplamaSonucu.Toplama = sayılar.Sayı1 + sayılar.Sayı2;
        hesaplamaSonucu.Fark = sayılar.Sayı1 - sayılar.Sayı2;
        hesaplamaSonucu.Carpım = sayılar.Sayı1 * sayılar.Sayı2;
        hesaplamaSonucu.Bolum = sayılar.Sayı1 / sayılar.Sayı2;
        return hesaplamaSonucu;
    }

    public List<UsluToplamCarpimSonucu> SonucVer(Rakamlar rakamlar)
    {
        return Enumerable.Range(1, rakamlar.Us).Select(i => new UsluToplamCarpimSonucu
        {
            Toplam = (int)(Math.Pow(rakamlar.sayi1, i)) + (int)(Math.Pow(rakamlar.sayi2, i)),
            Carpim = (int)(Math.Pow(rakamlar.sayi1, i)) * (int)(Math.Pow(rakamlar.sayi2, i))
        }).ToList();
    }

    public List<UsluToplamCarpimSonucu> Hesapla(Rakamlar rakamlar)
    {
        return SonucVer(rakamlar);
    }

    public class UsluToplamCarpimSonucu
    {
        public int Toplam { get; set; }
        public int Carpim { get; set; }
    }

    public class HesaplamaSonucu
    {
        public int Toplama { get; set; }
        public int Carpım { get; set; }
        public int Bolum { get; set; }
        public int Fark { get; set; }
    }
    public class Sayılar
    {
        public int Sayı1 { get; set; }
        public int Sayı2 { get; set; }
    }
    public class Rakamlar
    {
        public int sayi1 { get; set; } //3
        public int sayi2 { get; set; } //1 
        public int Us { get; set; } //2
    }
}