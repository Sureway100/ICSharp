using System;
using System.Data.SqlTypes;
using System.Reflection;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("this does not input new line ");
            Console.Write("I will print on the same line.");
            Console.WriteLine("");

            Console.WriteLine("------------------------------------------------ 1");
            Console.WriteLine("Hello World!");
            Console.WriteLine("I am Learning C#");
            Console.WriteLine("It is awesome!");

            Console.WriteLine("------------------------------------------------ 2");
            string name = "david";
            char special = 'N';
            System.Console.WriteLine(name + " " + special);


            Console.WriteLine("------------------------------------------------- 3");
            const int myNum = 15;
            Console.WriteLine(myNum);


            Console.WriteLine("------------------------------------------------- 4");
            int x = 5;
            int y = 6;
            Console.WriteLine(x + y);


            Console.WriteLine("------------------------------------------------- 5");
            float f1 = 35e3F;
            double d1 = 12E4D;
            Console.WriteLine(f1);
            Console.WriteLine(d1);


            /*
             C# Type Casting
            Type casting is when you assign a value of one data type to another type.

            In C#, there are two types of casting:

            Implicit Casting(automatically) -converting a smaller type to a larger type size
            char -> int -> long -> float -> double

            Explicit Casting(manually) - converting a larger type to a smaller size type
            double -> float -> long -> int -> cha
            */


            /*
            Type Conversion Methods 
                It is also possible to convert data types explicitly by using built-in methods, 
                such as Convert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32(int) and Convert.ToInt64(long):
            */


            Console.WriteLine("-------------------------------------------------------------- 6");

            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));



            Console.WriteLine("------------------------------------------------------------------ 7");

            // Type your username and press enter
            Console.WriteLine("Enter username:");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string userName = Console.ReadLine();

            // Print the value of the variable (userName), which will display the input value
            Console.WriteLine("Username is: " + userName);


            Console.WriteLine("------------------------------------------------------------------ 8");

            string txt = "Hello World";
            Console.WriteLine(txt.ToUpper());   // Outputs "HELLO WORLD"
            Console.WriteLine(txt.ToLower());   // Outputs "hello world"
            string firstName = "John ";
            string lastName = "Doe";
            string names = string.Concat(firstName, lastName);
            Console.WriteLine(names);


            //String Interpolation
            //Another option of string concatenation, is string interpolation, which substitutes values of variables
            //into placeholders in a string.Note that you do not have to worry about spaces, like with concatenation:
            string firstName1 = "John";
            string lastName1 = "Doe";
            string name1 = $"My full name is: {firstName1} {lastName1}";
            Console.WriteLine(name1);





           // Another useful method is Substring(), which extracts the characters from a string, starting
           // from the specified character position/ index, and returns a new string.This method is often used together
           // with IndexOf() to get the specific character position:


            string nameb = "John Doe";

            // Location of the letter D
            int charPos = nameb.IndexOf("D");

            // Get last name
            string lastNameb = nameb.Substring(charPos);

            // Print the result
            Console.WriteLine(lastNameb);
        }
    }
}