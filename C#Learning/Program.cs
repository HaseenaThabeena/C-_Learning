using DocumentFormat.OpenXml.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
            //roman.RomanToInt("IV");
            //Console.ReadKey();
            //StudentGrade studentG = new StudentGrade();
            //studentG.totalstudent();
            //Enum_val e = new Enum_val();
            //e.showday();
            //Rectangle r = new Rectangle(20, 15);
            //double a = r.area();
            //Console.WriteLine("Area: {0}", a);
            //Console.ReadKey();


            //Task Test


            List<int> list = new List<int> { 12, -3, 7, 0, -2, 5, 18, -8, -1, 0, 3, 20, 9, 4, 7, 5 };

            List_2 operations = new List_2();
                       

            // 20. Find the Largest Number in a List
            operations.FindLargest(list);
            Console.WriteLine();

            // 21. Count Positive and Negative Numbers
            operations.CountPositiveNegative(list);
            Console.WriteLine();

            // 22. Sum of Even and Odd Numbers
            operations.SumEvenOdd(list);
            Console.WriteLine();

            // 23. Check If List Contains a Specific Number
            Console.Write("Enter a number to check if it exists in the list: ");
            int number = int.Parse(Console.ReadLine());
            operations.CheckIfContains(list, number);
            Console.WriteLine();

            // 24. Multiply List Elements by 3
            operations.MultiplyByThree(list);
            Console.WriteLine();

            // 25. Even or Odd Number Checker
            operations.CheckEvenOdd(list);
            Console.WriteLine();

            // 26. Average of List Elements
            operations.CalculateAverage(list);
            Console.WriteLine();

            // 27. Find the Smallest Number in a List
            operations.FindSmallest(list);
            Console.WriteLine();

            // 28. Reverse a List
            operations.ReverseList(list);
            Console.WriteLine();

            // 29. Count the Number of Zeros in a List
            operations.CountZeros(list);
            Console.WriteLine();

            // 30. Calculate the Product of All List Elements
            operations.CalculateProduct(list);
            Console.WriteLine();

            // 31. Find the Second Largest Number in a List
            operations.FindSecondLargest(list);
            Console.WriteLine();

            // 32. Print Only the Positive Numbers
            operations.PrintPositiveNumbers(list);
            Console.WriteLine();

            // 33. Replace Negative Numbers with Zero
            operations.ReplaceNegativeWithZero(list);

            // 47. Count Negative Numbers in a List
            operations.CountNegativeNumbers(list);
            Console.WriteLine();

            // 48. Find All Divisors of a Number
            Console.Write("Enter a number to find its divisors: ");
            int divisorNum = int.Parse(Console.ReadLine());
            operations.FindDivisors(divisorNum);
            Console.WriteLine();
            Console.ReadKey();

            // 49. Find the Second Smallest Element in a List
            operations.FindSecondSmallest(list);
            Console.WriteLine();

            // 52. Remove Duplicates from Sorted List
            operations.RemoveDuplicates(list);
            Console.ReadKey();

        }
    }

    
}  