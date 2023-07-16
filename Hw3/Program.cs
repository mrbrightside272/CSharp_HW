// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int CountDigits(int inputNumber)
{   
    int countDigit = 0;

    for (; inputNumber > 0; countDigit++)
        inputNumber /=10;

    return countDigit;
}
bool Palindrom(int inputNumber, int countNUmbers)
{
    for (; countNUmbers > 0;)
    {
        int degreeOfTen = (int)(Math.Pow(10, countNUmbers - 1));
        int FirstDigit = inputNumber / degreeOfTen;
        int lastDigit = inputNumber % 10;
        if (FirstDigit != lastDigit)
            return false;

        inputNumber -= FirstDigit * degreeOfTen;
        inputNumber /=10;
        countNUmbers -= 2;
    }
    
    return true;
}

Console.Clear();
System.Console.WriteLine("Программа выдает палиндром");
System.Console.WriteLine("Введите число: ");
int inputNumber = int.Parse(Console.ReadLine());
int digits = CountDigits(inputNumber);
System.Console.WriteLine(Palindrom(inputNumber, digits));

