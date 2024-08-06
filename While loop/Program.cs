namespace While_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//the while loop through a block of code as long as a specified condition is true.
            int i = 0;
            while (i < 5)  //given condition
            {
                Console.WriteLine(i);

                i++; //increment  if we forget the increment,otherwise the loop will never end.
            }

            //do-while
            //this loop will always be executed at least once,even if the condition is false,because the code block is executed before the condition is tested.
            int i1 = 0;
            do
            {
       
                Console.WriteLine(i1);
                
                i1++;
            } while (i1 < 5);

            //for loop
            //how many times you want to execute the block of code, we have to use for loop instead of while loop.
            for(int i2=0; i2<=5; i2++)
            {
                Console.WriteLine(i2);
            }

            //only print the even values b/w 0 and 10.
            for (int i3=0; i3<10; i3=i3+2)
            {
                Console.WriteLine(i3);
            }

            // loop inside another loop is called nested loop.
            //the inner loop will be executed one time for each iteration of the outer loop.

            //outer loop
            for(int i4=0; i4<=10; i4++)
            {
                Console.WriteLine("outer is:" +i4);  //Executes 2 times
            }

            //inner loop
            for(int i5 =0; i5<10; i5++)
            {
                Console.WriteLine("inner is:" + i5);   //executes 6 times (2*3).

            }

            //for-each loop is used to exclusively to loop through elements in an array(or other data sets).
            string[] cars = { "volvo", "BMW", "Ford", "Mazda" };
            foreach (string c in cars)
            {
                Console.WriteLine(c);
            }

            //break stmt can also be used to jumb out of a loop.
            for (int c = 0; c < 10; c++)
            {
                if (c == 5)
                {
                    break;
                    
                }
                Console.WriteLine(c);
            }

            //continue stmt breaks one iteration (in the loop), if a specified condition occurs,and continues with the next iteration in the loop.
            for (int c = 0; c < 10; c++)
            {
                if (c == 5)
                {
                    continue;
                }
                Console.WriteLine(c);
            }

            //we can use bfeak and continue in while loops
            int c1 = 0;
            while(c1 < 10)
            {
                Console.WriteLine(c1);
                c1++;
                if (c1 == 5)
                {
                    break ;
                }
            }*/

            int c2 = 0;
            while (c2 < 10)
            {
                if (c2 == 5)
                {
                    c2++;
                    continue;
                }
               Console.WriteLine(c2);
               c2++;
                    
                
            }






















        }
    }
}
