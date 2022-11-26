// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Enter first number");
string iv1 = Console.ReadLine();
int n1 = Convert.ToInt32(iv1);

Console.WriteLine("Enter second number");
string iv2 = Console.ReadLine();
int n2 = Convert.ToInt32(iv2);


Console.WriteLine("Enter third number");
string iv3 = Console.ReadLine();
int n3 = Convert.ToInt32(iv3);
int max = n1;

if(n1 > n2)
{
    if(n1 > n3) 
    {
        max = n1;
    }
    else
    {
        max = n2;
    }
} 
else
{
    if(n2 > n3)
    {
        max = n2;
    }
    else
    {
        max = n3;
    }


}
Console.WriteLine("max value is " + max);