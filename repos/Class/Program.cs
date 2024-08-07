using Class;

namespace Class

    
    {
        public class Insert
        {
            int id;
            string name;

            public void insert(int id, string name)
            {
                id = 1;
                name = "sandhya";
               Console.WriteLine(id + "" +name);

            }
            public void display()
            {
                Console.WriteLine(id + " " + name);

            }
        }
    }


    class TestStudent
    {
        public static void Main(string[] args)
        {
        Insert s1 = new Insert();
        s1.insert(2, "sowmya");
            s1.display();
           
          

        }












    }

