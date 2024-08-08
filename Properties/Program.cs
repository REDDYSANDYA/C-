namespace Properties
{
    //Encapsulation is nothing but sensitive data is hidden from ussers.
    //previously learned private variables are accesss with in the class,but sometimes we can access outside the class that time we can use properties like set and get.
    //get methods returns the value of the variable name.
    //set method asssign the value to the variable name.
    //provide public get and set methods through properties,that is helped to update the value of the private field. 

    class Person
    {
        
        private string name;  //field
            public string Name  //property
        { 
            get { return name; } 
            set { name = value; }
        }
        
        

        /*Person(string name)
        {

            //Console.WriteLine(name);
        this.name = name;
        }*/

      

        internal class Program
        {
            static void Main(string[] args)   //main-method
            {

                Person p1 = new Person();
                p1.Name = "sandhya";
                p1.Name = "jhansi";
                Console.WriteLine(p1.Name);
                //Console.WriteLine("Hello, World!");


            }
        }
    }
}
