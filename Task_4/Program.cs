// Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввести второе число ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввести третье число ");
int c = Convert.ToInt32(Console.ReadLine());
if(a>b && a>c)
    {
    Console.WriteLine($"Максимальное число: {a}");
    }
else if(b>c && b>a)
    {
        Console.WriteLine($"Максимальное число: {b}"); 
    }
else
    {
        Console.WriteLine($"Максимальное число: {c}"); 
    };