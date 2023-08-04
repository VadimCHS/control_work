// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

string[] sortArrLenghtStr(string[] array, int lenghtStr)
{
    int countEl = 0;
    string[] result;
    foreach (string str in array)
    {
        if (str.Length <= lenghtStr)
        {
            countEl++;
        }
    }

    result = new string[countEl];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= lenghtStr)
        {
            result[j] = array[i];
            j++;
        }
    }
    return result;
}

string[] arrayStr = { "Hello", " ", "world", ":-)", "1234", "Set", "-2" };
int quantityChar = 3;

string[] newArrStr = sortArrLenghtStr(arrayStr, quantityChar);
Console.Write($"[{string.Join(", ", arrayStr)}] -> ");
Console.Write($"[{string.Join(", ", newArrStr)}]");

