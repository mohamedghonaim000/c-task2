using System;
using System.Reflection.Metadata;

namespace assigment_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region problem one
            //int UserNumber = Convert.ToInt32(Console.ReadLine());
            //if (UserNumber % 3 == 0 && UserNumber % 4 == 0)
            //{
            //    Console.WriteLine("yes");
            //}
            //else
            //{
            //    Console.WriteLine("no");
            //}
            #endregion
            #region problem 2 
            //int UserNumber = Convert.ToInt32(Console.ReadLine());
            //if (UserNumber <0)
            //{
            //    Console.WriteLine("negative");
            //}
            //else if (UserNumber==0)
            //{
            //    Console.WriteLine("ZERO not positive not negative");
            //}
            //else
            //{
            //    Console.WriteLine("positive");
            //}
            #endregion
            #region problem 3
            //int UserNumber1 = Convert.ToInt32(Console.ReadLine());
            //int UserNumber2 = Convert.ToInt32(Console.ReadLine());
            //int UserNumber3 = Convert.ToInt32(Console.ReadLine());
            //if (UserNumber1 > UserNumber2 && UserNumber1> UserNumber3)
            //{
            //    Console.WriteLine($"the max number equal {UserNumber1}");
            //}
            //if (UserNumber1 == UserNumber2 && UserNumber1 > UserNumber3)
            //{
            //    Console.WriteLine($"the max number equal {UserNumber1}");
            //}
            //else if (UserNumber2 > UserNumber1 && UserNumber2 > UserNumber3)
            //{
            //    Console.WriteLine($"the max number equal {UserNumber2}");
            //}
            //else if( UserNumber3 > UserNumber2 && UserNumber3 > UserNumber1 )
            //{
            //    Console.WriteLine($"the max number equal {UserNumber3}");
            //}
            //else if (UserNumber3 == UserNumber2 && UserNumber3 > UserNumber1)
            //{
            //    Console.WriteLine($"the max number equal {UserNumber3}");
            //}
            //else if (UserNumber3 == UserNumber1 && UserNumber3 > UserNumber2)
            //{
            //    Console.WriteLine($"the max number equal {UserNumber3}");
            //}
            //else
            //{
            //    Console.WriteLine("the three numbers are equal");
            //}
            #endregion
            #region problem 4
            //int UserNumber = Convert.ToInt32(Console.ReadLine());
            //if (UserNumber%2==0)
            //{
            //    Console.WriteLine("these number is even");
            //}
            //else
            //{
            //    Console.WriteLine("these number is odd");
            //}
            #endregion
            #region problem 5
            //string word = Console.ReadLine();
            //if (word != null)
            //{
            //    char letter = char.ToLower (word[0]);
            //    if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            //    {
            //        Console.WriteLine("Vowel");
            //    }
            //    else {
            //        Console.WriteLine("Consonant");
            //    }
            //}
            //else { Console.WriteLine("enter a valid word"); }
            #endregion
            #region problem 6
            //int UserNumber = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= UserNumber; i++)
            //{
            //    Console.WriteLine( i);
            //}
            #endregion
            #region problem 7
            //int UserNumber = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine(UserNumber * i);
            //}
            #endregion
            #region problem 8
            //int UserNumber = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i < UserNumber; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion
            #region problem 9
            //int Number1 = Convert.ToInt32(Console.ReadLine());
            //int Number2 = Convert.ToInt32(Console.ReadLine());
            //double result = Math.Pow(Number1 ,  Number2); 

            //    Console.WriteLine(result);


            #endregion
            #region problem 10
            int Subject01 = Convert.ToInt32(Console.ReadLine());
            int Subject02 = Convert.ToInt32(Console.ReadLine());
            int Subject03 = Convert.ToInt32(Console.ReadLine());
            int Subject04 = Convert.ToInt32(Console.ReadLine());
            int Subject05 = Convert.ToInt32(Console.ReadLine());

            float TotalMarks = (float)(Subject01 + Subject02 + Subject03 + Subject04 + Subject05);
            float AverageMarks = TotalMarks / 5;
            float Presentage = (TotalMarks / 500f) * 100;
            Console.WriteLine($"Total marks = {TotalMarks} /n  AverageMarks = {AverageMarks} /n Presentage = {Presentage}");

            #endregion


        }
    }
}
