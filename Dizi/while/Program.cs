using System.Reflection.Metadata.Ecma335;

int[] numbers= {5,10,15,-3,20,25};

int i=0;

while (i<numbers.Length)
{
    if(numbers[i]<0)
    {
        i++;
        continue;
    }
    Console.WriteLine($"porizitif sayi: {numbers[i]}");

    i++;

}
Console.ReadKey();