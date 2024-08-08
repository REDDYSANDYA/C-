namespace Abstaction
{
    //Abstraction is a process of hiding certain details and showing the essential information to the user.
    //it can be acheived with either abstact classes or interfaces.
    //abstract keyword is used for classes and methods.
    //Abstract class: it is a resrticted class cannot be used to create objects.
    //if we want to create object for abstract class,it must be inherited from another class.
    //Abstract method : it can only be used in abstract class,does not have contain body,the body is provided by derived class means (inherited).

    abstract class Animal         //abstract class
    {
   
        public abstract void animalsound();       //abstract method (does not have body)
        public void sleep()    //regular method
        {
            Console.WriteLine("zzz");
        }
    }

    class Cat:Animal    //derived class (inherit from Animal)
    {
        public override void animalsound()
        {
            Console.WriteLine("The pig says : wee wee ");  //the body of the animalsound() is provided here.
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat c = new Cat();  //create a cat object
            c.animalsound();    //call the abstract method
            c.sleep();          //call the regular method

            //Console.WriteLine("Hello, World!");
        }
    }
}
