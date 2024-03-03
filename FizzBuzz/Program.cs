/*
 * FizzBuzz
 * Print numbers from 1 to 100
 * if a number is a factor of 3 print Fizz
 * if a number is a factor of 5 pront Buzz
 * if a number is a factor of 3 and 5 print FizzBuzz
 * in other cases print number
 */

var numbers = Enumerable.Range(1, 100);
foreach (var number in numbers)
{
    if (number % 3 == 0 && number % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
        continue;
    }

    if (number % 3 == 0)
    {
        Console.WriteLine("Fizz");
        continue;
    }

    if (number % 5 == 0)
    {
        Console.WriteLine("Buzz");
        continue;
    }

    Console.WriteLine($"{number}");
}