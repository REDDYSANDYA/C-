namespace Enums
{
    //Enum is a special class, that represents group of constants.
    //it is unchangable,read only variables.
    //To create an enum,we use enum keyword (instead of class and interface),separate the enum items with a comma.
    //we have to create enum for inside a class and outside a class.
    //by default the first item has the value 0,it will take.

    enum Level
    {
        Low, Medium, High
    }
    internal class Program
    {
        enum Months
        {
            January,  //0
            Febraury, //1
            March,    //2         //we have to assign own our enum values also.
            April,    //3        //enums are used to switch statements.
            May       //4
        }


        enum Level
        {
            Low,
            Medium, 
            High
        }
        public static void Main(string[] args)
        {

            int myNum = (int)Months.April;
            Console.WriteLine(myNum);

            Level level = Level.Low;   //we can access the enum items with the dot(.) syntax.
            Console.WriteLine(level);


            //switch statement
            Level myVar = Level.High;
            switch (myVar)
            {
                    case Level.Low:
                    Console.WriteLine(myVar);
                    break;
                    case Level.Medium:
                    Console.WriteLine(myVar);
                    break;
                    case Level.High:
                    Console.WriteLine(myVar);
                    break;
            }
           

        }

    }
}
