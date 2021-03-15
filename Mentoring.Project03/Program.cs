using System;
using System.Collections.Generic;

namespace Mentoring.Project03
{
    static class Program
    {
        static void Main()
        {
            var numbers = new[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Created an array of numbers.");

            var addedFiveNumbers = AddFiveToEveryNumber(numbers);

            Console.WriteLine($"Created {nameof(addedFiveNumbers)}.");

            var addedTenNumbers = AddFiveToEveryNumber(addedFiveNumbers);

            Console.WriteLine($"Created {nameof(addedTenNumbers)}.");

            var convertedToStringAndDuplicated = ConvertToStringAndDuplicate(addedTenNumbers);

            Console.WriteLine($"Created {nameof(convertedToStringAndDuplicated)}.");

            foreach (var item in convertedToStringAndDuplicated)
            {
                Console.WriteLine($"Iterating on the item: {item}");
            }

            Console.WriteLine("Finished iterating first time.");

            foreach (var item in convertedToStringAndDuplicated)
            {
                Console.WriteLine($"Iterating on the item: {item}");
            }

            Console.WriteLine("Finished iterating second time.");
            Console.ReadLine();
        }

        static IEnumerable<int> AddFiveToEveryNumber(IEnumerable<int> values)
        {
            Console.WriteLine($"Came into {nameof(AddFiveToEveryNumber)} method.");

            foreach (var value in values)
            {
                Console.WriteLine($"Adding five to: {value}");

                yield return value + 5;

                Console.WriteLine($"Returned number + 5: {value}");
            }

            Console.WriteLine($"Exiting method {nameof(AddFiveToEveryNumber)}");
        }

        static IEnumerable<string> ConvertToStringAndDuplicate(IEnumerable<int> values)
        {
            Console.WriteLine($"Came into {nameof(ConvertToStringAndDuplicate)} method.");

            foreach (var value in values)
            {
                Console.WriteLine($"Returning first string value: {value}");

                yield return $"String: {value} v1";

                Console.WriteLine($"Returning second string value {value}");

                yield return $"String: {value} v2";

                Console.WriteLine($"Returned second value {value}");
            }

            Console.WriteLine($"Exiting {nameof(ConvertToStringAndDuplicate)} method.");
        }
    }
}
