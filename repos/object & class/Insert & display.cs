using object___class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object___class
{
    public class Insert___display
    {
          int id;
         string name;
        
        public void insert(int id, string name)
        {
            id = 1;
            name = "sandhya";

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
        Insert___display s1 = new Insert___display();
        s1.insert(111, "sanjana");
        s1.insert(112, "sowmya");
        s1.display();
        s1.display();

    }












}