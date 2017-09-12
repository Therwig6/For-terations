using System;

namespace Forterations
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //this code writes i every time 1 is added
            for (int i = 0; i < 10; i++) 
            {
                //Console.WriteLine(i.ToString());

                if (i == 7)
                {
                    Console.WriteLine("Found seven");
                    break;
                    //This code ends the for iteration stoppin it at 7

                }

               
            }
            //This code writes my value as substituded for i
            for (int myValue = 0; myValue < 12; myValue++)
            {
                Console.WriteLine(myValue);

            }

            Console.ReadLine();
        }
    }
}
