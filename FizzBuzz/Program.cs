/*
 * FizzBuzz
 * Print numbers from 1 to 100
 * if a number is a factor of 3 print Fizz
 * if a number is a factor of 5 pront Buzz
 * if a number is a factor of 3 and 5 print FizzBuzz
 * in other cases print number
 */

using FizzBuzz;

IFizzBuzzTest fizzBuzzTester = new FizzBuzzTester();
FizzBuzzTestConsolePrinter fizzBuzzConsolePrinter = new FizzBuzzTestConsolePrinter(fizzBuzzTester);
fizzBuzzConsolePrinter.Print(1,100);
