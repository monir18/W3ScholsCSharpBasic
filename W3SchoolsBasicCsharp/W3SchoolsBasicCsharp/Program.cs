using System;

//Syntax
namespace W3SchoolsBasicCsharp
{
	class Program
	{
		public static void Main(string[] args)
		{
            // C# Output

            //Console.WriteLine("Hello World");

            //Console.WriteLine("I am learning C#");
            //Console.WriteLine("It is awesome");
            ////You can also output numbers, and perform mathematical calculations: // This is a single line comment
            //Console.WriteLine(3 + 3);

            //         // The Write Method

            //         /*There is also a Write() method, which is similar to WriteLine().
            //The only difference is that it does not insert a new line at the end of the output: (Multi-Line Comments)
            //*/
            //         Console.Write("Hello World!");
            //Console.WriteLine("I will print on the same line");

            /* End of output */

            /* Variable */

            //string name = "John";
            //Console.WriteLine(name);

            //int myNum = 15;
            //Console.WriteLine(myNum);

            //int num;
            //num = 22;
            //Console.WriteLine(num);

            ////Note that if you assign a new value to an existing variable, it will overwrite the previous value:

            //int number = 11;
            //number = 30;
            //Console.WriteLine(number);

            ////A demonstration of how to declare variables of other types:

            //int number1 = 5;
            //Console.WriteLine(number1);

            //double myDoubleNum = 5.99D;
            //Console.WriteLine(myDoubleNum);

            //char myLetter = 'A';
            //Console.WriteLine(myLetter);

            //bool myBool = false;
            //Console.WriteLine(myBool);

            //string myText = "Hello World!";
            //Console.WriteLine(myText);

            /* End of Variable */



            /* C# Constants */

            //const int number2 = 10;
            //number2 = 40; //Error
            //Console.WriteLine(number2);	

            /* End of C# Constants */

            /* Display Variables */

            //string name = "John";
            //Console.WriteLine("Hello "+name);

            ////You can also use the + character to add a variable to another variable:

            //string firstName = "John ";
            //string lastName = "Doe";
            //string fullName = firstName+ lastName;
            //Console.WriteLine(fullName);

            ////For numeric values, the + character works as a mathematical operator (notice that we use int (integer) variables here):
            //int x = 5;
            //int y = 6;
            //Console.WriteLine(x + y); //print the value of x + y

            /*From the example above, you can expect:

            x stores the value 5
            y stores the value 6
            Then we use the WriteLine() method to display the value of x + y, which is 11
            */

            /* End of Display Variables */

            /* C# Multiple Variables */

            //int x = 5, y = 6, z = 50;
            //Console.WriteLine(x + y + z);

            //// You can also assign the same value to multiple variables in one line:

            //int a, b, c;
            //x=y=z=50;
            //Console.WriteLine(x + y + z);

            /* End of C# Multiple Variables */

            /* C# Identifiers */

            //Good
            //int minutesPerHour = 60;

            //// Ok, but not so easy to understand what m actually is 

            //int m = 60;

            //Console.WriteLine(minutesPerHour);
            //Console.WriteLine(m);


            /* End of C# Identifiers */

        }
    }
}