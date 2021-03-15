using System;

namespace Mentoring.Project01
{
    static class Program
    {
        static void Main()
        {
            var firstNumber = 10;
            var secondNumber = 20;

            DoesNotWork();

            var sum = 0;
            sum += firstNumber + secondNumber;

            Console.WriteLine(sum);
            Console.ReadLine();
        }

        static void DoesNotWork()
        {
            throw new NotImplementedException("This method throws exception and application stops.");
        }
    }
}
