using System;

namespace WithoutLiskov
{
    class Program
    {
        static void Main(string[] args)
        {
           var numbers = new int[] { 1,2,3,4,5,6 };
 
        SumCalculator sum = new SumCalculator(numbers);
        Console.WriteLine($"The sum of all the numbers: {sum.Calculate()}");
 
        Console.WriteLine();
 
        EvenNumbersSumCalculator evenSum = new EvenNumbersSumCalculator(numbers);
        Console.WriteLine($"The sum of all the even numbers: {evenSum.Calculate()}");
        }
    }
}
