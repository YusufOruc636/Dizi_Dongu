int[] sayılar=new int[5];

sayılar[0]=10;
sayılar[1]=20;
sayılar[2]=30;
sayılar[3]=40;
sayılar[4]=50;

for (int i = 0; i < sayılar.Length; i++)
{
    Console.WriteLine($"{i}. indexdeki sayi= {sayılar[i]}");
}

Console.WriteLine("ters sırada  yazdırma");

for (int i = sayılar.Length-1; i >= 0; i--)
{
    Console.WriteLine($"{i}. indexdeki sayi= {sayılar[i]}");
}
Console.ReadKey();
