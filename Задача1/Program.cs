// Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

int A = Prompt("Введите число A: ");
int B = Prompt("Введите число B: ");

while(B < 1) 
{
    Console.WriteLine("Неверный параметр(В < 1)");
    B = Prompt("Введите число B: ");
}

int i = 1;
int result = 1;
while(i <= B)
{
    result = result * A;
    i++;
}

Console.WriteLine(result);
