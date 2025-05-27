using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    public class Task2_class
    {
        // 34: Accept a string input from the user. Convert it into an integer, double, and boolean.
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

        // 35: Calculate circle circumference using constant PI
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

        // 36: Perform basic arithmetic operations
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

        //  37: Apply compound assignment operators
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

        //  38: Print age category
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

        //   39: Temperature-based day type
        public void CheckTemperatureType()
        {
            Console.WriteLine(" Temperature day type");
            Console.WriteLine("Enter temperature in Celsius: ");
            double temp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(temp > 30 ? "Hot day" : "Cool day");
            Console.ReadKey();
        }

        //  40: Print multiplication table
        public void PrintMultiplicationTable(int number)
        {
            Console.WriteLine("Print multiplication table of 7");
            for (int i = 1; i <= 10; i++)
                Console.WriteLine($"{number} x {i} = {number * i}");
            Console.ReadKey();
        }

        //  41: Check if number is prime
        public bool IsPrime(int number)
        {
            Console.WriteLine("Check if number is prime");
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
                if (number % i == 0) return false;
            return true;
        }

        //  42: Reverse a string
        public string ReverseString(string input)
        {
            Console.WriteLine("Reverse String");
            string result = "";
            for (int i = input.Length - 1; i >= 0; i--)
                result += input[i];
            return result;
        }

        //  43: Find largest of three numbers
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

        //  44: Print even numbers from 1 to 100
        public void PrintEvenNumbers1To100()
        {
            Console.WriteLine("Print even numbers from 1 to 100");
            for (int i = 2; i <= 100; i += 2)
                Console.Write(i + " ");
            Console.WriteLine();
            Console.ReadKey();
        }

        //  45: Count vowels and consonants
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

        //  46: Palindrome check
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
        //  50: Check if string contains only digits
        public bool ContainsOnlyDigits(string input)
        {
            Console.WriteLine("Check if string contains only digits");
            foreach (char c in input)
                if (!char.IsDigit(c)) return false;
            return true;
        }

        //  51: Count even numbers in a range
        public int CountEvenNumbersInRange(int start, int end)
        {
            Console.WriteLine(" Count even numbers in a range");
            int count = 0;
            for (int i = start; i <= end; i++)
                if (i % 2 == 0)
                    count++;
            return count;
        }

        //  53: Find index of first occurrence of a string
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

        //  54: Length of last word
        public int LengthOfLastWord(string input)
        {
            Console.WriteLine("Length of last word");
            string[] parts = input.Trim().Split(' ');
            return parts[parts.Length - 1].Length;
        }

        //  55: Check if list contains duplicates
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



            // 60. Traffic Signal System
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

            // 61. Weather Suggestion
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

            // 62. Movie Ticket Pricing
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

            // 63. Count frequency of each element in ArrayList
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

            // 64. Average of positive numbers only
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
