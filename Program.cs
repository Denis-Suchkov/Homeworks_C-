#region ДЗ Задача №2 Семинар 1:
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3


Console.Clear();  
Console.Write("Ввидите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Ввидите второе число: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 < number2)
{
   Console.Write($"max = {number2}"); 
}
else
{
    if (number1 > number2)
    {
        Console.Write($"max = {number1}");
    }
    
    else 
    {
        Console.Write("Эти числа равные");
    }
    

}

#endregion

#region ДЗ Задача №4 Семинар 1: 
//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.Clear();  
Console.Write("Ввидите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Ввидите второе число: ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Ввидите третье число: ");
int number3 = int.Parse(Console.ReadLine());

int max = number1;

if (number1 > max) max = number1;
if (number2 > max) max = number2;
if (number3 > max) max = number3;

Console.Write($"Максимальное число равно {max}");

#endregion

#region  ДЗ Задача №6 Семинар 1:
//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();  
Console.Write("Ввидите число: ");
int number = int.Parse(Console.ReadLine());

if ((number % 2) == 0)
{
Console.Write("Чётное число");
}

else
{
    Console.Write("Нечётное число");
}

#endregion

#region ДЗ Задача №8 Семинар 1: 
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();  
Console.Write("Ввидите число: ");
int number = int.Parse(Console.ReadLine());
                       
// Первое решение: 
int index = 1;
while (index <= number)
{
    if (index % 2 == 0) // проверка на деление без остатка на двойку
    {
        Console.Write($" {index} ");
    }
    index++; // i = i + 1;  i += 1; 
}
Console.WriteLine();

Второе решение:

int index1 = 2;
while (index1 <= number)
{
    Console.Write($" {index1} ");
    index1 += 2; // index = index + 2;   
}

// Еще один вариант решение:

int x = 2;

if (number < 2)
    Console.WriteLine("Ошибка!");

else
    {
    string s = " -> "; s = number + s;
    
    while (x <= number) 
    {
        s = s + x;
    
        if (x + 2 <= number)
            s = s + ", ";
            x = x + 2;
    }        
    
    Console.WriteLine(s);
    }

#endregion


#region ДЗ Задача №10 Семинар 2:
// Принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа

Console.Clear();
int num = new Random().Next(100, 1000);
int a = num % 100;
int b = a / 10;   

Console.WriteLine($"{num} -> {b}");

#endregion

#region ДЗ Задача №13 Семинар 2:
// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.

Console.Clear(); 
Console.Write("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number);

if (numberText.Length > 2)
{
  Console.WriteLine($"третья цифра -> {numberText[2]}");
}
else 
{
  Console.WriteLine("третьей цифры нет");
}


Второй вариант решения:

Console.Clear(); 
Console.Write("Введи число: ");
int num = int.Parse(Console.ReadLine());
int k = num;

if (k < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else 
{
    while(k > 999)
    {
        k = k / 10;
    }    
    k = k % 10;
    Console.WriteLine($"третья цифра -> {k}"); 
}   

#endregion

#region ДЗ Задача №15 Семинар 2:
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.  6 -> да, 7 -> да, 1 -> нет


Console.Clear(); 
Console.Write("Введи цифру, обозначающую день недели: ");
int num = Convert.ToInt32(Console.ReadLine());

void WeekDay (int num) 
{
  if (num == 6 || num == 7)
  {
    Console.WriteLine($"{num} -> Да");
  }
  else if (num < 1 || num > 7)
  {
    Console.WriteLine($"{num} -> Нет");
  } 
}
WeekDay (num);

#endregion


#region ДЗ Задача №23 Семинар 3:
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

for (int i = 1; i <= num; i++)
{                           
    Console.WriteLine($"i * i = {i*i*i}");
}

#endregion

#region ДЗ Задача №21 Семинар 3:

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Введите координаты точек");

Console.WriteLine("Введите X1: ");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Y1: ");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите C1: ");
int c1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите X2: ");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Y2: ");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите C2: ");
int c2 = int.Parse(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(c1 - c2, 2));

Console.WriteLine($"d = {d:f2}");

#endregion

#region ДЗ Задача №19 Семинар 3: 
// программа которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear(); 
Console.Write("Введите число: ");
string num = Console.ReadLine();

 void palindrome(string num)
 {
    if(num[0] == num[4] || num[1] == num[3])
    {
        Console.WriteLine($"{num} -> Да ");
    }
    else
    {
        Console.WriteLine($"{num} -> Нет ");
    }

 }
palindrome (num);

// Вариант №2

Console.Clear(); 
Console.Write("Введите число: ");
string sNum = Console.ReadLine();

int length = sNum.Length;

for (int i = 0; i < length / 2; i++)
{//            != неравно 
    if(sNum[i] != sNum [length - 1 - i])
    {
        Console.WriteLine($"Строка {sNum} не палиндром");
        return; 
    }
}

Console.WriteLine($"Строка {sNum} палиндром");


// Вариант №3

Console.Clear(); 
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int a1 = num / 10000;
num -= a1 * 10000;

int a2 = num / 1000;
num -= a2 * 1000;

int a3 = num / 100;
num -= a3 * 100;

int a4 = num / 10;
num -= a4 * 10;

int a5 = num % 10;

if(a1 == a5 && a2 == a4)
    Console.WriteLine("Да");

else 
    Console.WriteLine("Нет");

#endregion


#region ДЗ Задача №29 Семинар 4:
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Clear();
int[] array;               
array = GetBinaryArray(8); 

int[] GetBinaryArray(int size) 
{
    int[] array = new int[size];  
    
    for (int i= 0; i < size; i++)
    {
        array[i] = new Random().Next(50);
    }
    return array;
}


Console.Write(string.Join(",", array));
Console.WriteLine($" -> [{string.Join(",", array)}]"); 
Console.WriteLine();

#endregion

#region Дз Задача №25 Семинар 4:
// Напишите цикл, который принимает на вход два числа (A и B) и возводит 
// число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear(); 
Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int Exponentiation(int numberA, int numberB)  // метод через переменную
{
    int result = 1;

    for(int i = 0; i < numberB; i++)  // или for(int i = 1; i <= numberB; i++)
    {
        result = result * numberA;      
    }
    
    return result;
}

int ExponentiationResult = Exponentiation(numberA, numberB); 
Console.WriteLine($"{numberA}, {numberB} -> {ExponentiationResult}"); 


// Вариант №2
Console.Clear(); 
Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine());

int Result(int i)  // метод через индекс
{
    int res = a;
    for(i = 1; i < b; i++)
    {
        res *= a;  
    }
    
    return res;
}
Console.WriteLine(Result(b));   


// Вариант №3
Console.Clear(); 
Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine());

int MyPow(int n, int m)  
{
    int result = n;
    for(int i = 1; i < m; i++)
    {
        result *= n;  
    }
    
    return result;
}
Console.WriteLine(MyPow(a, b)); 

#endregion

#region Задача №27 Семинар 4:
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear(); 
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Sum(int number)
{
    int sum = 0;
    sum = (number % 10);
    
    if(number >= 10)
    {
        sum += Sum(number / 10);
    }
    return sum;
}

int SumNum = Sum(number);
Console.WriteLine($"{number} -> {SumNum}");


// Вариант №2
Console.Clear(); 
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int Sum(int number)
{
    int sum = 0;
    while(num > 0)
    {
        sum += num % 10;  // sum = sum + num % 10; остаток от деления то-есть последнюю цифру числа 
        num /= 10;  // уменьшаем исходное число на 10
    }
    return sum;
}    
Console.WriteLine($"{num} -> {(Sum(num))}");

#endregion


#region Задача №34 Семинар 5:
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();     
int[] array = GetArray(4, 100, 1000);

int[] GetArray(int count, int minnum, int maxnum)
{
    int[] array = new int [count];

    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(minnum, maxnum);
    }
    return array;
}

int EvenNumbers(int[] array)
{
    int result = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            result++;
        }
    }
    return result;
}

int result = EvenNumbers(array);
Console.Write(String.Join(", ", array));
Console.Write($" -> {result}");

#endregion

#region Задача №36 Семинар 5:
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();     
int[] array = GetArray(4, -10, 100);

int[] GetArray(int count, int minnum, int maxnum)
{
    int[] array = new int [count];

    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(minnum, maxnum);
    }
    return array;
}

int SumElements(int[] array)
{
    int result = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0)
        {
            result = result + array[i];
        }
    }
    return result;
}

int result = SumElements(array);
Console.Write(String.Join(", ", array));
Console.Write($" -> {result}");

#endregion

#region Задача №38 Семинар 5:
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();     
double[] array = GetArray(4, 0, 10);

double[] GetArray(int count, int minnum, int maxnum)
{
    double[] array = new double [count];

    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(minnum, maxnum);
    }
    return array;
}

double GetDiff(double[] array)
{
    double min = array[0];
    double max = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if(min > array[i]) min = array[i];
        if(max < array[i]) max = array[i];
    }
    return max - min;
}

Console.Write(String.Join(", ", array));
Console.Write($" -> {GetDiff(array)}");

#endregion


#region  Задача №41 Семинар 6:
// Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
Console.Write("Введите количество М чисел: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] num = new int[m];

void NumbersM(int m)
{
for (int i = 0; i < m; i++)
  {
    Console.Write($"Введите число № {i+1}: ");
    num[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int Сalculation(int[] num)
{
  int count = 0;
  for (int i = 0; i < num.Length; i++)
  {
    if(num[i] > 0 ) count += 1; 
  }
  return count;
}

NumbersM(m);

Console.WriteLine($"-> {Сalculation(num)}");



// Вариант №2

Console.Write("Введите числа через запятую: ");
int[] numbers = StringToNum(Console.ReadLine());
PrintArray(numbers);
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine();
Console.WriteLine($"количество значений больше 0 = {sum}");


int[] StringToNum(string input)
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



// Вариант 3

Console.Write("Введите элементы(через пробел): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Кол-во элементов > 0: {count}");


#endregion

#region Задача №43 Семинар 6:
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.Write("b1 = ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("k1 = ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("b2 = ");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("k2 = ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"       -> ({x}, {y})");
Console.WriteLine();


#endregion


#region Задача №47 Семинар 7: 
// Задайте двумерный массив размером m × n, заполненный случайными вещественными числами.
//  m = 3, n = 4.
//  0,5 7 -2 -0,2
//  1 -3,3 8 -9,9
//  8 7,8 -7,1 9

Console.Clear();
Console.Write("Ввидите количество строк массива M: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Ввидите количество столбцов массива N: ");
int cols = Convert.ToInt32(Console.ReadLine());

double[,] arr = GetArray(rows, cols);  

PrintArray(arr);

// 1 Создание двумерного массива размером M x N

double[,] GetArray(int m, int n) 
{
    double[,] array = new double[m, n];

    for (int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }

    return array;
}  

// 2 Печать двумерного массива

void PrintArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    { 
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j] + " "}");
        }
        Console.WriteLine("");
    }
} 


#endregion

#region Задача №50 Семинар 7: 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

Console.Clear();
Console.Write("Ввидите количество строк массива: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Ввидите количество столбцов массива: ");
int m = Convert.ToInt32(Console.ReadLine());

int [,] numbers = new int [5,4];

GetArray(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента из {n} строки и {m} столбца -> {numbers[n-1,m-1]}");
}

PrintArray(numbers);

void GetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.WriteLine(""); 
    }
}

#endregion

#region Задача №52 Семинар 7: 
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
Console.Write("Ввидите количество строк массива: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Ввидите количество столбцов массива: ");
int m = Convert.ToInt32(Console.ReadLine());


int[,] numbers = new int[n, m];

GetArray(numbers);

for (int j = 0; j < numbers.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        avarage = (avarage + numbers[i, j]);
    }
    avarage = avarage / n;
    Console.Write(avarage + "; ");
}


void GetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}


PrintArray(numbers);

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }

        Console.WriteLine("");
    }
}
Console.WriteLine();

#endregion


#region Задача №54 Семинар 8: 
//Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();
int[,] arr = new int[3, 4];

ArrayRandom(arr);
PrintArray(arr);
SortingArray(arr);
Console.WriteLine();
PrintArray(arr);
Console.WriteLine();

// Функция заполнения массива рандомно числами от 1 до 9
void ArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

// Функция сортировки элементов в строке двумерного массива, по убыванию
void SortingArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

// Функция вывода двумерного массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


#endregion

#region Задача №56 Семинар 8: 
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2            // Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
// 5 9 2 3           
// 8 4 2 4
// 5 2 6 7

Console.Clear();
int[,] arr = new int[4, 4];

ArrayRandom(arr);
PrintArray(arr);
Console.WriteLine();
LineSumElements(arr);
Console.WriteLine();

// Функция вывода номера строки (не индекса) с наименьшей суммой элементов 
void LineSumElements(int[,] array)
{
    int minLine = 0;
    int minSumLine = 0;
    int sumLine = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        minLine += arr[0, i];
    }
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++) sumLine += arr[i, j];
        if (sumLine < minLine)
        {
            minLine = sumLine;
            minSumLine = i;
        }
        sumLine = 0;
    }
    Console.Write($"{minSumLine + 1} строка с наименьшей суммой элементов");
    Console.WriteLine();
}

// Функция вывода двумерного массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Функция заполнения массива рандомно числами от 1 до 9
void ArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

#endregion

#region Задача №58 Семинар 8: 
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
Console.Write("Ввидите количество строк массива: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Ввидите количество столбцов массива: ");
int col = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[row, col];
int[,] secondArray = new int[row, col];
int[,] resultArray = new int[row, col];

ArrayRandom(array);
PrintArray(array);

Console.WriteLine();

ArrayRandom(secondArray);
PrintArray(secondArray);

Console.WriteLine();

if (array.GetLength(0) != secondArray.GetLength(1))
{
    Console.WriteLine(" Нельзя перемножить ");
    return;
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            resultArray[i, j] += array[i, k] * secondArray[k, j];
        }
    }
}

PrintArray(resultArray);



// Функция ввода
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Функция заполнения массива рандомными числами от 1 до 9
void ArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

// Функция вывода двумерного массива в терминал 
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

#endregion

#region Задача №60 Семинар 8: 
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();

int[,,] array = new int[2, 2, 2];
GetArray(array);
PrintIndex(array);
Console.WriteLine();

// Функция вывода индекса элементов 3D массива
void PrintIndex(int[,,] arr)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}
Console.WriteLine();

// Функция заполнения 3D массива не повторяющимеся числами
void GetArray(int[,,] arr)
{
    int count = 40;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[k, i, j] += count;
                count += 4;
            }
        }
    }
}

#endregion

#region Задача №62 Семинар 8: 
// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[size, size];

// Функция заполнения массива по спирали начиная с 1

int num = 1;
int i = 0;
int j = 0;

while (num <= size * size)
{
    numbers[i, j] = num;
    if (i <= j + 1 && i + j < size - 1)
        ++j;
    else if (i < j && i + j >= size - 1)
        ++i;
    else if (i >= j && i + j > size - 1)
        --j;
    else
        --i;
    ++num;
}

PrintArray(numbers);

//  Функция вывода двумерного массива в терминал
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}


#endregion


#region Задача №64 Семинар 9: 
// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""


Console.Clear();

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

void Interval(int m, int n)
{
	for(int i = m; i <= n; i++)
	{
		Console.Write($"{i} ");
	}
}
Interval(m, n);
Console.WriteLine();

#endregion

#region Задача №66 Семинар 9: 
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"-> {CountSum(m, n)}");

int InputNum(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int CountSum(int m, int n)
{
    if (m == n)
        return n;
    return n + CountSum(m, n - 1);
}

#endregion

#region Задача №68 Семинар 9: 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

Console.Clear();

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

AkkermanFunction(m, n);


void AkkermanFunction(int m, int n)
{
    Console.Write($"Функция Аккермана = {Akkerman(m, n)}"); 
}

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}

#endregion