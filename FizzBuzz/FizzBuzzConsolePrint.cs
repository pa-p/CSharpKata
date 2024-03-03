/*
 * FizzBuzz
 * Print numbers from 1 to 100
 * if a number is a factor of 3 print Fizz
 * if a number is a factor of 5 pront Buzz
 * if a number is a factor of 3 and 5 print FizzBuzz
 * in other cases print number
 */

using FizzBuzz;

public class FizzBuzzTestConsolePrinter
{
    private IFizzBuzzTest _fizzBuzzTester;    

    public FizzBuzzTestConsolePrinter(IFizzBuzzTest fizzBuzzTester)
    {
        _fizzBuzzTester = fizzBuzzTester;        
    }    

    public void Print(int start, int count)
    {
        var numbers = Enumerable.Range(start, count);
        foreach (var number in numbers)
        {
            Console.WriteLine(_fizzBuzzTester.Test(number));
        }
    }
}