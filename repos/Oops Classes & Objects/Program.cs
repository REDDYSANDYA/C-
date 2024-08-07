using System.Security.Cryptography;

namespace Oops_Classes___Objects
{
    internal class Program
    {
        //C# is a object oriented programming language,designed by classes and objects.
        //object is a real world entity,it is an entity that has state and behaviour.
        //here state means data and behaviour means functionality.
        //object is a runtime entity,and created at runtime.
        //object is an instance of a class,all the members of a class can be accessed through object.


        // Student s1 = new Student(); //Creating of an object ofstudent.

        //class is a group of similar objects,it is a template from which objects are created,and also it can have constructors.
        //class has two fields.

        int id; //instance variable
        string Name; //instance variable

        public static void Main(string[] args)
        {

            Program s1 = new Program(); //creating an object
            s1.id = 101;
            s1.Name = "sandhya";
            Console.WriteLine(s1.id);
            Console.WriteLine(s1.Name);
            
            





        }




































    }
}
