int numberA = 10;
int numberB = 8;
int max ;
int min ;

if(numberA > numberB)
{
    max = numberA;
    min = numberB;
}
else 
{
    max = numberB;
    min = numberA;
}


Console.WriteLine("max = " + max);
Console.WriteLine("min = " + min);