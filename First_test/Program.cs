//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

//System.Console.WriteLine("Введите 1 значение: ");
// string? rows = Convert.ToString(Console.ReadLine());
// System.Console.WriteLine("Введите 2 значение: ");
// string? rows1 = Convert.ToString(Console.ReadLine());
// System.Console.WriteLine("Введите 3 значение: ");
// string? rows2 = Convert.ToString(Console.ReadLine());
// System.Console.WriteLine("Введите 4 значение: ");
// string? rows3 = Convert.ToString(Console.ReadLine());
// System.Console.WriteLine("Введите 5 значение: ");
// string? rows4 = Convert.ToString(Console.ReadLine());


string [] arrayFirst = new string[5] {"456", "text", "me", "48923", "invisible"};
string [] arraySecond = new string[arrayFirst.Length];
ArrayWithIf (arrayFirst, arraySecond);
PrintArray (arraySecond);



void ArrayWithIf (string [] arrayFirst, string [] arraySecond)
{
    int count = 0;
    for (int i = 0; i < arrayFirst.Length; i++)
    {
        if (arrayFirst[i].Length <= 3)
        {
            arraySecond[count] = arrayFirst[i];
            count ++;
        }
    }
}

void PrintArray (string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

