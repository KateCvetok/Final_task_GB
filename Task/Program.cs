// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символа.

string[] firstArray = { "hello", "2", "world", ":-)" };
string[] secondArray = new string[firstArray.Length - 1];

void CountSymbols(string[] firstArray, string[] secondArray)
{
    int count = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
        if (firstArray[i].Length <= 3)
        {
            secondArray[count] = firstArray[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + " ");
        else Console.Write(array[i] + "]");
    }
    Console.WriteLine();
}
CountSymbols(firstArray, secondArray);
Console.Write($"Исходный массив: ");
PrintArray(firstArray);
Console.Write($"Новый массив: ");
PrintArray(secondArray);
