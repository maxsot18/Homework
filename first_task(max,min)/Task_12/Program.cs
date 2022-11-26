Console.Write("Enter a number to find max and min value ");
string InputValue1 = Console.ReadLine();
int N1 = Convert.ToInt32(InputValue1);

Console.Write("Enter a number to find max and min value ");
string InputValue2 = Console.ReadLine();
int N2 = Convert.ToInt32(InputValue2);
int max = N1;
int min = N1;
if(N1 < N2)
{
     max = N2;
     min = N1;   
}

if(N1 > N2)
{
     max = N1;
     min = N2;
}
Console.WriteLine("Max = " + max);
Console.Write("Min = " + min);
