// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int max;
int min;

if (number1 > number2)
{
    max = number1;
    min = number2;   
}
else
{
    max = number2;
    min = number1; 
}
Console.WriteLine("Число " + max + " больше");
Console.WriteLine("Число " + min + " меньше");