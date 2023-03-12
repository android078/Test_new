//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

System.Console.WriteLine("Введите 5 значений: ");
string rows = Convert.ToString(Console.ReadLine());

string [] arrayFirst = new string [5];
string [] arraySecond = new string[arrayFirst.Length];
ArrayWithIf (arrayFirst, arraySecond);


void ArrayWithIf (string [] arrayFirst, string [] arraySecond);
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
