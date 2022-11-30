void FillArray(int[] koll)
{
    int length = koll.Length;
    int index = 0;
    while (index < length)
    {
        koll[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int [] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
int[] array = new int[10];

FillArray(array);
PrintArray(array);

