// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// int Interval(string message)
// {
//   Console.Write(message);
//   int result = Convert.ToInt32(Console.ReadLine());
//   return result;
// }

// int NaturalNumber(int n, int m)
// {
//   if (n == m) return n;
//   else Console.Write($"{NaturalNumber(n, m + 1)}, ");
//   return m;
// }

// int n = Interval("Введите чило N: ");

// Console.WriteLine(NaturalNumber(n, 1));

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// int Interval(string message)
// {
//   Console.Write(message);
//   int result = Convert.ToInt32(Console.ReadLine());
//   return result;
// }

// int SumOfElements(int n, int m)
// {
//   if (n == m) return n;
//   else return SumOfElements(n + 1, m) + n;
// }

// int n = Interval("Введите число N: ");
// int m = Interval("Введите число M: ");

// Console.WriteLine(SumOfElements(n, m));

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// int Interval(string message)
// {
//   Console.Write(message);
//   int result = Convert.ToInt32(Console.ReadLine());
//   return result;
// }

// int Akkerman(int m, int n)
// {
//   if (m == 0) return n + 1;
//   if (m > 0 && n == 0) return Akkerman(m - 1, 1);
//   else return Akkerman(m - 1, Akkerman(m, n - 1));
// }

// int m = Interval("Введите число M: ");
// int n = Interval("Введите число N: ");

// Console.WriteLine($"A({m},{n}) = {Akkerman(m, n)}");
