Console.WriteLine("Введите число: ");
int numberA = int.Parse(Console.ReadLine()!);
int count = -numberA;
while(count <= numberA){
    Console.Write($"{count} ");
    count++;
}
