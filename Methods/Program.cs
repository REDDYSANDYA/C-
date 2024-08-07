namespace Methods
{
    internal class Program
    {
       /* static void mymethod()
        {
            Console.WriteLine("sub method");
        }*/
        static void Main(string[] args)
        {
            /* //A method is a block of code which only runs when it is called.
             //u can pass data known as parameters, into a method.
             //methods are used to perform certain actions, and they are also known as functuions.

             mymethod();   //output is sub method.
             mymethod();
             mymethod();   //we can call n no of times sub method in main method.

             //information can be passed to methods as parameter,parameters act as variables inside the method.
             //if u want to add many parameters as you want,just separate them with comma.
             static void mymethod(string fname) 
             {
                 Console.WriteLine(fname + "sandhya");
             }
             //static void Main (string[] args)
             {
                 mymethod("Sanjana");
                 mymethod("sowmya");
                 mymethod("reddysana");
             }
            static void mymethod(string name, int age)
            {
                Console.WriteLine(name + " " + age);
            }
            // static void main(string[] args)
            {
                mymethod("sana", 25);
                mymethod("sandhya", 26);
                mymethod("reddy", 27);

            }

            //we can also use default parameter value, by using equal sign(=).
            static void mymethod (string country = "Norway")
            {
              Console.WriteLine (country);
            }

            mymethod("sweden");
            mymethod("india");
            mymethod();
            mymethod("USA");

            //Void keyword indicates that the method should not return a value.
            //if you want the method to return a value, we can use primitive data types(such as int or double) instead of void,and use the return keyword inside the method.

            static int Mymethod(int i)   // one parameter
            {
                return 5+i;
            }
            Console.WriteLine(Mymethod(3));

            static int mymethod (int i, int j)   //two parameters
            {
                return i + j;
            }
            Console.WriteLine(mymethod(4 , 6));


            //we can store the result in a variable also, it is easy to read and maintain.
            static int mymethod (int i,int j)
            {
                return i + j;
            }
            int z = mymethod(3, 4);
            Console.WriteLine(z);

            //it is also possible to send arguments with key:value syntax.
            static  void mymethod (string child1, string child2, string child3)
            {
                Console.WriteLine("The youngest child is:" + child2);

            }
            mymethod(child3: "sandhya", child1: "sana", child2: "reddy");*/
              
            //method overloading means multiple methods can have same method name with different parameters.
            static int plusmethod(int x, int y)
            {
                return x + y;
            }
            static double plusmethod1(double x, double y)
            {
                return x + y;
            }
             
            int mynum = plusmethod(1, 2);
            double mynum1 = plusmethod1(1.2, 2.52);
            Console.WriteLine("int:" + mynum);
            Console.WriteLine("double:" + mynum1);












































        }
    }
}       
