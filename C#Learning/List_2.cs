using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    internal class List_2
    {
        // 20. Find the Largest Number in a List
        public void FindLargest(List<int> list)
        {
            int largest = list[0];
            foreach (int num in list)
            {
                if (num > largest)
                    largest = num;
            }
            Console.WriteLine($"The largest number in the list is: {largest}");
        }

        // 21. Count Positive and Negative Numbers
        public void CountPositiveNegative(List<int> list)
        {
            int positiveCount = 0;
            int negativeCount = 0;
            foreach (int num in list)
            {
                if (num > 0)
                    positiveCount++;
                else if (num < 0)
                    negativeCount++;
            }
            Console.WriteLine($"Positive numbers count: {positiveCount}");
            Console.WriteLine($"Negative numbers count: {negativeCount}");
        }

        // 22. Sum of Even and Odd Numbers
        public void SumEvenOdd(List<int> list)
        {
            int evenSum = 0;
            int oddSum = 0;
            foreach (int num in list)
            {
                if (num % 2 == 0)
                    evenSum += num;
                else
                    oddSum += num;
            }
            Console.WriteLine($"Sum of even numbers: {evenSum}");
            Console.WriteLine($"Sum of odd numbers: {oddSum}");
        }

        // 23. Check If List Contains a Specific Number
        public void CheckIfContains(List<int> list, int number)
        {
            bool found = false;
            foreach (int num in list)
            {
                if (num == number)
                {
                    found = true;
                    break;
                }
            }
            if (found)
                Console.WriteLine($"The number {number} was found in the list.");
            else
                Console.WriteLine($"The number {number} was not found in the list.");
        }

        // 24. Multiply List Elements by 3
        public void MultiplyByThree(List<int> list)
        {
            Console.WriteLine("Updated list after multiplying elements by 3:");
            for (int i = 0; i < list.Count; i++)
            {
                list[i] *= 3;
            }
            foreach (int num in list)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        // 25. Even or Odd Number Checker
        public void CheckEvenOdd(List<int> list)
        {
            foreach (int num in list)
            {
                if (num % 2 == 0)
                    Console.WriteLine($"{num} is Even");
                else
                    Console.WriteLine($"{num} is Odd");
            }
        }

        // 26. Average of List Elements
        public void CalculateAverage(List<int> list)
        {
            double sum = 0;
            foreach (int num in list)
            {
                sum += num;
            }
            double average = sum / list.Count;
            Console.WriteLine($"The average of the list elements is: {average}");
        }

        // 27. Find the Smallest Number in a List
        public void FindSmallest(List<int> list)
        {
            int smallest = list[0];
            foreach (int num in list)
            {
                if (num < smallest)
                    smallest = num;
            }
            Console.WriteLine($"The smallest number in the list is: {smallest}");
        }

        // 28. Reverse a List
        public void ReverseList(List<int> list)
        {
            Console.WriteLine("The list in reverse order:");
            for (int i = list.Count - 1; i >= 0; i--)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }

        // 29. Count the Number of Zeros in a List
        public void CountZeros(List<int> list)
        {
            int zeroCount = 0;
            foreach (int num in list)
            {
                if (num == 0)
                    zeroCount++;
            }
            Console.WriteLine($"Number of zeros in the list: {zeroCount}");
        }

        // 30. Calculate the Product of All List Elements
        public void CalculateProduct(List<int> list)
        {
            int product = 1;
            foreach (int num in list)
            {
                product *= num;
            }
            Console.WriteLine($"The product of all elements in the list is: {product}");
        }

        // 31. Find the Second Largest Number in a List
        public void FindSecondLargest(List<int> list)
        {
            int largest = int.MinValue;
            int secondLargest = int.MinValue;

            foreach (int num in list)
            {
                if (num > largest)
                {
                    secondLargest = largest;
                    largest = num;
                }
                else if (num > secondLargest && num != largest)
                {
                    secondLargest = num;
                }
            }
            Console.WriteLine($"The second largest number in the list is: {secondLargest}");
        }

        // 32. Print Only the Positive Numbers
        public void PrintPositiveNumbers(List<int> list)
        {
            Console.WriteLine("Positive numbers in the list:");
            foreach (int num in list)
            {
                if (num > 0)
                {
                    Console.Write(num + " ");
                }
            }
            Console.WriteLine();
        }

        // 33. Replace Negative Numbers with Zero
        public void ReplaceNegativeWithZero(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < 0)
                {
                    list[i] = 0;
                }
            }
            Console.WriteLine("List after replacing negative numbers with zero:");
            foreach (int num in list)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        // 47. Count Negative Numbers in a List
        public void CountNegativeNumbers(List<int> list)
        {
            int negativeCount = 0;
            foreach (int num in list)
            {
                if (num < 0)
                {
                    negativeCount++;
                }
            }
            Console.WriteLine($"Number of negative numbers in the list: {negativeCount}");
        }

        // 48. Find All Divisors of a Number
        public void FindDivisors(int number)
        {
            Console.WriteLine($"Divisors of {number}:");
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        // 49. Find the Second Smallest Element in a List
        public void FindSecondSmallest(List<int> list)
        {
            int smallest = int.MaxValue;
            int secondSmallest = int.MaxValue;

            foreach (int num in list)
            {
                if (num < smallest)
                {
                    secondSmallest = smallest;
                    smallest = num;
                }
                else if (num < secondSmallest && num != smallest)
                {
                    secondSmallest = num;
                }
            }
            Console.WriteLine($"The second smallest number in the list is: {secondSmallest}");
        }

        // 52. Remove Duplicates from a Sorted List
        public void RemoveDuplicates(List<int> list)
        {
            List<int> uniqueList = new List<int>();

            foreach (int num in list)
            {
                if (!uniqueList.Contains(num))
                {
                    uniqueList.Add(num);
                }
            }

            Console.WriteLine("List after removing duplicates:");
            foreach (int num in uniqueList)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
