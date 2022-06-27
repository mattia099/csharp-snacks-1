// See https://aka.ms/new-console-template for more information

//snack 5
Console.WriteLine("Inserisci numero di array da creare");
int N = Convert.ToInt32 (Console.ReadLine());

for (int i = 0; i < N; i++)
{
    Console.WriteLine($"Array numero {i+1}");
    int[] tmp = new int[10];
    for (int j = 0; j < tmp.Length; j++)
    {
        Random rnd = new Random();
        tmp[j] = rnd.Next(1,100);
        Console.Write($"{tmp[j]}, ");
    }
    Console.WriteLine(" ");
}

return;

//snack 5
Console.WriteLine("Inserisci numero pari");
int numeroPari;
numeroPari = Convert.ToInt32(Console.ReadLine());

if (numeroPari % 2 == 0)
{
    Console.WriteLine(numeroPari);
}
else
{
    Console.WriteLine(numeroPari+1);
}

return;





return;
//snack 4
int sum2 = 0;
double media = 0;
float c = 0;
for (int i = 2; i <= 10; i++)
{
    sum2 += i;
    c++;
}
media = sum2 / c;

Console.WriteLine($"La somma dei numeri da due a 10 è {sum2}");
Console.WriteLine($"La media dei numeri da due a 10 è {media}");



return;
//snack 3
int num = 10;  
int[] array = new int[num];
int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
    sum += array[i];
}

Console.WriteLine(sum);