Console.WriteLine("Ведите три числа: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
int numberС = Convert.ToInt32(Console.ReadLine());
if (numberA>numberB)
{
    if (numberA>numberС)
    {
        Console.Write("Max: ");
        Console.Write(numberA);
    }

    else
    {
        if (numberС>numberB)
        {
            Console.Write("Max: ");
            Console.Write(numberС);
        }
        else
        {
            Console.Write("Max: ");
            Console.Write(numberB);
        }
    }
    
}