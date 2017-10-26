using System;

namespace IT1050_Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            /*bool keepLooping = true;
            while (keepLooping)
            {

            }*/

            //Question 2
            int counter = 2;
            while (counter < 129)
            {
                Console.WriteLine("[{0}]", counter++);
            }


            //Question 3
            for (int x = 49; x > 0; x--)
            {
                Console.Write("{0}{1}", x, x == 1 ? "" : ",");
            }
            Console.WriteLine();


            //Question 4
            counter = 0;
            while (counter < 22)
            {

                Console.Write("{0}", counter % 2 != 0 ? counter + "   " : "");
                counter++;
            }
            Console.WriteLine();


            //Question 5
            //Explanation: The While() loop will not print any output,
            //the Do While() Loop will print one star. This is because
            //"i" already begins higher than "n" so "i" is never "< n"
            //The Do While() loop doesn't know this, however, until
            //it has printed one star
            int n = 8;
            int i = 10; // initialize
            do
            {
                Console.Write("*");
                i++; // update!
            } while (i < n); // test condition

            Console.WriteLine();


            
            n = 8;
            i = 10; // initialize

            while (i < n) // test condition
            {
                Console.Write("*");
                i++; // update!
            }

            Console.WriteLine();


            //Question 6

            bool icyRain = false;
            bool tornadoWarning = false;

            if (!icyRain && !tornadoWarning)
            {
                Console.WriteLine("Let's go outside!");
            }

            //Question 7

            for (int row = 0; row < 5; row++)
            {

                for (int space = 0; space < row; space++)
                {
                    Console.Write(" ");
                }

                for (int num = 0; num < 5 - row;)
                {
                    Console.Write(++num);
                }

                for (int num = 5 - row; num > 1;)
                {
                    Console.Write(--num);
                }

                for (int space = 0; space < row; space++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine();
            }

            Console.ReadKey(true);

        }
    }
}
