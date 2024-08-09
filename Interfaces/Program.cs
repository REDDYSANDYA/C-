using Interfaces;

namespace Interfaces
{
    //Interface is a abstract class,which can contain only abstract methods and properties.
    //It cannot contain fields.
    //It is considered good pracice to start with the letter of I, it is easier to remember yourself and others,it is a interface not a class.
    //By default, memberes of an interface are abstract and public.


    interface IAnimal
    {
         void animalsound();  //interface method (does not have a body)
    }


    class Pig:IAnimal  //pig "implements the IAnimal interface" 
    {
       public void animalsound()
        {
            Console.WriteLine("The pig says : wee wee ");  //the body of animalsound() is provided here.(interface method)
        }
    }
    //Abstract classess and interface cannot to create objects.
    //if we want to create objects we have to provide implements the abstract class to another class.
    //interface cannot contain constructor and fiels,it contain methods and properties.               
   
}

//C# does not support multiple inheritance,a class can inherit from only one base class.
//if we want multiple interfaces,separate them with a comma.

interface IFirstInterface
{
    void firstmethod();   //interface method1
}

interface ISecondInterface
{
    void secondmethod();  //interface method2
}

class Democlass : IFirstInterface, ISecondInterface      //implements multiple inheritance by using comma(,)
{
    public void firstmethod()
    {
        Console.WriteLine("Some Text...");
    }

    public void secondmethod()
    {
        Console.WriteLine("Some other Text....");
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Pig IA1 = new Pig();
        IA1.animalsound();


        Democlass IA2 = new Democlass();
        IA2.firstmethod();
        IA2.secondmethod();


    }
}














