// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа.

void PrintArray(string[] arr)
{
    int count = arr.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]}|");
    }
    Console.WriteLine();
}

string[] FillArray(int size)
{
    string[] arr = new string[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = Console.ReadLine();
    }
    return arr;
}

string[] ElementsWIth3Symbols(string[] arr)
{
    int size = arr.Length;
    int[] indexes = new int[size];
    int count = 0;

    for (int i = 0; i < size; i++)
    {
        if (arr[i].Length < 4)
        {
            indexes[count] = i;
            count++;
        }
    }

    string[] newArr = new string[count];
    for(int i = 0; i < count; i++)
    {
        newArr[i] = arr[indexes[i]];
    }
    return newArr;
}

Console.Write("Enter the number of elements you want to add: ");
int numberOfElements = int.Parse(Console.ReadLine());
Console.WriteLine($"Enter anything {numberOfElements} times:");
string[] array = FillArray(numberOfElements);
string[] newArray = ElementsWIth3Symbols(array);
Console.WriteLine("Strings with less than 4 symbols: ");
PrintArray(newArray);

