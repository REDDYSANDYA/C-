namespace Constructors
{
    internal class Program

    {
        public static void Main(string[] args)
        {
            Car c = new Car();
            c.num = 12;
            Console.WriteLine(c.num);
            // c.name = "Duster";
            Console.WriteLine(c.name);

            Car c1 = new Car(13, "BMW");
            Console.WriteLine(c1.num + " " + c1.name);
        }
    }
}
