/*string Metod4(int count, string text) 
{
    string result = String.Empty;
    for (int i = 0; i<count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Metod4(10, "asdf"); 
Console.WriteLine(res);*/

/*for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i}*{j} = {i*j}");
    }
    Console.WriteLine();
}
*/

//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками, // маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?


/* string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
+ "ежели бы вас послали вместо нашего милого Винценгероде,"
+ "вы бы взяли приступом согласие прусского короля."
+ "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldV, char newV);
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldV) result + $"{newV}";
        else result + $"{str[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|'); 
Console.WriteLine(newText);

*/

int[] arr = {1,5,4,3,2,6,7,1,1};

void PrintArray(int[] array) 
{
    int count = array.Length;
    for(int i = 0; i < count; i++) 
    {
        Console.Write($"{array[i]} "); 
    }
    Console.WriteLine(); 
}
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++) 
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++) 
        {
            if(array[j] < array[minPosition]) minPosition = j; 
            {
                minPosition = j; 
            }
        }  
        int temporary = array[i];
        array[i] = array[minPosition]; 
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr); 
PrintArray(arr);

