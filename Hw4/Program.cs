// Задача 25: Напишите цикл, который принимает на вход два числа (А и В) и возводит число в натуральную степень В. 

// int Degree(int NumX, int NumY)
// {
//     int result = 1;

//     for (int i = 1; i <= NumY; i++)
//         result *= NumX;
//     return result;
// }
// System.Console.Write("Введите Number X -> ");
// int x = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите Number Y -> ");
// int y = Convert.ToInt32(Console.ReadLine());

// int degree = Degree(x, y);
// System.Console.WriteLine($"{x} в степени {y} = {degree}");

//Задача 27: Напиште программу, которая принимает на вход число выдает сумму и выдает сумму цифр в числе.

// int SummDigits(int x)
// {
//     int result = 0;
//     while (x > 0)
//     {
//     result += x % 10;
//     x /= 10;
//     }
//     return result;
// }

// System.Console.WriteLine("Введите число -> ");
// int x = Convert.ToInt32(Console.ReadLine());
// int result = SummDigits(x);
// System.Console.WriteLine($"Сумма цифр в числе = {result}");

// Задача 29: Напииште программу, которая задает массив из 8 элементов и выводит их на экран.

int[] CreateArray(int size)
{
    int[] createdArray = new int[size];
    return createdArray;
}

void FillArrayRandomNumbers(int[] array)
{
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(10);
}
string GetArrayInString(int[] array)
{
    return String.Join(",", array);
}

void PrintArray(int[] array)
{
    System.Console.WriteLine(GetArrayInString(array));
}
int size = 8;
int[] array = CreateArray(size);
FillArrayRandomNumbers(array);
PrintArray(array);