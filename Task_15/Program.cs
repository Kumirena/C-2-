/*Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот день выходным.
*/
Console.WriteLine("Введите число,обозначающее день недели: ");
string day = (Console.ReadLine() ?? "");
switch (day)
{
    case "1":
    Console.WriteLine("Будний день - понедельник - день тяжелый");
    break;

    case "2":
    Console.WriteLine("Будний день ");
    break;

    case "3":
    Console.WriteLine("Будний день ");
    break;

    case "4":
    Console.WriteLine("Будний день ");
    break;

    case "5":
    Console.WriteLine("Будний день ");
    break;

    case "6":
    Console.WriteLine("Выходной день! Ура!");
    break;

    case "7":
    Console.WriteLine("Выходной день! Ура!");
    break;

    default:
    Console.WriteLine("Ввели неправильное число");
    break;
}
