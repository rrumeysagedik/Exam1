using System;
using System.Collections.Generic;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayiilk, sayi, sonuc;
            List<int> sonuclar = new List<int>();

            Console.Write("Lütfen bir sayı giriniz:");

            sayiilk = Convert.ToInt16(Console.ReadLine());

            if (sayiilk > 0)
            {
                sayi = sayiilk; // Evet çünkü sayıyıda ilk saydan başlatmamız lazım.
                while (sayi > 0)
                {
                    sonuc = Convert.ToInt16(Math.Sqrt(sayi)); // Burda sayınn karekökünü aldık. Int'e çevirdik tamkare olmayan sayıların noktadan sonrasını kaldırmak. sadece sayı kalıyor elimizde.
                    if (sonuc * sonuc == sayi) // Burda da sonuc sayısın karekökünü üstte aldık ya tekrar sonucun karesini alıyorum ki sayının karesine eşit mi. Eşitse tam kare demektir. Tam kare ise o sayıyı altta listeye atıyorum.
                    {
                        sonuclar.Add(sayi);
                        sayi = sayiilk - (sonuc * sonuc); // Burda sayıilk yapmadığımızda hep ilk alınan sayıdan karesini çıkartıyor ve sayı hep ilk halinde dönüyordu. Bu da sadece en büyük tam kareyi almamıza neden oluyordu.
                        sayiilk = sayi; // İlk tamkare bulunduktan sonra bulunan tamkareye eşitliyoruz ki ilk alınan sayıdan devam etmesin diye.  
                    }

                    sayi--;
                }
            }
            else
            {
                Console.WriteLine("lütfen pozitif tam sayı giriniz.");
            }

            foreach (var i in sonuclar)
            {
                Console.WriteLine(i);
            }

        }
    }
}
