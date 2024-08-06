namespace ConsoleApp1
{
     class Program
    {
        static void Main(string[] args)
        {
           /* Console.Write("Hello  \n");
            Console.WriteLine("Welcome to c#...");

            //to store a text value
            String name = "sandhya";
            Console.WriteLine(name);

            //to store a number
            int myNum = 15;
            Console.WriteLine(myNum);

            //to assign a new value to an existing variable
            int myNum1 = 15;
            myNum1 = 20;  //myNum is now 20
            Console.WriteLine(myNum1);

            //If you dont want others(or yourself) to overwrite existing values,u can add the constant keyword in front of the variable type.
            const int Mynum = 15;
            //Mynum = 20;
            Console.WriteLine(Mynum);

            //combine both text and a variable,use + character
            String name1 = "Reddy";
            Console.WriteLine("Sandhya" + name1);

            // + to add a variable to another variable
            String f1 = "Sandhya";
            String f2 = "Reddysana";
            String FN = f1 + f2;
            Console.WriteLine(FN);

            int x = 5;
            int y = 6;
            Console.WriteLine(x + y);

            //to declare more than one variable of the same type,use a comma separated list
            int x1 = 1, y1 = 2, z = 3;
            Console.WriteLine(x1 + y1 + z);

            // to assign the same value to multiple variables in one line
            int X, Y, Z;
            X = Y = Z = 10;
            Console.WriteLine(X + Y + Z);

            //The int data type can store whole numbers and it is preferred data type when we create variables with a numeric value.
            int m1 = 100000;
            Console.WriteLine(m1);

            //The long data type can store whole numbers and it should end the value with an L.
            long M2 = 15000000000000L;
            Console.WriteLine(M2);

            //float and double data types can store fractional numbers. The precision of float is only six or seven decimal digits, while double variables have a precision of about 15 digits. 
            float M3 = 5.75F;
            Console.WriteLine(M3);

            double M4 = 19.99D;
            Console.WriteLine(M4);

            //A boolean data type is declared with the bool keyword and can only take the values true or false.
            bool isCSharpFun = true;
            bool isFishTasty = false;
            Console.WriteLine(isCSharpFun);
            Console.WriteLine(isFishTasty);

            //The char data type is used to store a single character. The character must be surrounded by single quotes, like 'A' or 'c'.
            char myGrade = 'g';
            Console.WriteLine(myGrade);

            //The string data type is used to store a sequence of characters (text). String values must be surrounded by double quotes.
            string greeting = "hello world";
            Console.WriteLine(greeting);

            //Type Casting
            //Type casting is when you assign a value of one data type to another type.

            //Implicit casting is done automatically when passing a smaller size type to a larger size type.
            int s1 = 9;
            double s2 = s1;  //Automatic casting ,int to double
            Console.WriteLine(s1);
            Console.WriteLine(s2);

            //Explicit casting must be done manually by placing the type in parentheses in front of the value.
            double s3 = 9.78;
            int s4 = (int)s3;     //manual casting double to int
            Console.WriteLine(s3);
            Console.WriteLine(s4);

            //It is also possible to convert data types explicitly by using built-in methods, such as Convert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32 (int) and Convert.ToInt64 (long).
            int a1 = 10;
            double a2 = 5.25;
            bool a3 = true;

            Console.WriteLine(Convert.ToString(a1));  //convert int to string
            Console.WriteLine(Convert.ToDouble(a1));  //convert int to double 
            Console.WriteLine(Convert.ToInt32(a2));  //convert double to int 
            Console.WriteLine(Convert.ToString(a3));  //convert bool to string

            //You have already learned that Console.WriteLine() is used to output (print) values. Now we will use Console.ReadLine() to get user input.
            //Type ur username and press enter
            Console.WriteLine("Enter username");

            //create a string variable and get user input from the keyword and store it in the variable
            string userName = Console.ReadLine();

            //print the value of the variable(username), which will display the input value
            Console.WriteLine("username is:" + userName);

            //directly we cannot read by using explicit method to convert
            Console.WriteLine("Enter ur age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is:" + age);

            //operators are used to perform operations on variables and values
            //+ operator to add together two values
            int a = 100 + 50;
            Console.WriteLine(a);

            //+ operator to add together two values,and be used to add one value and one variable
            int sum1 = 100 + 50;
            int sum2 = sum1 + 150;
            int sum3 = sum2 + sum2;
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);

            //Assignment operator used to assign values to variables
            int s = 10;
            Console.WriteLine(s);

            int s5 = 10;
            s5 += 3;
            Console.WriteLine(s5);

            //comparison operator find true or false
            int c = 5;
            int d = 10;
            Console.WriteLine(c > d);

            //As with comparison operators, you can also test for True or False values with logical operators.
            int e = 5;
            Console.WriteLine(e > 3 && e < 10); // returns True because 5 is greater than 3 AND 5 is less than 10
            int f = 5;
            Console.WriteLine(f > 3 || f < 4); // returns True because one of the conditions are True (5 is greater than 3, but 5 is not less than 4)
            int g = 5;
            Console.WriteLine(!(g > 3 && g < 10)); // returns False because ! (not) is used to reverse the result

            //C# math class has many methods that allows you to perform mathematical tasks on numbers.
            //The Math.Max(x,y) method can be used to find the highest value of x and y.
            Math.Max(5, 20);
            Console.WriteLine(Math.Max(5, 20));

            //The Math.Min(x, y) method can be used to find the lowest value of of x and y.
            Math.Min(5, 10);
            Console.WriteLine(Math.Min(5, 10));

            //The Math.Sqrt(x) method returns the square root of x.
            Math.Sqrt(8);
            Console.WriteLine(Math.Sqrt(8));

            //The Math.Abs(x) method returns the absolute(positive) value of x.
            Math.Abs(-4.5);
            Console.WriteLine(Math.Abs(-4.5));

            //Math.Round() rounds a number to the nearest whole number.
            Math.Round(9.99);
            Console.WriteLine(Math.Round(9.99));

            //strings are used for storing text,A string variable contains a collection of characters surrounded by double quotes.
            //A string variable can contain many words, if you want.
            //In C# string is an object,which contain properties and methods that can perform certain operations on strings.
            string txt = "sandhyareddysana";
            Console.WriteLine("The length of the string is:" + txt.Length);
            string txt1 = "Hello World";
            Console.WriteLine(txt1.ToUpper());
            Console.WriteLine(txt1.ToLower());

            //The + operator can be used between strings to combine them. This is called concatenation.
            string firstName = "John ";
            string lastName = "Doe";
            string name2 = firstName + lastName;
            Console.WriteLine(name2);

            //you can also use the string.concat() method to concatenate two strings.
            string FirstName = "John ";
            string LastName = "Doe";
            string Name = string.Concat(FirstName, LastName);
            Console.WriteLine(Name);

            //If you add two numbers, the result will be a number.
            int e1 = 10;
            int r1 = 30;
            int z1 = e1 + r1;
            Console.WriteLine(z1);

            //If you ad two strings, the result will be a string concatenation.
            string e2 = "10";
            string r2 = "30";
            string z2 = e2 + r2;
            Console.WriteLine(z2); //z2 will be 1030 (a string)

            //Interpolation is nothing but, which substitutes the values of variables into placeholders in a string.
            string d1 = "sanjana";
            string d2 = "reddy";
            string D = $"full name is: {d1}{d2}";
            Console.WriteLine(D);

            //Access characters is nothing but referring to its index number inside square brackers[].
            string mystring = "Hello";
            Console.WriteLine(mystring[0]); //output "H"

            //string index starts with 0.
            string mystring1 = "Hello";
            Console.WriteLine(mystring1[1]); //outputs "e"

            //to find the index position of a specific character in a string.
            string mystring2 = "Hello";
            Console.WriteLine(mystring2.IndexOf("o"));

            //full name
            string Name1 = "Sanjana Reddy";

            //Location of the letter r
            int charPos = Name1.IndexOf("R");

            //get last name
            string lastname = Name1.Substring(charPos);

            //Print the result
            Console.WriteLine(lastname);

            //The sequence \" inserts a double quote in a string
            string txt2 = "we are the so-called \"vikings\" from the north.";
            Console.WriteLine(txt2);
            //the sequence \' inserts a single quote in a string
            string txt3 = "It\'s alright";
            Console.WriteLine(txt3);
            //the sequence \\ inserts a single backslash in a string
            string txt4 = "The character \\ is called backslash.";

            //\n is a new line.
            //\t is a new tab.
            //\b is a backspace.

            //boolean data type is declared to the bool data type,which can take the value true or false.
            bool isCSharpFun1 = true;
            bool isFishTasty1 = false;
            Console.WriteLine(isCSharpFun1);   // Outputs True
            Console.WriteLine(isFishTasty1);   // Outputs False*/


            //If statements
            // if stmt is to specify the block of code to be executed when the given condition is true.
            int w = 20;
            int q = 10;
            if (w > q)
            {
                Console.WriteLine("w is greater than q");
            }

            //else stmt is to specify the block of code to be executed when the given condition is false.
            int time = 20;
            if (time > 20)
            {
                Console.WriteLine("good morning");
            }
            else
            {
                Console.WriteLine("good evening");
            }

            //else if stmt to specify a new condition if the first condition is false.
            int Time = 22;
            if (Time < 10)
            {
                Console.WriteLine("given value is false");
            }
            else if(Time < 30)
            {
                Console.WriteLine("given value is true");
            }
            else
            {
                Console.WriteLine("invalid");
            }

            //short hand if
            int TIME = 30;
            string result = (TIME<=30) ? "good day." : "good evening";
            Console.WriteLine(result);

            //switch stmt is to select one of many code blocks to be executed.
            //the switch expression is evaluated once.
            //the value of the expression is compared to the values of each case.
            //if there is a match,the associated block of code is executed.
            int day = 5;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }

            //break keyword,it breaks out of the switch block.
            //this will stop the execution of more code and case testing inside the block.
            //break can save a lot of execution time.

            //default keyword is optional specifies some code to run, if there is no case match.
            int day2 = 4;
            switch (day2)
            {
                case 1:
                    Console.WriteLine("Today is Sunday");
                    break;
                case 2:
                    Console.WriteLine("Today is Monday");
                    break;
                default:
                    Console.WriteLine("Looking forward to the weekend");
                    break;
            }











































































































































        }
    }
}
