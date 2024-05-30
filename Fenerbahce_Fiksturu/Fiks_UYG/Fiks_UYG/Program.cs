using System;

class Program
{
    static void Main(string[] args)
    {
        // Süper Lig'deki takımlar
        string[] takimlar = {
           "Galatasaray","Fenerbahçe","Trabzonspor","Başakşehir",
            "Kasımpaşa","Beşiktaş","Sivasspor",
            "Alanyaspor","Rizespor","Antalyaspor","Gaziantep",
            "Adana Demirspor","Samsunspor","Kayserispor","Hatayspor",
            "Konyaspor","Ankaragücü","Fatih Karagümrük","Pendikspor",
            "İstanbulspor"
        };

        
        Random rnd = new Random();
        for (int i = takimlar.Length - 1; i > 0; i--)
        {
            int j = rnd.Next(0, i + 1);
            string temp = takimlar[i];
            takimlar[i] = takimlar[j];
            takimlar[j] = temp;
        }

        Console.WriteLine("Fenerbahçe'nin Süper Lig Fikstürü:");
        Console.WriteLine("------------------------------");

        int fener = Array.IndexOf(takimlar, "Fenerbahçe");

        for (int hafta = 0; hafta < 38; hafta++) 
        {
            
            int f = (fener + hafta) % (takimlar.Length - 1); 

            if (f >= fener)
                f++; 

            string ev, dep;

            // Her hafta Fenerbahçe'nin ev sahibi veya deplasman olmasını sağlama
            if (hafta % 2 == 0)
            {
                ev = "Fenerbahçe";
                dep = takimlar[f];
            }
            else
            {
                ev = takimlar[f];
                dep = "Fenerbahçe";
            }

            Console.WriteLine($"Hafta {hafta + 1}: {dep} vs. {ev}");
        }

        Console.ReadLine();
    }
}


