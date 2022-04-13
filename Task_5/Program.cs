namespace Task_5;

/* Program sprawdzający, czy podana liczba jest liczbą pierwszą */

public static class Task5
{
    public static void Main()
    {
        Console.WriteLine("Enter a number:");

        var input = Console.ReadLine();
        var successParse = int.TryParse(input, out var number);
        if (successParse)
        {
            var isPrime = true;
            if (number < 2)
            {
                isPrime = false;
            }
            else
            {
                for (var i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i != 0) continue;
                    isPrime = false;
                    break;
                }
            }

            Console.WriteLine(isPrime ? $"{number} is a prime number" : $"{number} is NOT a prime number");
        }
        else
        {
            Console.WriteLine($"Unable to parse '{input}'");
        }
    }
}