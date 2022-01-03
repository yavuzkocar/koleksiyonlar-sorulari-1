using System;
using System.Collections;

namespace koleksiyonlar_sorulari_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Asal = new();
            ArrayList AsalDegil = new();
            Console.WriteLine("Lütfen 20 adet sayı girin ve asalmı değilmi kontrol edebilelim.");
            for (int i = 0; i < 20; i++)
            {
                int kontrol = 0;
            bas:
                Console.Write("{0}.sayı = ", i + 1);
                string girdi = Console.ReadLine();
                double numara;
                bool dogru = double.TryParse(girdi, out numara);
                if (dogru && numara >= 0)
                {
                    for (int j = 2; j < numara; j++)
                    {
                        if (numara % j == 0)
                            kontrol++;
                    }
                    if (kontrol != 0)
                        AsalDegil.Add(numara);
                    else
                        Asal.Add(numara);
                }
                else
                {
                    Console.WriteLine("Hatalı giriş yaptınız.Lütfen tekrar giriniz");
                    goto bas;
                }
            }
            int toplam1 = 0;
            int toplam2 = 0;
            foreach (var item in Asal)
                toplam1 += Convert.ToInt32(item);

            foreach (var item in AsalDegil)
                toplam2 += Convert.ToInt32(item);

            int AsalOrtalama = toplam1 / Asal.Count;
            int AsalDegilOrtalama = toplam2 / AsalDegil.Count;
            AsalDegil.Sort();
            Asal.Sort();
            AsalDegil.Reverse();
            Asal.Reverse();
            Console.Write("Girmiş olduğunuz asal sayılar                         :");
            foreach (var item in Asal)
                Console.Write(" " + item + ",");
            Console.WriteLine();

            Console.Write("Girmiş olduğunuz asal olmayan sayılar                 :");
            foreach (var item in AsalDegil)
                Console.Write(" " + item + ",");
            Console.WriteLine();

            Console.WriteLine("Girmiş olduğunuz asal sayıların ortalaması        : {0}", AsalOrtalama);
            Console.WriteLine("Girmiş olduğunuz asal olmayan sayıların ortalaması: {0}", AsalDegilOrtalama);
        }


    }
}
