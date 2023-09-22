var number = 1;
while (number < 106)
{
    if (number % 3 != 0 && number % 5 != 0 && number % 7 != 0)
    {
        Console.WriteLine("number");
    }
    if (number % 105 == 0)
    {
        Console.WriteLine("FizzBuzzBazz");
    }
    else if (number % 35 == 0)
    {
        Console.WriteLine("BuzzBazz");
    }
    else if (number % 21 == 0)
    {
        Console.WriteLine("FizzBazz");
    }
    else if (number % 15 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (number % 7 == 0)
    {
        Console.WriteLine("Bazz");
    }
    else if (number % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else if (number % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    number = number + 1;
}