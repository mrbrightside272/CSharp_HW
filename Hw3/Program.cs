// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// int CountDigits(int inputNumber)
// {   
//     int countDigit = 0;

//     for (; inputNumber > 0; countDigit++)
//         inputNumber /=10;

//     return countDigit;
// }
// bool Palindrom(int inputNumber, int countNUmbers)
// {
//     for (; countNUmbers > 0;)
//     {
//         int degreeOfTen = (int)(Math.Pow(10, countNUmbers - 1));
//         int FirstDigit = inputNumber / degreeOfTen;
//         int lastDigit = inputNumber % 10;
//         if (FirstDigit != lastDigit)
//             return false;

//         inputNumber -= FirstDigit * degreeOfTen;
//         inputNumber /=10;
//         countNUmbers -= 2;
//     }
    
//     return true;
// }

// Console.Clear();
// System.Console.WriteLine("Программа выдает палиндром");
// System.Console.WriteLine("Введите число: ");
// int inputNumber = int.Parse(Console.ReadLine());
// int digits = CountDigits(inputNumber);
// System.Console.WriteLine(Palindrom(inputNumber, digits));

//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// Console.Clear();
// (double x, double y, double z) GetPointFromConsole(string message)
// {
//     System.Console.WriteLine(message);
//     double x = GetNumberFromConsole("x: ");
//     double y = GetNumberFromConsole("y: ");
//     double z = GetNumberFromConsole("z:");
    
//     return (x, y, z);
// }
// int GetNumberFromConsole (string message)
// {
//     System.Console.WriteLine(message);
//     return Int32.Parse(Console.ReadLine());
// }

// (double x, double y, double z) point1 = GetPointFromConsole("Введите точку А: ");
// (double x, double y, double z) point2 = GetPointFromConsole("Введите точку B: ");
// double answer = Math.Round(Math.Sqrt(Math.Pow(point2.x - point1.x, 2) +
//     Math.Pow(point2.y - point1.y, 2) + Math.Pow(point2.z - point1.z, 2)), 2);
// System.Console.WriteLine("Расстояние между двумя точками в 3Д пространстве: " + answer);

//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// Console.Clear();
// Console.Write("Введите число: ");
// int cube = Convert.ToInt32(Console.ReadLine());

// void Cube(int[] cube){
//   int counter = 0;
//   int length = cube.Length;
//   while (counter <  length){
//     cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
//     counter++;
//   }
// }

// void PrintArry(int[] coll){
//   int count = coll.Length;
//   int index = 0;
//   while(index < count){
//     Console.Write(coll[index]+ " ");
//     index++;
//   }
// } 

// int[] arry = new int[cube+1];
// Cube(arry);
// PrintArry(arry);