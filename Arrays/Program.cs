namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//arrays are used to store multiple values in a single variable,instead of declaring separate variables for each value.
            //array define the variable type with square brackets. 
            string[] cars = { "volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(cars);

            //we can also find array element by using index number.
            string[] cars1 = { "volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(cars1[0]);   //output volvo

            //we can change array element, refer to the index number
            string[] cars2 = { "volvo", "BMW", "Ford", "Mazda" };
            cars2[3] = "Duster";
            Console.WriteLine(cars2[3]);  //output is duster instead of ford.

            //we can find how many elements an array has,using length property.
            string[] car = { "volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(car.Length);  //output is 4

            //loops for an array
            //we can use for loop, find the length property how many times the loop should run.
            string[] car1 = { "volvo", "BMW", "Ford", "Mazda" };
            for (int i = 0; i < car1.Length; i++)
            {
                Console.WriteLine(car1[i]);
            }

            //foreach loop is used to exclusively to loop through elements in an array.
            string[] car2 = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string i in car2)
            {
                Console.WriteLine(i);
            }

            //there are many methods available in an array,that time sort() is used to alphabetically or in an ascending order.
            //sort a string
            string[] car3 = { "Volvo", "BMW", "Ford", "Mazda" };
            Array.Sort(car3);
            foreach (string i in car3)
                Console.WriteLine(i);

            //sort an int
            int[] mynum = { 10, 26, 3, 14, 59, 6 };
            Array.Sort(mynum);
            foreach (int i in mynum)
            {
                Console.WriteLine(i);
            }

            //array methods Max,Min,and sum 

            int[] myNumbers = { 50, -1, 18, 9 };
            Console.WriteLine(myNumbers.Max());  // returns the largest value
            Console.WriteLine(myNumbers.Min());  // returns the smallest value
            Console.WriteLine(myNumbers.Sum());  // returns the sum of elements


            //multidimensional arrays
            //if you want to store a data in a tabular form,like rows and columns,u need to get familiar with multidimensional array.

            //if we want tocreate 2D array within its own set of curly braces,and insert a comma( ,) inside the square brackets.
            int[,] numbers = { { 0, 1, 2 }, { 4, 5, 6 } };
            Console.WriteLine(numbers[1, 2]);  //output is 6.

            //will change the value of the element in the first row (0) and first column(0).
            int[,] number = { { 0, 1, 2 }, { 4, 5, 6 } };
            number[0, 0] = 9;
            Console.WriteLine(number[0, 0]);  //output 0 instead of 9.


            // u can easily find the elementsof a 2D array with a foreach loop.
            int[,] number1 = { { 0, 1, 2 }, { 4, 5, 6 } };
            foreach (int i in number1)
            {
                Console.WriteLine(i);
            }*/

            //we have to use GetLength() instaed of Length to specify how many times the loop should run.
            int[,] number2 = { { 10, 1, 2 }, { 4, 15, 6 } };
            for (int i = 0; i < number2.GetLength(0); i++)
            {
                for(int j = 0; j < number2. GetLength(1); j++)
                {
                    Console.WriteLine(number2[i, j]);
                }
            }




























        }
    }
}
