

using System;

class Program
{
    static void Main() {
        // test inputs are 39, 999, 4
        Console.WriteLine(persistence(39));
        Console.WriteLine(persistence(999));
        Console.WriteLine(persistence(4));
    }

    static int persistence(long num) {
        // handle positives only
        if (num < 0) {
            throw new ArgumentException("num must be positive");
        }

        int multiplicativePersistenceCount = 0;

        // Keep multiplying digits until a single digit is reached
        while (num >= 10)   // 10 is the smallest 2 digit number
        {
            long productOfAllDigitsInNumber = 1;

            while (num > 0) {
                long lastDigit = num % 10;   // gets last digit of num
                productOfAllDigitsInNumber *= lastDigit;   // multiply lastDigit to productOfAllDigitsInNumber
                num /= 10;  // in C# we can use this to get the first digit.
            }

            // Update num with the productOfAllDigitsInNumber
            num = productOfAllDigitsInNumber;
            multiplicativePersistenceCount++;
        }

        return multiplicativePersistenceCount;
    }
}



