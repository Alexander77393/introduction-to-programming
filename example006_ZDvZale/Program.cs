// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа

// Console.Clear();

// int num = new Random().Next(100, 1000);

// int numA = num / 100;
// int numB  = num % 10;

// int numRes = numA * 10 + numB;

// Console.WriteLine($"Трехзначное число{num} -> {numRes}");


//---------------------------------------------------------------



// Напишите программу, которая будет принимать на вход два числа
// и выводить, является ли второе число кратным первому.
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// Console.WriteLine("Введите первое число: ");
// int numberA = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите второе число: ");
// int numberB = int.Parse(Console.ReadLine());

// int numX = numberA % numberB;

// if(numX == 0){
// Console.Write($"{numberA}, {numberB} -> кратно");
// }
//     else
//     {
//        Console.Write($"{numberA}, {numberB} -> не кратно, остаток {numX}");
//     }

// ==============================================================================

// Напишите программу, которая принимает на вход число
// и проверяет, кратно ли оно одновременно 7 и 23.

Console.WriteLine("Введите число: ");
int numberC = int.Parse(Console.ReadLine()!);

// int numX = numberA % 7 || numberA % 23;

if(numberC % 7 == 0 && numberC % 23 == 0)
{
Console.Write($"{numberC} -> кратно");
}
    else
    {
       Console.Write($"{numberC} -> нет");
    }