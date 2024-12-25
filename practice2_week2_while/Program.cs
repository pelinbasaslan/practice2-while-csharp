using System;

class Program
{
    static void Main(string[] args)
    {
        //1 -> Konsol ekranına 10 kere Kendime inanıyorum, ben bu yazılım işini hallederim! yazdırınız.
        int sayac = 1;
        while (sayac < 11)
        {
            Console.WriteLine($" {sayac}) Kendime inanıyorum, ben bu yazılım işini hallederim!");
            sayac++;
        }

        //2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.
        int sayac2 = 1;
        while (sayac2 <= 20)
        {
            Console.WriteLine(sayac2);
            sayac2++;
        }

        //3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.
        int sayac3 = 2;
        while (sayac3 <= 20)
        {
            Console.WriteLine(sayac3);
            sayac3 += 2;
        }

        //4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
        int sayac4 = 50;
        int toplam = 0;
        while (sayac4 <= 150)
        {
            toplam += sayac4;
            sayac4++;
        }
        Console.WriteLine($"50 ile 150 arasındaki sayıların toplamı: {toplam}.");

        //5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.   
        int sayac5 = 1;
        int sayiCift = 0;
        int sayiTek = 0;
        while (sayac5 <= 120)
        {
            sayiCift += sayac5 + 1;
            sayiTek += sayac5;
            sayac5 += 2;
        }
        Console.WriteLine($"1 ile 120 arasındaki çift sayıların toplamı {sayiCift}.");
        Console.WriteLine($"1 ile 120 arasındaki tek sayıların toplamı {sayiTek}.");
    }
}
