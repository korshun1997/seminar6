// 
Console.WriteLine("Введите М");
int M = Convert.ToInt32(Console.ReadLine());
int i = 0;
int count = 0;
int[] array = new int[M];
Random rand = new Random();
int pos(int i, int M, int count)
{
    for (i=0; i<M; i++)
{
    array[i]=Convert.ToInt32(Console.ReadLine());
    if (array[i]>0)
    {
        count++;
    }
}
return count;
}
count = pos(i, M, count);
Console.WriteLine();
Console.WriteLine($"{count}");