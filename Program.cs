// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

string[] sortArrLenghtStr(string[] array, int countChar)
{
    int count = 0;
    string[] result;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= countChar)
        {
            count++;
        }
    }

    result = new string[count];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= countChar)
        {
            result[j] = array[i];
            j++;
        }
    }
    return result;
}

string[] array = { "Hello", " ", "world", ":-)", "1234", "Set", "-2" };
int countChar = 3;

string[] newArr = sortArrLenghtStr(array, countChar);
Console.Write($"[{string.Join(", ", array)}] -> ");
Console.Write($"[{string.Join(", ", newArr)}]");

