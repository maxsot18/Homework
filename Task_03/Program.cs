// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

Console.WriteLine("Enter a number ");
string inputvalue = Console.ReadLine();
int value = Convert.ToInt32(inputvalue);

if(value % 2 == 0)
{
    Console.WriteLine("Even number");
}
else
{
    Console.WriteLine("not even");
}




