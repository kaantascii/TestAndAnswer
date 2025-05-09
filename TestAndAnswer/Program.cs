using System;

class soruCevap
{
    static void Main(string[] args)
    {   // İlk Soru
        Console.WriteLine("Soru: Hangi hayvan uçar?");
        Console.WriteLine("A) Kedi");
        Console.WriteLine("B) Kartal");
       
        string cevap = Console.ReadLine();
        if (cevap.ToUpper() == "B")
        {
            Console.WriteLine("Doğru cevap!");
        }
        else
        {
            Console.WriteLine("Yanlış cevap. Doğru cevap B) Kartal.");
        }
        //İkinci Soru
        Console.WriteLine("Soru: Hangi hayvan yüzebilir?");
        Console.WriteLine("A) Balık");
        Console.WriteLine("B) Aslan");

        cevap = Console.ReadLine();
        if (cevap.ToUpper() == "A")
        {
            Console.WriteLine("Doğru cevap!");
        }
        else
        {
            Console.WriteLine("Yanlış cevap. Doğru cevap A) Balık.");
        }
        // Üçüncü Soru
        Console.WriteLine("Soru: Hangi hayvan yürüyebilir?");
        Console.WriteLine("A) Yılan");
        Console.WriteLine("B) Fil");
        cevap = Console.ReadLine();
        if (cevap.ToUpper() == "B")
        {
            Console.WriteLine("Doğru cevap!");
        }
        else
        {
            Console.WriteLine("Yanlış cevap. Doğru cevap B) Fil.");
        }


    }
}