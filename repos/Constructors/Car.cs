namespace Constructors
{
    public class Car //we can create constructors with in the class.
    {
         public int num;   //by default variables in private
         public string name;

        public Car()  //default constructor
        {
            name = "BMW";  //we have to assign the values.
        }
        public Car(int num,string name)   //parameterized constructor
        {

            this.num = num; //we have assign values with the help of this keyword.
            this.name = name;

        }
    
    }
}
