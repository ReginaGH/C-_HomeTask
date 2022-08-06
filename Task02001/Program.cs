// Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее

Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввести следующее число ");
int b = Convert.ToInt32(Console.ReadLine());
if(a>b)
    {
    Console.WriteLine($"Максимальное число: {a}");
    Console.WriteLine($"Минимальное число: {b}");
    }
else
    {
        Console.WriteLine($"Максимальное число: {b}");
        Console.WriteLine($"Минимальное число: {a}");    
    };