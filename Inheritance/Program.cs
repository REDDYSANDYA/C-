namespace Inheritance
{
    //it is possible to inherit fields and methods from one class to another class
    //derived class is inherited from anather class.
    //base class is being inherited from.

    class Vehicle       //base class (parent)
    {
        public string brand ;   //it is a vehicle field.
         
        public void honk()             //it is a vehicle method.  
        {
            Console.WriteLine("tuu tuu!");
        }
    }

    class Car:Vehicle       //derived class (child)  car class is inherited from vehicle class.
    {
        public string modelname ;  //it is a car field
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();   //create car class object
            c.modelname = "BMW";
            c.brand = "Toyato";
            c.honk();            //call the method using car class object
            Console.WriteLine(c.brand+"   "+c.modelname);   //display the value of the brand field and value of the modelname from the car class.
        }
    }
}
