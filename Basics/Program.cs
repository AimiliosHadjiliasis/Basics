using System;
using System.IO; //For file handling exercies
using System.Text;

namespace Basics
{
    class Program
    {
        static void Exercise0()
        {
            //  Print Hello World!
            Console.WriteLine("Hello World!");
        }

        static void Exercise1()
        {
            // Write a C# Sharp program to print Hello and your name in a separate line
            Console.WriteLine("Give name");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
        }

        static int summ(int num1, int num2)
        {
            int sum;
            sum = num1 + num2;
            return sum;
        }

        static void Exercise2()
        {
            // Write a C# Sharp program to print the sum of two numbers.
            Console.WriteLine("Give num 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give num 2: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum = " + summ(num1 , num2));
        }

        static void Exercise3()
        {
            //Write a C# Sharp program to print the result of dividing two numbers.
            Console.WriteLine("Give num 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give num 2: ");
            int num2 = int.Parse(Console.ReadLine());
            double div = num1 / num2;
            Console.WriteLine("Division = " + div);
        }

        static void Exercise4()
        {
            //Write a C# Sharp program to swap two numbers
            Console.Write("Give num 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Give num 2: ");
            int num2 = int.Parse(Console.ReadLine());
            int tmp = num1;
            num1 = num2;
            num2 = tmp;
            Console.WriteLine("After swap:");
            Console.WriteLine("Num1: " + num1 + " // " + "Num2: " + num2);
        }

        static void Exercise5()
        {
            //Write a C# Sharp program to print the output of multiplication of 
            //three numbers which will be entered by the user.
            Console.Write("Give number 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Give number 2: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Give number 3: ");
            int num3 = int.Parse(Console.ReadLine());
            int Mul = num1 * num2 * num3;
            Console.Write("Mult: " + Mul);
        }

        static void Exercise6()
        {
            //Write a C# Sharp program to print on screen the output of adding, 
            //subtracting, multiplying and dividing of two numbers 
            //which will be entered by the user

            Console.Write("Give number 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Give number 2: ");
            int num2 = int.Parse(Console.ReadLine());
            int add = num1 + num2;
            int sub = num1 - num2;
            int mul = num1 * num2;
            double div = num1 / num2;
            Console.WriteLine("Addition: " + num1 + " + " + num2 + " = " + add);
            Console.WriteLine("Substruction: " + num1 + " - " + num2 + " = " + sub);
            Console.WriteLine("Multiplication: " + num1 + " * " + num2 + " = " + mul);
            Console.WriteLine("Division: " + num1 + " / " + num2 + " = " + div);
        }

        static void Exercise7()
        {
            //  Write a C# Sharp program that takes a number as input 
            //  and print its multiplication table.
            Console.Write("Give a number:");
            int num = int.Parse(Console.ReadLine());
            int res;

            for (int i = 0; i <= 10; i++)
            {
                res = num * i;
                Console.WriteLine(num + " * " + i + " = " + res);
            }
        }

        static void Exercise8()
        {
            //  Write a C# Sharp program that takes four numbers 
            //  as input to calculate and print the average.
            Console.Write("Give 1st number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Give 2nd number:");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Give 3rd number:");
            int num3 = int.Parse(Console.ReadLine());
            Console.Write("Give 4th number:");
            int num4 = int.Parse(Console.ReadLine());
            int avg = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine("Average: " + avg);
        }

        static void Exercise9()
        {
            //  Print a cube of *
            for (int i = 0; i < 5; i++)
            {
                for (int j  = 0; j< 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
        }

        static void Exercise10()
        {
            //  Print asteric triangle
            Console.Write("Give number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static string remove_char(string str,int n)
        {
            return str.Remove(n, 1);
        }

        static void Exercise11()
        {
            //  Write a C# program remove specified a character from a non-empty 
            //  string using index of a character.
            Console.WriteLine("Normal World: Halloumi");
            Console.Write("Remove 4th character:" + remove_char("Halloumi", 4));
        }

        static void Exercise12()
        {
            //  Write a program that reverse a string
            Console.Write("Give string: ");
            string str = Console.ReadLine();
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(charArray);
        }

        static void Exercise13()
        {
            //  Write a C# program to convert a given string into lowercase
            string str = "AFROZA";
            Console.WriteLine("Normal: " + str);
            Console.WriteLine("To Lower: " + str.ToLower());
        }

        static void Exercise14()
        {
            //  Write a C# Sharp program that takes three letters as 
            //  input and display them in reverse order 
            Console.Write("Give string input 1: ");
            string str1 = Console.ReadLine();
            Console.Write("Give string input 2: ");
            string str2 = Console.ReadLine();
            Console.Write("Give string input 3: ");
            string str3 = Console.ReadLine();

            Console.WriteLine("{0} {1} {2}", str3,str2,str1);
        }

        static void Exercise15()
        {
            //  Write a C# Sharp program that takes a number and a width 
            //  also a number, as input and then displays a triangle 
            //  of that width, using that number. 
            Console.WriteLine("Give input:");
            char input = char.Parse(Console.ReadLine());
            Console.WriteLine("Give width:");
            int width = int.Parse(Console.ReadLine());

            for (int i = width; i >= 1; --i)
            {
                for (int j = 1; j <= i; ++j)
                {
                    Console.Write(input);
                }
                Console.WriteLine();
            }
        }
       
        static void Exercise16()
        {
            //  Write a C# Sharp program that takes the radius of a 
            //  circle as input and calculate the perimeter and area of the circle. 
            Console.WriteLine("Give Perimeter of circle: ");
            int rad = int.Parse(Console.ReadLine());
            int diam = rad * 2;
            double per = diam * Math.PI;
            double area = Math.PI * (rad * rad);
            Console.WriteLine("Perimeter: " + per);
            Console.WriteLine("Area: " + area);
        }

        static void Exercise17()
        {
            //  Write a C# Sharp program to display certain values of 
            //  the function x = y2 + 2y + 1 (using integer numbers 
            //  for y , ranging from -5 to +5)
            int x, y;

            Console.WriteLine("x = y² - 2y +1");
            Console.WriteLine();

            for (y = -5;  y< 5; y++)
            {
                x = y * y - 2 * y + 1;
                Console.WriteLine("y = {0} ; x=({0})² - 2*({0}) +1 = {1}", y, x);
            }
        }

        static void Exercise18()
        {
            //  Write a C# Sharp program to accept two integers 
            //  and check whether they are equal or not
            Console.WriteLine("Give number 1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give number 2");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
                Console.WriteLine("Numbers are Equal!");
            else
                Console.WriteLine("Numbers are NOT Equal!");
        }

        static void Exercise19()
        {
            //  Write a C# Sharp program to check whether a given number is even or odd.
            Console.Write("Give a number: ");
            double num = double.Parse(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine("The number is EVEN!");
            else
                Console.WriteLine("The number is ODD!");
        }

        static void Exercise20()
        {
            //  Write a C# Sharp program to check whether a given number is positive or negative.
            Console.Write("Give a number: ");
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
                Console.WriteLine("The number is Possitive!");
            else if (num < 0)
                Console.WriteLine("The number is Negative!");
            else
                Console.WriteLine("The number is equal to ZERO!");
        }

        static void Exercise21()
        {
            //  Write a program that takes the height of a person and
            //  prints in which category it belongs.
            Console.Write("Give the height of a person in CM: ");
            int height = int.Parse(Console.ReadLine());
            while (height >= 1)
            {
                if (height < 150)
                    Console.WriteLine("Person is Dawrf!");
                else if (height >= 150 && height <= 165)
                    Console.WriteLine("Person has average height!");
                else if (height >= 165 && height <= 195)
                    Console.WriteLine("Person is Taller!");
                else
                    Console.WriteLine("Ubnormal height!");

                Console.Write("Give the height of a person in CM: ");
                height = int.Parse(Console.ReadLine());
            }
        }

        static void Exercise22()
        {
            //  Write a C# Sharp program that takes a character as input 
            //  and check the input (lowercase) is a vowel, a digit, or any other symbol.
            Console.Write("Give char:");
            char c;
            c = Convert.ToChar(Console.ReadLine());

            if (c == 'a' || c == 'e' || c == 'i' || c == 'u' || c == 'o')
                Console.WriteLine("Character is vowel");
            else if (c >= '1' && c <= '9')
                Console.WriteLine("Character is digital");
            else
                Console.WriteLine("Another symbol");
        }

        static void Exercise23()
        {
            //  Write a program in C# Sharp to display the first 10 natural numbers. 
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void Exercise24()
        {
            //  Write a C# Sharp program to find the sum of first 10 natural numbers. 
            int sum = 0;
            for (int i = 0; i <= 10; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("Sum of 10 first Natural number is: " + sum);
        }

        static void Exercise25()
        {
            //  Write a program in C# Sharp to display n terms of 
            //  natural number and their sum. 
            Console.Write("Give a number input: ");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            Console.Write("Numbers: ");
            for (int i = 0; i <= num; i++)
            {
                Console.Write(i + " ");
                sum = sum + i;
            }
            Console.WriteLine();
            Console.WriteLine("The sum is: " + sum);
        }

        static void Exercise26()
        {
            //  Write a program in C# Sharp to display the 
            //  multiplication table vertically from 1 to n.
            Console.Write("Give number: ");
            int num = int.Parse(Console.ReadLine());

            int mult =1;

            for (int i = 0; i <= 10; i++)
            {
                mult = i * num;
                Console.WriteLine(num + " * " + i + " = " + mult);
            }
        }

        static void Exercise27()
        {
            // Write a program in C# Sharp to display the 
            // cube of the number upto given an integer.
            int cube;
            for (int i = 1; i < 6; i++)
            {
                cube = i * i * i;
                Console.WriteLine("Cube of " + i + " is: " + cube);
            }

        }

        static void Exercise28()
        {
            //  Write a program in C# Sharp to store elements in an array and print it.
            int[] myArray = new int[10];
            for (int i = 0; i < 10; i++)
            {
                myArray[i] = i * 2;
                Console.WriteLine("Element at possition " + i + " is " + myArray[i]);
            }
        }

        static void Exercise29()
        {
            //  Write a program in C# Sharp to read n number 
            //  of values in an array and display it in reverse order.
            int[] myArray = new int[10];
            int[] temp = myArray;
            for (int i = 0; i < 10; i++)
            {
                myArray[i] = i * 2;
            }
            Console.Write("Array: ");
            for (int j = 0; j < 10; j++)
            {
                Console.Write(myArray[j] + "    ");
            }
            Console.WriteLine();
            Console.Write("Reversed: ");
            Array.Reverse(temp);
            for (int k = 0; k < 10; k++)
            {
                Console.Write(myArray[k] + "    ");
            }
        }

        static void Exercise30()
        {
            //  Write a program in C# Sharp to find the sum of 
            //  all elements of the array
            int[] myArray = new int[10];
            for (int i = 0; i < 10; i++)
            {
                myArray[i] = i;
            }
            Console.Write("Array: ");
            for (int j = 0; j < 10; j++)
            {
                Console.Write(myArray[j] + "    ");
            }
            Console.WriteLine();

            int sum = 0;
            for (int k = 0; k < 10; k++)
            {
                sum = sum + myArray[k];
            }

            Console.WriteLine("Sum: " + sum);
        }

        static void Exercise31()
        {
            //  Write a program in C# Sharp to copy the elements 
            //  one array into another array. 
            //Initialisation
            int[] myArray = new int[10];
            int[] myCopyArray = new int[10];

            //Populate 1st array
            for (int i = 0; i < 10; i++)
            {
                myArray[i] = i;
            }
            //Print content of 1st array
            Console.Write("Array: ");
            for (int j = 0; j < 10; j++)
            {
                Console.Write(myArray[j] + "    ");
            }
            //Copy content of first array to the second array
            Console.WriteLine();
            for (int k = 0; k < 10; k++)
            {
                myCopyArray[k] = myArray[k];
            }
            //Print Copy array
            Console.Write("Reversed: ");
            for (int l = 0; l < 10; l++)
            {
                Console.Write(myCopyArray[l] + "    ");
            }
        }

        static void Exercise32()
        {
            //  Write a program in C# Sharp to input a string and print it. 
            Console.Write("Give string input: ");
            string str = Console.ReadLine();
            Console.Write("Your input is: " + str);
        }

        static void Exercise33()
        {
            //  Write a program in C# Sharp to find the length of 
            //  a string without using library function.
            Console.Write("Give input: ");
            string str = Console.ReadLine();
            int len=0;
            foreach (char c in str)
            {
                len = len + 1;
            }
            Console.WriteLine("Length of string input: " + len);
        }
        static void Exercise34()
        {
            //   Write a program in C# Sharp to separate the individual characters from a string.
            Console.Write("Give input: ");
            string str = Console.ReadLine();
            int index = 0;
            while (index <= str.Length-1)
            {
                Console.Write("{0} ", str[index]);
                index++;
            }
            Console.WriteLine();
        }

        static void Exercise35()
        {
            //  Write a program in C# Sharp to print individual characters 
            //  of the string in reverse order
            Console.Write("Give input: ");
            string str = Console.ReadLine();
            int index = str.Length-1;
            while (index >= 0)
            {
                Console.Write("{0} ", str[index]);
                index--;
            }
            Console.WriteLine();
        }

        static void Exercise36()
        {
            // Write a program in C# Sharp to count the total number of words in a string
            Console.Write("Give input: ");
            string str = Console.ReadLine();
            int len = str.Length;
            Console.WriteLine("Length:" + len);
        }
        static void Exercise37()
        {
            //  Write a program in C# Sharp to compare two string 
            //  without using string library functions.
            Console.Write("Give 1st input: ");
            string str1 = Console.ReadLine();
            Console.Write("Give 2nd input: ");
            string str2 = Console.ReadLine();

            int len1 = str1.Length;
            int len2 = str2.Length;

            if (len1 == len2)
                Console.WriteLine("The 2 strings have the same size!");
            else
                Console.WriteLine("The 2 strings have NOT the same size!");
        }
        static void Exercise38()
        {
            //  Write a C# Sharp program to check whether a given 
            //  substring is present in the given string
            bool exist;
            Console.Write("Give string: ");
            string str = Console.ReadLine();
            Console.Write("Give string: ");
            string substr = Console.ReadLine();
            //Check:
            exist = str.Contains(substr);
            if (exist)
                Console.WriteLine("Substring exist in the string!");
            else
                Console.WriteLine("Substring do not exist in the string!");
        }

        static void Exercise39()
        {
            //  Write a program in C# Sharp to search the position 
            //  of a substring within a string
            Console.Write("Give string: ");
            string str = Console.ReadLine();
            Console.Write("Give string: ");
            string substr = Console.ReadLine();

            int index = str.IndexOf(substr);
            if (index < 0)
                Console.WriteLine("Substring not found");
            else
                Console.WriteLine("Substring '{0}' in '{1}' found at position {2}", substr, str, index);
        }

        //Date and time in C#
        static void Exercise40()
        {
            //  Write a C# Sharp program to extract the Date property 
            //  and display the DateTime value in the formatted output.
            DateTime dt1 = new DateTime(2020, 10, 3, 12, 00, 00);
            Console.WriteLine("Complete date: " + dt1.ToString());

            // Get date-only portion of date, without its time.
            DateTime dateOnly = dt1.Date;

            Console.WriteLine("Short Date: " + dateOnly.ToString("d"));

            Console.WriteLine("Display date using 24-hour clock format:");

            Console.WriteLine(dateOnly.ToString("g"));
            Console.WriteLine(dateOnly.ToString("MM/dd/yyyy HH:mm"));
        }
        //Basic Algorithms:
        static void Exercise41()
        {
            //  Write a C# Sharp program to compute the sum of the two given integer values. 
            //  If the two values are the same, then return triple their sum
            Console.Write("Give num1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Give num1: ");
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 + num2;
            if (num1 == num2)
                Console.WriteLine("Sum(x3): " + sum * 3);
            else
                Console.WriteLine("Sum: " + sum);
        }
        
        static void Exercise42()
        {
            //  Write a C# Sharp program that calculates the absolute difference between n and 51
            Console.Write("Give number: ");
            int num = int.Parse(Console.ReadLine());
            int diff = num - 51;
            int absDif = Math.Abs(diff);
            Console.WriteLine("The absolute difference is: " + absDif);
        }

        static void Exercise43()
        {
            //  Write a C# Sharp program to check two given integers, 
            //  and return true if one of them is 30 or if their sum is 30
            Console.WriteLine("Give number 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give number 1: ");
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 + num2;
            bool check = false;
            if (num1 == 30 || num2 == 30 || sum == 30)
            {
                check = true;
                Console.WriteLine(check);
            }
            else
                Console.WriteLine(check);
        }
        static void Exercise44()
        {
            //  Write a C# Sharp program to check a given integer and 
            //  return true if it is within 10 of 100 or 200
            Console.Write("Give a number: ");
            bool check = false;
            int num = int.Parse(Console.ReadLine());
            if (num >= 10 && num <= 100 || num == 200)
            { 
                check = true;
                Console.WriteLine(check);
            }
            else
                Console.WriteLine(check);
        }
        static void Exercise45()
        {
            //  Write a C# Sharp program to create a new string where 'if' is added to the 
            //  front of a given string. If the string already begins with 'if', 
            //  return the string unchanged
            Console.Write("Give string:");
            string str = Console.ReadLine();

            if (str.Length > 2 && str.Substring(0,2).Equals("if"))
            {
                Console.WriteLine("The input string " + str + " begins with if!");
            }
            else
            {
                Console.WriteLine("The input string: " + str +" do not start with 'if'!!");
                Console.WriteLine("The input string with if statment in front will be: if " + str);
            }
        }
        static void Exercise46()
        {
            //  Write a C# Sharp program to check if a given positive number 
            //  is a multiple of 3 or a multiple of 7.
            Console.Write("Give number: ");
            int num = int.Parse(Console.ReadLine());
            bool check=false;
            if (num % 3 == 0 || num % 7 == 0)
            {
                check = true;
                Console.WriteLine(check);
            }
            else
                Console.WriteLine(check);
        }
        static void Exercise47()
        {
            //  Write a C# Sharp program to check if a given string starts with 'C#' or not.
            Console.Write("Give a string: ");
            string str = Console.ReadLine();
            bool check = false;
            if (str.Length >=2 && str.Substring(0,2).Equals("C#"))
            {
                check = true;
                Console.WriteLine(check);
            }
            else
            {
                Console.WriteLine(check);
            }
        }
        static void Exercise48()
        {
            //  Write a C# Sharp program to check which number nearest to the value 100 among 
            //  two given integers. Return 0 if the two numbers are equal

            //Input:
            Console.Write("Give number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Give number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Give number: ");
            int num3 = int.Parse(Console.ReadLine());

            //Calculate the difference
            int dif1 = 100 - num1;
            int dif2 = 100 - num2;
            int dif3 = 100 - num3;

            //Check for the closest to 100
            int min = dif1;
            if (dif2 < dif1)
                min = dif2;
            if (dif3 < dif2 && dif3 < dif2)
                min = dif3;

            //Presentation:
            if (num1 == num2 || num1 == num3 || num2 == num3)
                Console.WriteLine("0");
            else if (min==dif1)
                Console.WriteLine("The closest number to 100 is" + num1);
            else if (min==dif2)
                Console.WriteLine("The closest number to 100 is" + num2);
            else if (min==dif3)
                Console.WriteLine("The closest number to 100 is" + num3); 
        }

        static void Exercise49()
        {
            //  Write a C# Sharp program to check a specified number is 
            //  present in a given array of integers.
            int[] myArray = { 5, 6, 7, 8, 10, 5, 8, 18 };
            Console.Write("Give a number: ");
            int num = int.Parse(Console.ReadLine());
            bool flag=false;
            int counter = 0;

            //Check:
            for (int i = 0; i < myArray.Length-1; i++)
            {
                if (num == myArray[i])
                {
                    flag = true;
                    
                    break;
                }
                counter++;
            }

            //Presentation:
            if (flag==true)
                Console.WriteLine("Number found! At possition: " + counter);
            else
                Console.WriteLine("Number not found!");
        }

        //File handling:
        static void Exercise50()
        {
            //  Write a program in C# Sharp to create a blank file in the disk newly. 
            string fileName = @"C:\Users\Admin\Desktop\Basics\mytest.txt";
            try
            {
                Console.Write("\n\n Create a file named mytest.txt in the disk :\n");
                Console.Write("------------------------------------------------\n");
                // Create the file.
                using (FileStream fileStr = File.Create(fileName))
                {
                    Console.WriteLine(" A file created with name mytest.txt\n\n");
                }
            }
            catch (Exception MyExcep)
            {
                Console.WriteLine(MyExcep.ToString());
            }
        }
        static void Exercise51()
        {
            //  Write a program in C# Sharp to remove a file from the disk
            string fileName = @"C:\Users\Admin\Desktop\Basics\mytest.txt";
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
                Console.WriteLine("File at location: " + fileName + '\n' + " exists and is deleted successfully! ");
            }
            else
            {
                Console.WriteLine("File does not exist!");
            }
        }
        static void Exercise52()
        {
            //  Write a program in C# Sharp to create a blank file in the 
            //  disk if the same file already exists.
            string fileName = @"C:\Users\Admin\Desktop\Basics\mytest.txt";
            try
            {
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
                using (FileStream fs = File.Create(fileName))
                {
                    Console.WriteLine("File created!");
                }
            }
            catch (Exception myException)
            {
                Console.WriteLine("Error:" + myException.Message);
            }
        }
        static void Exercise53()
        {
            //   Write a program in C# Sharp to create a file and add some text
            string fileName = @"C:\Users\Admin\Desktop\Basics\mytest.txt";
            try
            {
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
                using (StreamWriter sw = File.CreateText(fileName))
                {
                    sw.WriteLine("Hello World!");
                    Console.WriteLine("File was created and writting is done Successfully!");
                }
            }
            catch (Exception myException)
            {
                Console.WriteLine("Error:" + myException.Message);
            }
        }
        static void Exercise54()
        {
            //  Write a program in C# Sharp to create a file with text and read the file.
            string fileName = @"C:\Users\Admin\Desktop\Basics\mytest.txt";
            try
            {
                //If exist then delete
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
                //Create and write
                using (StreamWriter sw = File.CreateText(fileName))
                {
                    sw.WriteLine("Hello World!");
                    sw.WriteLine("Hello World 2!");
                    sw.WriteLine("Hello World 3!");
                    Console.WriteLine("File was created and writting is done Successfully!");
                }
                //Read:
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    Console.WriteLine("Here is the text:");
                    while ((s =sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception myException)
            {
                Console.WriteLine("Error:" + myException.Message);
            }
        }
        static void Exercise55()
        {
            //  Write a program in C# Sharp to create a file and 
            //  write an array of strings to the file.

            //Create stream
            string fileName = @"C:\Users\Admin\Desktop\Basics\mytest.txt";

            //if exist then delete
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            //Get number of lines:
            Console.WriteLine("Give number of lines:");
            int n = int.Parse(Console.ReadLine());

            //Read from console and add to file:
            string[] arrayLines = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Give string line: ");
                arrayLines[i] = Console.ReadLine();
            }
            System.IO.File.WriteAllLines(fileName, arrayLines); // Write to file

            //Read file:
            using (StreamReader sr = File.OpenText(fileName))
            {
                string s = "";
                Console.WriteLine("Here is the text:");
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine();
            }
        }

        /**************************************************/
        //             EXERCISES IN STRUCTURES:
        /**************************************************/
        struct Node
        {
            public int x;
            public int y;
        }

        static void Exercise56()
        {
            //  Write a program in C# Sharp to declare a simple structure.
            Node nd1;
            nd1.x = 15;
            nd1.y = 20;
            Console.WriteLine("The data of Node 1 are:");
            Console.WriteLine("Node 1 x value is: " + nd1.x);
            Console.WriteLine("Node 1 y value is: " + nd1.y);
        }

        static void Exercise57()
        {
            //  Write a program in C# Sharp to declare a simple 
            //  structure and use of static fields inside a struct.
            Node nd1;
            nd1.x = 15;
            nd1.y = 20;
            Console.WriteLine("The data of Node 1 are:");
            Console.WriteLine("Node 1 x value is: " + nd1.x);
            Console.WriteLine("Node 1 y value is: " + nd1.y);
            int sum = nd1.x + nd1.y;
            Console.WriteLine("Node 1, sum of x and y values is: " + sum);
        }

        struct Address
        {
            public string address;
        }
        struct Employee
        {
            public string name;
            public int age;
            public Address address;
        }

        static void Exercise58()
        {
            //  Write a program in C# Sharp to create a nested struct to 
            //  store two data for an employee in an array.
            int total = 2;
            string addr;
            Employee[] emp = new Employee[total];

            for (int i = 0; i < total ; i++)
            {
                Console.Write("Give the name of employee: ");
                emp[i].name = Console.ReadLine();
                Console.Write("Give the age of employee: ");
                emp[i].age = int.Parse(Console.ReadLine());
                Console.Write("Give address: ");
                addr = Convert.ToString(Console.ReadLine());
                emp[i].address.address = addr;
            }

            Console.WriteLine();
            Console.WriteLine("Your inputs:");
            Console.WriteLine("---------------");

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine("Employee " + i + " Name:" + emp[i].name);
                Console.WriteLine("Employee " + i + " Age:" +emp[i].age);
                Console.WriteLine("Employee " + i + " Addreess:" +emp[i].address);
            }
        }

        struct NewClass
        {
            public int x;
            public int y;
        }
        struct NewStruct
        {
            public int x;
            public int y;
        }

        static void Exercise59()
        {
            //  Write a program in C# Sharp to create a structure 
            //  and Assign the Value and call it.
            NewClass nc1 = new NewClass();
            nc1.x = 15;
            nc1.y = 20;
            NewClass nc2 = new NewClass();
            nc2.x = 25;
            nc2.y = 30;
            NewStruct ns1 = new NewStruct();
            ns1.x = 1;
            ns1.y = 2;
            Console.WriteLine("Assign Class: x:{0}, y:{1} \n\n", nc1.x, nc1.y);
            Console.WriteLine("Assign Class: x:{0}, y:{1} \n\n", nc2.x, nc2.y);
            Console.WriteLine("Assign Struct: x:{0}, y:{1} \n\n", ns1.x, ns1.y);
        }

        struct newStruct
        {
            private int num;
            public int n
            {
                //Getter:
                get { return num; }
                //Setter:
                set
                {
                    if (value < 50)
                        num = value;
                    else
                        num = 66;
                }

            }
            //Function:
            public void clsMethod()
            {
                Console.WriteLine("\nThe stored value is: {0}\n", num);
            }
        }

        static void Exercise60()
        {
            //  Write a program in C# Sharp to declares a struct with a property, 
            //  a method, and a private field.
            Console.Write("\n\nDeclares a struct with a property, a method, and a private field :\n");
            Console.Write("----------------------------------------------------------------------\n");
            newStruct myInstance = new newStruct();
            myInstance.n = 55;
            myInstance.clsMethod();
        }

        public struct myNewStruct
        {
            public int x, y;
            public myNewStruct(int pointX, int pointY)
            {
                x = pointX;
                y = pointY;
            }
        }


        static void Exercise61()
        {
            //  Write a program in C# Sharp to demonstrates struct initialization 
            //  using both default and parameterized constructors.
            myNewStruct st1 = new myNewStruct();
            st1.x = 15;
            st1.y = 20;
            myNewStruct st2 = new myNewStruct(30, 40);

            Console.WriteLine("Struct 1: x value: {0},  y value: {1}", st1.x, st1.y);
            Console.WriteLine("Struct 2: x value: {0},  y value: {1}", st2.x, st2.y);
        }

        static void Main(string[] args)
        {
            //Exercise0();
            //Exercise1();
            //Exercise2();
            //Exercise3();
            //Exercise4();
            //Exercise5();
            //Exercise6();
            //Exercise7();
            //Exercise8();
            //Exercise9();
            //Exercise10();
            //Exercise11();
            //Exercise12();
            //Exercise13();
            //Exercise14();
            //Exercise15();
            //Exercise16();
            //Exercise17();
            //Exercise18();
            //Exercise19();
            //Exercise20();
            //Exercise21();
            //Exercise22();
            //Exercise23();
            //Exercise24();
            //Exercise25();
            //Exercise26();
            //Exercise27();
            //Exercise28();
            //Exercise29();
            //Exercise30();
            //Exercise31();
            //Exercise32();
            //Exercise33();
            //Exercise34();
            //Exercise35();
            //Exercise36();
            //Exercise37();
            //Exercise38();
            //Exercise39();
            //Exercise40();
            //Exercise41();
            //Exercise42();
            //Exercise43();
            //Exercise44();
            //Exercise45();
            //Exercise46();
            //Exercise47();
            //Exercise48();
            //Exercise49();
            //Exercise50();
            //Exercise51();
            //Exercise52();
            //Exercise53();
            //Exercise54();
            //Exercise55();
            //Exercise56();
            //Exercise57();
            //Exercise58();
            //Exercise59();
            //Exercise60();
            //Exercise61();



            Console.ReadLine();
        }
    }
}
