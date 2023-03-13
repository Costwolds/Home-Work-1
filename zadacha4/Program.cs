// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int number3 = int.Parse(Console.ReadLine());
int maxim = number1;
if (maxim > number2 & maxim > number3)
{
 maxim = number1;
 Console.WriteLine(maxim);
}
else if (number2 > number1 & number2 > number3)
{
    maxim = number2;
    Console.WriteLine(maxim);
}
else if (number3 > number1 & number3 > number2)
{
    maxim = number3;
    Console.WriteLine(maxim);
}







