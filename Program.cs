using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamTrn_Hw_01
{
    class Program
    {
        static bool IsNains(int value)
        {
            string valueStr = value.ToString();
            for (int i = 0; i < valueStr.Length; i++)
            {
                if (valueStr[i] != '9')
                {
                    return false;
                }
            }
            return true;
        }

        static int GetMissing(string sequence, int firstNumberLength)
        {
            int prevNumber = Convert.ToInt32(sequence.Substring(0, firstNumberLength));
            int numberLength = firstNumberLength;
            if (IsNains(prevNumber))
            {
                numberLength++;
            }
            int missingNumber = -1;

            for (int i = firstNumberLength; i <= sequence.Length - numberLength; i += numberLength)
            {
                int currentNumber = Convert.ToInt32(sequence.Substring(i, numberLength));

                if (currentNumber <= prevNumber)
                {
                    return -1;
                }
                if (currentNumber > prevNumber + 2)
                {
                    return -1;
                }

                if (currentNumber == prevNumber + 2)
                {
                    if (missingNumber == -1) // first missing number
                    {
                        missingNumber = currentNumber - 1;
                    }
                    else
                    {
                        return -1;
                    }
                }

                if (IsNains(currentNumber))
                {
                    numberLength++;
                }

                prevNumber = currentNumber;
            }

            return missingNumber;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter sequence:> ");
            string sequence = Console.ReadLine();

            int firstNumberLength = 1;
            int missing = GetMissing(sequence, firstNumberLength);
            while ((missing == -1) && (firstNumberLength < sequence.Length / 2))
            {
                firstNumberLength++;
                missing = GetMissing(sequence, firstNumberLength);
            }

            Console.WriteLine($"Missing number: {missing}");
            Console.ReadKey();
        }
    }
}
