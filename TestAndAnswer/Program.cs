using System;

class soruCevap
{
    static void Main(string[] args)
    {
        int dogruSayisi = 0;

        // İlk Soru
        Console.WriteLine("1.Soru: Hangi hayvan uçar?");
        Console.WriteLine("A) Kedi");
        Console.WriteLine("B) Kartal");
        Console.Write("Cevabınız: ");

        string cevap1 = Console.ReadLine().ToUpper();
        if (cevap1 == "B")
        {
            dogruSayisi++;
            Console.WriteLine("Doğru cevap!");
        }
        else
        {
            Console.WriteLine("Yanlış cevap. Doğru cevap B) Kartal.");
        }

        // İkinci Soru
        if (dogruSayisi < 2)
        {
            Console.WriteLine("\n2.Soru: Hangi hayvan yüzebilir?");
            Console.WriteLine("A) Balık");
            Console.WriteLine("B) Aslan");
            Console.Write("Cevabınız: ");
            string cevap2 = Console.ReadLine().ToUpper();

            if (cevap2 == "A")
            {
                dogruSayisi++;
                Console.WriteLine("Doğru cevap!");
            }
            else
            {
                Console.WriteLine("Yanlış cevap. Doğru cevap A) Balık.");
            }
        }

        // Üçüncü Soru
        if (dogruSayisi < 2)
        {
            Console.WriteLine("\n3.Soru: Hangi hayvan yürüyebilir?");
            Console.WriteLine("A) Yılan");
            Console.WriteLine("B) Fil");
            Console.Write("Cevabınız: ");
            string cevap3 = Console.ReadLine().ToUpper();

            if (cevap3 == "B")
            {
                dogruSayisi++;
                Console.WriteLine("Doğru cevap!");
            }
            else
            {
                Console.WriteLine("Yanlış cevap. Doğru cevap B) Fil.");
            }
        }

        // Sonuç
        Console.WriteLine("\n--- Yarışma Sonucu ---");
        if (dogruSayisi >= 2)
        {
            Console.WriteLine("Tebrikler! 1 Milyon TL'lik büyük ödülü kazandınız!");
        }
        else
        {
            Console.WriteLine("Maalesef büyük ödülü kazanamadınız. Daha iyi şanslar!");
        }
    }
}
