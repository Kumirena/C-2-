/* Напишите программу, которая принимает на вход
трехзначное число и на выходе показывает вторую цифру этого числа.
*/ 

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string n = Convert.ToString(number);
{
Console.WriteLine($"Трехзначное число: {number}");
Console.WriteLine($"Вторая цифра: " +n[1]);
}






