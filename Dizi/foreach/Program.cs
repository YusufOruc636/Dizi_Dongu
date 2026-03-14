int[] sayilar={10,20,30,40,50};

int toplam=0;

foreach (var sayi in sayilar)
{
    toplam += sayi;
}

double ortalama=(double)toplam/sayilar.Length;

Console.WriteLine($"ortlama: {ortalama:F2}");

Console.ReadKey();