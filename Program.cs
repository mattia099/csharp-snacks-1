// See https://aka.ms/new-console-template for more information
int num = 10;  
int[] array = new int[num];
int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
    sum += array[i];
}

Console.WriteLine(sum);