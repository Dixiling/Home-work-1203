// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
int InputSize(string message) 
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!); 
}

string[] CreateArray(int size)
{
    string[] array = new string[size];

    for (int i = 0; i < size; i += 1)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        array[i] = Console.ReadLine()!;
    }
    return array;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i += 1)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

string[] ResultArray(string[] array)
{
    int resultSize = 0;
    int index = 0;
    
    for (int i = 0; i < array.Length; i += 1)
    {
        if (array[i].Length <= 3) 
        resultSize += 1;
    }

    string[] arrayRes = new string[resultSize];
    
    for (int i = 0; i < array.Length; i += 1)
     {
        if (array[i].Length <= 3)
        {
            arrayRes[index] = array[i];
            index += 1;

        }
    }
    return arrayRes;
}

int size = InputSize("Введите размер массива: ");
string[] arrayInput = CreateArray(size);
Console.WriteLine();
Console.WriteLine("Созданный массив:");
PrintArray(arrayInput);
Console.WriteLine();
string[] arrayRes = ResultArray(arrayInput);
Console.WriteLine("Новый массив из строк, длина которых меньше, либо равна 3 символам:");
PrintArray(arrayRes);