int [] array = {1, 21, 32, 43, 54, 65, 65, 65, 55, 42, 31, 11};

int n = array.Length;
int find = 65;

int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index = index + 1;
}