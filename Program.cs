// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

/*
int Exp (int num1, int num2)
{
    int result = 1;
    for(;num2 > 0; num2--)
        result = result * num1;
    return result;
}

int ReadNumbers (string str)
{
    Console.Write(str);
    return Convert.ToInt32(Console.ReadLine());
}
int number = ReadNumbers("Input number: ");
int degree =  ReadNumbers("Input degree: ");
Console.WriteLine(Exp(number, degree));
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

/*
int ReadNumbers (string str)
{
    Console.Write(str);
    return Convert.ToInt32(Console.ReadLine());
}

int number = ReadNumbers("Input number: ");

int SummDigits (int num)
{
    int result = 0;
    for (; num > 0; num = num / 10)
        result += num % 10;
    return result;
}
Console.WriteLine(SummDigits(number));
*/

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]