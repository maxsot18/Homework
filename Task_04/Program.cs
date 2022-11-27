Console.WriteLine("Enter a number ");
string inputvalue = Console.ReadLine();
int value = Convert.ToInt32(inputvalue);

int i = 0;
while(i < value)
{
    if(value[i] % 2 == 0)
    {
        Console.WriteLine(value[i]);
    }
   

}

