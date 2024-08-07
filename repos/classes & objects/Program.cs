namespace classes___objects
{
    //we cannot run main method in same name space.
     /*class Program
    {
        int id ; //fields and also instance variables.
        string name ;  //fields
        static string age; //static variables are directly we can call in main method.

        public static void method1(string age)
        {
            Console.WriteLine(age);    
        }

        public void method() //method
        {
            Console.WriteLine(id +" "+ name);
        }
        public static void Main(string[] args)
        {
            // Program.method1("22");   //we can call static method in main method,without creating an object.
            Program p1 = new Program(); //creating an object is same as class name and calling fields and methods for the above class using reference variable.
            p1.id = 101;                //here p1 is the reference variable. 
            p1.name = "sandhya";
            p1.method();
            Program.method1("22");
            Console.WriteLine(p1.id);
            Console.WriteLine(p1.name);
            Console.WriteLine("________________________");

            Program p2 = new Program(); //we have to create another object for the above class.
            p2.id = 121;                //we can create n number of objects in a class.
            p2.name = "reddy";
            p2.method();
            Console.WriteLine(p2.id);
            Console.WriteLine(p2.name);
        }*/

            //_______________________________________________________________________________________________//
            class car   //create a class name as constructor. 
        {
            string model;  //create a field.

            public car(string model)     //create a constructor name as constructor.
            {
                this.model =model;      //we have to set the initial value to the field. 
            }

            public static void Main(string[] args)    //main method
            {
                car c1 = new car();   //creating an object
                Console.WriteLine(c1.model);          //print the output     
            }





        }
































































    }
    }

