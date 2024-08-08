namespace Polymorphism
{
    /*//polymorphism means many forms, and it occurs when we have created many classess that are related to each other by inheritance.
    //inheritance concept is used to inherit fields and methods from another class.
    //polymorphism uses those methods to perform different tasks.

    class Animal  //base class (parent)
    {
        public void animalsound()     //method1
        {
            Console.WriteLine("The animal makes sound");
        }
    }

    class Pig : Animal  //derived class (child1)
    {
        public void animalsound1()  //method2
        {
            Console.WriteLine("The pig says : wee wee ");
        }
    }

    class Dog : Animal  //derived class (child2)
    {
        public void animalsound2()  //method3
        {
            Console.WriteLine("The dog says : bow bow ");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal myanimal = new Animal();
            myanimal.animalsound();

            Pig p = new Pig();
            p.animalsound();
            p.animalsound1();

            Dog d = new Dog();
            d.animalsound();
            d.animalsound2 ();

            // Console.WriteLine("Hello, World!");
        }
    }*/
}


//c# provides an option to override the base class method.
//by adding the 'virtual' keyword to the method inside the base class,
//and by using 'override' keyword to the each derived class methods.

class Animal1  //base class
{
    public virtual void Animalsound()    //base class have virtual keyword.
    {
        Console.WriteLine("Animals has make sound");
    }
}
class Cat : Animal1  //derived class
{
    public override void Animalsound()   //derived class have override keyword.
    {
        Console.WriteLine("cat says like : meow meow ");
    }
}
class Dog : Animal1   //derived class
{
    public override void Animalsound()     //derived class have override keyword.
    {
        Console.WriteLine("dog says like : bow bow ");
    }
}

class Pets
{
    static void Main(string[] args)  //main method
    {
        Animal1 a1 = new Animal1();    //creating object
        a1.Animalsound();            //calling the method by using object
        Cat c = new Cat();
        c.Animalsound();
        Dog d = new Dog();
        d.Animalsound();

    }
}