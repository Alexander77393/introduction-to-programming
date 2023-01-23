// Напишите программу,которая выводит выводит случайное число из отрезка [10 , 99]
// и показывает наибольшую цифру числа.


Console.Clear();

int num = new Random().Next(10, 100);

int numA = num / 10;
int numB = num % 10;

int NumMax = numA;

if(numA < numB){
    NumMax = numB;
}

Console.WriteLine($"макс цифра {num} будет {NumMax}");

