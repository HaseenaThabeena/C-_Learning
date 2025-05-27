using System;
using System.Collections;
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

        // 34. Accept a string input from the user. Convert it into an integer, double, and boolean.
        public void ConvertStringToTypes()
        {
            Console.WriteLine("ConvertStringToTypes");
            Console.WriteLine("Enter a chaaracter or numbeer: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int iVal))
                Console.WriteLine("Integer: " + iVal);
            else Console.WriteLine("Invalid Integer");

            if (double.TryParse(input, out double dVal))
                Console.WriteLine("Double: " + dVal);
            else Console.WriteLine("Invalid Double");

            if (bool.TryParse(input, out bool bVal))
                Console.WriteLine("Boolean: " + bVal);
            else Console.WriteLine("Invalid Boolean");
            Console.ReadKey();
        }

        // 35. Calculate circle circumference using constant PI
        public void CalculateCircleCircumference()
        {
            Console.WriteLine("Calculate circle circumference using constant PI");
            const double PI = 3.14159;
            Console.Write("Enter radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double circumference = 2 * PI * radius;
            Console.WriteLine("Circumference: " + circumference);
            Console.ReadKey();
        }

        // 36. Perform basic arithmetic operations
        public void SimpleCalculator()
        {
            Console.WriteLine("Perform basic arithmetic operations");
            Console.WriteLine("Enter first number: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Addition: {a + b}");
            Console.WriteLine($"Subtraction: {a - b}");
            Console.WriteLine($"Multiplication: {a * b}");
            Console.WriteLine($"Division: {(b != 0 ? (a / b).ToString() : "Cannot divide by zero")}");
            Console.WriteLine($"Modulus: {(b != 0 ? (a % b).ToString() : "Cannot mod by zero")}");
            Console.ReadKey();
        }

        //  37. Apply compound assignment operators
        public void DemonstrateCompoundOperators()
        {
            int x = 10;
            Console.WriteLine("Assignment operators");
            Console.WriteLine("Initial value: " + x);
            x += 5; Console.WriteLine("After += 5: " + x);
            x -= 3; Console.WriteLine("After -= 3: " + x);
            x *= 2; Console.WriteLine("After *= 2: " + x);
            x /= 4; Console.WriteLine("After /= 4: " + x);
            x %= 3; Console.WriteLine("After %= 3: " + x);
            Console.ReadKey();
        }

        //  38. Print age category
        public void PrintAgeCategory()
        {
            Console.WriteLine("Print Age");
            Console.Write("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age <= 12) Console.WriteLine("Child");
            else if (age <= 19) Console.WriteLine("Teenager");
            else if (age <= 64) Console.WriteLine("Adult");
            else Console.WriteLine("Senior");
            Console.ReadKey();
        }

        //   39. Temperature-based day type
        public void CheckTemperatureType()
        {
            Console.WriteLine(" Temperature day type");
            Console.WriteLine("Enter temperature in Celsius: ");
            double temp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(temp > 30 ? "Hot day" : "Cool day");
            Console.ReadKey();
        }

        //  40. Print multiplication table
        public void PrintMultiplicationTable(int number)
        {
            Console.WriteLine("Print multiplication table of 7");
            for (int i = 1; i <= 10; i++)
                Console.WriteLine($"{number} x {i} = {number * i}");
            Console.ReadKey();
        }

        //  41. Check if number is prime
        public bool IsPrime(int number)
        {
            Console.WriteLine("Check if number is prime");
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
                if (number % i == 0) return false;
            return true;
        }

        //  42. Reverse a string
        public string ReverseString(string input)
        {
            Console.WriteLine("Reverse String");
            string result = "";
            for (int i = input.Length - 1; i >= 0; i--)
                result += input[i];
            return result;
        }

        //  43. Find largest of three numbers
        public int FindLargestOfThree(int a, int b, int c)
        {
            Console.WriteLine("Find largest of three numbers");
            if (a >= b && a >= c)
                return a;
            else if (b >= c)
                return b;
            else
                return c;
        }

        //  44. Print even numbers from 1 to 100
        public void PrintEvenNumbers1To100()
        {
            Console.WriteLine("Print even numbers from 1 to 100");
            for (int i = 2; i <= 100; i += 2)
                Console.Write(i + " ");
            Console.WriteLine();
            Console.ReadKey();
        }

        //  45. Count vowels and consonants
        public void CountVowelsAndConsonants(string sentence)
        {
            Console.WriteLine("Count vowels and consonants");
            int vowels = 0, consonants = 0;
            string lower = sentence.ToLower();

            foreach (char c in lower)
            {
                if (char.IsLetter(c))
                {
                    if ("aeiou".Contains(c))
                        vowels++;
                    else
                        consonants++;
                }
            }
            Console.WriteLine($"Vowels: {vowels}, Consonants: {consonants}");
            Console.ReadKey();
        }

        //  46. Palindrome check
        public bool IsPalindrome(string str)
        {
            Console.WriteLine("Palindrome check");
            str = str.ToLower();
            int len = str.Length;
            for (int i = 0; i < len / 2; i++)
                if (str[i] != str[len - 1 - i])
                    return false;
            return true;
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

        //  50. Check if string contains only digits
        public bool ContainsOnlyDigits(string input)
        {
            Console.WriteLine("Check if string contains only digits");
            foreach (char c in input)
                if (!char.IsDigit(c)) return false;
            return true;
        }

        //  51. Count even numbers in a range
        public int CountEvenNumbersInRange(int start, int end)
        {
            Console.WriteLine(" Count even numbers in a range");
            int count = 0;
            for (int i = start; i <= end; i++)
                if (i % 2 == 0)
                    count++;
            return count;
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

        //  53. Find index of first occurrence of a string
        public int IndexOfFirstOccurrence(string haystack, string needle)
        {
            Console.WriteLine("Find index of first occurrence of a string");
            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                bool found = true;
                for (int j = 0; j < needle.Length; j++)
                {
                    if (haystack[i + j] != needle[j])
                    {
                        found = false;
                        break;
                    }
                }
                if (found) return i;
            }
            return -1;
        }

        //  54. Length of last word
        public int LengthOfLastWord(string input)
        {
            Console.WriteLine("Length of last word");
            string[] parts = input.Trim().Split(' ');
            return parts[parts.Length - 1].Length;
        }

        //  55. Check if list contains duplicates
        public bool ContainsDuplicate(List<int> numbers)
        {
            Console.WriteLine("Check if list contains duplicates");
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[i] == numbers[j])
                        return true;
                }
            }
            return false;
        }

        // 56. Merge two ArrayLists without duplicates
        public ArrayList MergeArrayListsWithoutDuplicates(ArrayList list1, ArrayList list2)
        {
            ArrayList result = new ArrayList();
            foreach (var item in list1)
            {
                if (!result.Contains(item))
                    result.Add(item);
            }
            foreach (var item in list2)
            {
                if (!result.Contains(item))
                    result.Add(item);
            }
            return result;
        }

        // 57. Check if ArrayList is a palindrome
        public bool IsArrayListPalindrome(ArrayList list)
        {
            int n = list.Count;
            for (int i = 0; i < n / 2; i++)
            {
                if (!list[i].Equals(list[n - 1 - i]))
                    return false;
            }
            return true;
        }

        // 58. Group elements by type (int, string, char)
        public void GroupElementsByType(ArrayList mixedList)
        {
            List<int> integers = new List<int>();
            List<string> strings = new List<string>();
            List<char> chars = new List<char>();

            foreach (var item in mixedList)
            {
                if (item is int)
                    integers.Add((int)item);
                else if (item is string)
                    strings.Add((string)item);
                else if (item is char)
                    chars.Add((char)item);
            }

            Console.WriteLine("Integers: " + string.Join(", ", integers));
            Console.WriteLine("Strings: " + string.Join(", ", strings));
            Console.WriteLine("Chars: " + string.Join(", ", chars));
        }



        // 59. Traffic Signal System
        public enum TrafficLight { Red, Yellow, Green }
        public string GetTrafficSignalAction(TrafficLight light)
        {
            switch (light)
            {
                case TrafficLight.Red: return "Stop";
                case TrafficLight.Yellow: return "Slow Down";
                case TrafficLight.Green: return "Go";
                default: return "Unknown Signal";
            }
        }

        // 60. Weather Suggestion
        public enum WeatherType { Sunny, Rainy, Snowy, Windy }
        public string GetWeatherSuggestion(WeatherType weather)
        {
            switch (weather)
            {
                case WeatherType.Sunny: return "Wear sunglasses";
                case WeatherType.Rainy: return "Take an umbrella";
                case WeatherType.Snowy: return "Wear a coat";
                case WeatherType.Windy: return "Wear a windbreaker";
                default: return "Check the forecast";
            }
        }

        // 61. Movie Ticket Pricing
        public enum AgeGroup { Child, Adult, Senior }
        public double GetMovieTicketPrice(AgeGroup group)
        {
            switch (group)
            {
                case AgeGroup.Child: return 5.0;
                case AgeGroup.Adult: return 10.0;
                case AgeGroup.Senior: return 7.5;
                default: return 0;
            }
        }

        // 62. Count frequency of each element in ArrayList
        public void CountElementFrequency(ArrayList list)
        {
            Dictionary<object, int> frequencyMap = new Dictionary<object, int>();
            foreach (var item in list)
            {
                if (frequencyMap.ContainsKey(item))
                    frequencyMap[item]++;
                else
                    frequencyMap[item] = 1;
            }

            foreach (var kvp in frequencyMap)
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }

        // 63. Average of positive numbers only
        public double AverageOfPositiveNumbers(List<int> numbers)
        {
            int sum = 0, count = 0;
            foreach (var num in numbers)
            {
                if (num > 0)
                {
                    sum += num;
                    count++;
                }
            }

            return count == 0 ? 0 : (double)sum / count;
        }
    }
}
