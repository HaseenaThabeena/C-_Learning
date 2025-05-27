using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static C_Learning.Task2_class;

namespace C_Learning
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Array_Dup arrayDup = new Array_Dup();
            //arrayDup.arrayDuplicate();
            //MinMax min_max = new MinMax();
            //min_max.Min_Max();
            //Fruit fruit_size = new Fruit();
            //fruit_size.getinput();
            //fruit_size.Display();
            //Calculator cal = new Calculator();
            //cal.getInput();
            //SquarePattern sqrpat = new SquarePattern();
            //sqrpat.squareprint();
            //Factorial Facto = new Factorial();
            //Facto.get_input();
            //Palindrome pali = new Palindrome();
            //pali.getInput();
            //Frequent freq = new Frequent();
            //freq.input();
            //Circlecircum circle_cir = new Circlecircum();
            //circle_cir.getInput();
            //Comparsion com = new Comparsion();
            //com.getInput();
            //Age age_com = new Age();
            //age_com.getInput();
            //Temp temp = new Temp();
            //temp.getInput();
            //Constructor cons = new Constructor();
            //Constructor cons1 = new Constructor("ans",2);
            //Constructor cons2 = new Constructor(cons1);
            //Console.WriteLine("name" + cons1.name, "j " + cons1.j);
            //Table7 tab7 = new Table7();
            //tab7.getInput();
            //Reversestring revstr = new Reversestring();
            //revstr.getInput();
            //Prime prime_val = new Prime();
            //prime_val.getInput();
            //Largest3 large3 = new Largest3();
            //large3.getInput();
            //Even even_num = new Even();
            //even_num.even();
            //Vowels vow = new Vowels();
            //vow.getInput();
            //Stringalignement stralign = new Stringalignement();
            //stralign.getInput();
            //CountNegatives count_neg = new CountNegatives();
            //count_neg.getInput();
            //Divisors divide = new Divisors();
            //divide.getInput();
            //SecLarge secondlarge = new SecLarge();
            //secondlarge.getInput();
            //Digitcheck digit = new Digitcheck();
            //digit.getInput();
            //EventCounter eventcount = new EventCounter();
            //eventcount.Run();
            //Arraysort arrsort = new Arraysort();
            //arrsort.sortarray();
            //BaseClass base_class = new BaseClass();
            //base_class.getinput();
            //base_class = new DerivedClass();
            //base_class.getinput();
            //Numberguess numgame = new Numberguess();
            //numgame.randaom_num();
            //numgame.getInput();
            //TwoSum sumtwo = new TwoSum();
            //sumtwo.getInput();
            //Length len = new Length();
            //len.getInput();
            //SingleNumber sinnum = new SingleNumber();
            //sinnum.getInput();
            //Class1 cla = new Class1 ();
            //cla.arrayfunc();
            //MaxProduct max = new MaxProduct();
            //max.Maxproduct();
            //Roman roman = new Roman();
            //Console.WriteLine(roman.RomanToInt("IV")); ;
            //Console.ReadKey();
            //Missingnum missnum = new Missingnum();
            //int[] nums = { 2, 1, 4 };
            //missnum.MissingNumber(nums);


            List<int> list = new List<int> { 12, -3, 7, 0, -2, 5, 18, -8, -1, 0, 3, 20, 9, 4, 7, 5 };

            List_2 operations = new List_2();

            operations.FindLargest(list);
           
            operations.CountPositiveNegative(list);
           

            operations.SumEvenOdd(list);
          

            Console.Write("Enter a number to check if it exists in the list: ");
            int number = int.Parse(Console.ReadLine());
            operations.CheckIfContains(list, number);
            
            operations.MultiplyByThree(list);
            
            operations.CheckEvenOdd(list);
            
            operations.CalculateAverage(list);
                       
            operations.FindSmallest(list);
                      
            operations.ReverseList(list);
          
            operations.CountZeros(list);
           
            operations.CalculateProduct(list);
          
            operations.FindSecondLargest(list);

            operations.PrintPositiveNumbers(list);
            
            operations.ReplaceNegativeWithZero(list);

            operations.CountNegativeNumbers(list);
           
            Console.Write("Enter a number to find its divisors: ");
            int divisorNum = int.Parse(Console.ReadLine());
            operations.FindDivisors(divisorNum);
            Console.ReadKey();

            operations.FindSecondSmallest(list);
            
            operations.RemoveDuplicates(list);
            Console.ReadKey();


            Task2_class qs = new Task2_class();
            qs.ConvertStringToTypes();
            qs.CalculateCircleCircumference();
            qs.SimpleCalculator();
            qs.DemonstrateCompoundOperators();
            qs.PrintAgeCategory();
            qs.CheckTemperatureType();
            qs.PrintMultiplicationTable(7);
            Console.WriteLine("Is 7 prime? " + qs.IsPrime(7));
            Console.ReadKey();
            Console.WriteLine("Reverse of 'hello': " + qs.ReverseString("hello"));
            Console.ReadKey();
            Console.WriteLine("Largest of (3, 9, 5): " + qs.FindLargestOfThree(3, 9, 5));
            Console.ReadKey();
            qs.PrintEvenNumbers1To100();
            qs.CountVowelsAndConsonants("This is a sample sentence.");
            Console.ReadKey();
            Console.WriteLine("Is 'madam' a palindrome? " + qs.IsPalindrome("madam"));
            Console.ReadKey();
            Console.WriteLine("Even numbers between 2 and 10: " + qs.CountEvenNumbersInRange(2, 10));
            Console.ReadKey();
            Console.WriteLine("Index of 'sad' in 'sadbutsad': " + qs.IndexOfFirstOccurrence("sadbutsad", "sad"));
            Console.ReadKey();
            Console.WriteLine("Length of last word in 'Hello World': " + qs.LengthOfLastWord("Hello World"));
            Console.ReadKey();
            Console.WriteLine("Contains duplicates: " + qs.ContainsDuplicate(list));
            Console.ReadKey();

            ArrayList list1 = new ArrayList() { 1, 2, 3 };
            ArrayList list2 = new ArrayList() { 3, 4, 5 };
            var merged = qs.MergeArrayListsWithoutDuplicates(list1, list2);
            Console.WriteLine("Merged List: " + string.Join(", ", merged.ToArray()));
            ArrayList palindromeList = new ArrayList() { 'r', 'a', 'c', 'e', 'c', 'a', 'r' };
            Console.WriteLine("Is Palindrome: " + qs.IsArrayListPalindrome(palindromeList));
            ArrayList mixed = new ArrayList() { 1, "hello", 'a', 2, "world", 'b' };
            qs.GroupElementsByType(mixed);

            //var manager = new Student.StudentManager();
            //manager.AddStudent("Alice", new List<int> { 85, 90, 78 });
            //manager.AddStudent("Bob", new List<int> { 92, 88, 95 });
            //manager.ShowAverageGrades();
            //manager.ShowTopStudents();
            Console.WriteLine("Traffic Light Action: " + qs.GetTrafficSignalAction(Task2_class.TrafficLight.Red));
            Console.WriteLine("Weather Suggestion: " + qs.GetWeatherSuggestion(Task2_class.WeatherType.Snowy));
            Console.WriteLine("Ticket Price (Senior): $" + qs.GetMovieTicketPrice(Task2_class.AgeGroup.Senior));
            
            ArrayList freqList = new ArrayList() { "apple", "banana", "apple", "orange", "banana", "apple" };
            qs.CountElementFrequency(freqList);
            
            Console.WriteLine("Average of positives: " + qs.AverageOfPositiveNumbers(list));
        }
    }
}  