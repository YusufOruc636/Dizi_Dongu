int[] dizi=new int[5];

int i=0;
int toplam=0;

do
{
    Console.WriteLine("not giriniz");
    dizi[i]=Convert.ToInt32(Console.ReadLine());
    toplam += dizi[i];
    i++;
    
}
while (i<dizi.Length);
Console.WriteLine("girdiğiniz notlar:");
Console.WriteLine($"notlar toplamı: {toplam}");