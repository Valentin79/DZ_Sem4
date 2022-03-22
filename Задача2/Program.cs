// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

string Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    return strValue;
}

string number = Prompt("Введите число: ");

int result = int.Parse(number[0].ToString());
Console.Write($"{number[0]}");
int len = number.Length;
for( int i = 1; i < len; i++)
{
    result = result + int.Parse(number[i].ToString());
    Console.Write($" + {number[i]}");
}

Console.Write($" = {result}");
