namespace Access_Modifiers
{
    //Access modifier is a keyword, it is used to set the visibility for classess,fields,methods and properties.
    //public keyword is accessable for all classess.
    //private keyword is accessable for within the same class.
    //protected is accessable for with the same class and is inherited from the other class.
    //internal is accessable within its own assembly.

    internal class Car
    {
        public string Color = "Red";

        private string model = "Duster";
        static void Main(string[] args)
        {
           Car car = new Car();
            Console.WriteLine(car.Color);
            Console.WriteLine(car.model);
        }
    }
}

