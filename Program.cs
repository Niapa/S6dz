/*






int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int Point(int b1, int b2, int k1, int k2)

int size = InputNum("Введите b1: ");
int size = InputNum("Введите k1: ");
int size = InputNum("Введите b2: ");
int size = InputNum("Введите k2: ");
double  x = -(b1-b2)/(k1-k2);
double  y = k1*x + b1;


Задача 41: 
__________
Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
________________________________________________________________________


int Input(string message)
{
   Console.WriteLine(message);
   return int.Parse(Console.ReadLine()!);
}

int[] InputSomeNums()
{
    int[] i nputArray = new int[Input()]

}



string PrintArray(int[] array)
{
   string res = String.Empty;
   for (int i = 0; i < array.Length; i++)
   {
      res += array[i] + " ";
   }
   return res;
}

void Count(int[] array)
{
    int i = 0;
    int res = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0) res += res;
    return res;
}       
  
int m = Input("Введите число M: ");
int[] myArray = Input("Введите массив чисел: ");
InputSomeNums();
Count(myArray);
Console.WriteLine(PrintArray(res));

*/
Задача 43:
__________
Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
_________________________________________________________________________

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int size)
{
    return new int[size];
}

void FillArray(int[] array)
{
    Random rnd = new Random(); 
    for (int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(); 
}

string PrintArray(int[] array)
{
    string res = String.Empty;
    for (int i = 0; i < array.Length; i++)
        res += array[i] + " ";
    return res;
}

int Sum(int [] array)
{
    int res = 0;
    for (int i = 0; i < array.Length; i+=2)
    res += array[i];
    return num;
}
int size = InputNum("Введите размер массива: ");
int [] myArray = CreateArray(size);
FillArray(myArray);
string res = PrintArray(myArray);
Console.WriteLine(res);
int num = Sum(myArray);
Console.WriteLine($"Сумма элементов на нечетных позициях равна: {num}.");

