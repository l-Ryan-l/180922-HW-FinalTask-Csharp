/* 
Задача: Написать программу, которая из имеющегося массива стргок формирует массиив из строк, 
длина которых меньшелибо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на стартевыполенния алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. 
Пример:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1257", "2", "computer science"] -> ["2"]
["Russia", "Denmark", "Kazan"] -> [] 
*/


string[] arrayFirst = new string[5] { "hello", "2", "world", ":-)", "1234" };
string[] arrayFinal = new string[arrayFirst.Length];

void FillArrayFinal(string[] arrayFirst, string[] arrayFinal)
{
    int count = 0;
    for (int i = 0; i < arrayFirst.Length; i++)
    {
        if (arrayFirst[i].Length <= 3)
        {
            arrayFinal[count] = arrayFirst[i];
            count++;
        }
        else
        {
            arrayFinal[count] = " ";
        }
    }
}

void PrintArray(string[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


FillArrayFinal(arrayFirst, arrayFinal);

Console.WriteLine("Исходный массив: ");
PrintArray(arrayFirst);
Console.WriteLine();

Console.WriteLine("Результирующий массив: ");
PrintArray(arrayFinal);


