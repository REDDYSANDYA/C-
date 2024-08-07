namespace constructorExample
{
    public class Student
    {
        public int id;
        public int age;
        public string name;
        public string address;

        public Student()
        {
            id = 13;
            age = 23;
            name = "sandhya";
            address = "Anantapur";


        }

        public Student(int id,int age,string name,string address)
        {
            this.id = id;
            this.age = age;
            this.name = name;
            this.address = address;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(2,24,"jhansi","kadiri");
          /*  s1.id = 1;
            s1.age = 23;
            s1.name = "sandhya";
            s1.address = "Anantapur";*/
            Console.WriteLine(s1.id+""+s1.age+""+s1.name+""+s1.address);
           // Console.WriteLine(s1);

        }
    }
}
