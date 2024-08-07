using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes___objects
{
    //constructor is nothing but a special method,it is used to initialize the objects.
    //the advantage of constuctor is,when an object of a class is created.

    class car   //create a class name as constructor. 
    {
        string model;  //create a field.

        public car()     //create a constructor name as constructor.
        {
            model = "BMW";      //we have to set the initial value to the field. 
        }

        public static void Main(string[] args)    //main method
        {
            car c1 = new Constructor();   //creating an object
            Console.WriteLine(c1.model);          //print the output     
        }





    }
}
