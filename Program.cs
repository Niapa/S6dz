/*

Задача 41: 
__________
Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
________________________________________________________________________


int[] Nums(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
        {
            count++;
        }
    }

    int[] numbers = new int [count];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string temp = "";

        while (input [i] != ',')
        {
        if(i != input.Length - 1)
        {
            temp += input [i].ToString();
            i++;
        }
        else
        {
            temp += input [i].ToString();
            break;
        }
        }
        numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return numbers;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}

int Sum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    if(array[i] > 0)
    {
        sum ++; 
    }
    return sum;
}

Console.Write("Введите числа через запятую: ");
int[] numbers = Nums(Console.ReadLine()!);
PrintArray(numbers);
int res = Sum(numbers);
Console.WriteLine();
Console.WriteLine($"количество значений больше 0 = {res}");

________________________________________________________________________

Задача 43:
__________
Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
_________________________________________________________________________

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

*/

int InputNum(string message)
{
    Console.Write(message);
    int z = Convert.ToInt32(Console.ReadLine()!);
    return z;
}

void Point(int b1, int b2, int k1, int k2)
{
    if (k1*b2 - k2*b1  ==0 && b1==b2) Console.Write("Прямые совпадают.");
    else if (k1*b2 - k2*b1  ==0) Console.Write("Прямые параллельны.");
    else 
    {var  x = -(b1-b2)/(k1-k2);
    var  y = k1*x + b1;
    Console.WriteLine($"Координаты точки пересечения прямых: ["+ x + "," + y + "].");
    }
}

Console.WriteLine($"Поиск точки пересечения двух прямых, заданных уравнениями: ");
Console.WriteLine("y = k1 * x + b1, y = k2 * x + b2.");
int d1 = InputNum("Введите k1: ");
int e1 = InputNum("Введите b1: ");
int d2 = InputNum("Введите k2: ");
int e2 = InputNum("Введите b2: ");
Point(d1, d2, e1, e2);


















