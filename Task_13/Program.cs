/*Напишите программу, которая выводит третью цифру заданного числа
или сообщает, что третьей цифры нет.
*/
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string strnumber = Convert.ToString(number);

if(strnumber.Length > 2)

{
        Console.WriteLine($"Третья цифра: " +strnumber[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}