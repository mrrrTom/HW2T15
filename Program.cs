// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Welcome to the day of resolver!");
Console.WriteLine("Please, insert number, to find out - can you rest in that day or not:");
var input = Console.ReadLine();
var number = default(int);
if (!int.TryParse(input, out number))
{
    Console.WriteLine("Sorry, inserted value is not an integer... Bye!");
    return;
}

if (number > 0 && number < 8)
{
    var output = number - 5 > 0 ? "yes" : "no";
    Console.WriteLine(output);
}
else
{
    Console.WriteLine("Really? How many days do you have in week? The answer is SEVEN! Run the application again, be a good boy, insert correct value...");
}