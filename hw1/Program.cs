using System;


namespace hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Random r = new System.Random();
            int min, max = 0;
            Console.WriteLine("Please select a range of number for the guessing game.");

            Console.Write("Please the enter the minimum integer: ");
            min = Int32.Parse(Console.ReadLine());

            Console.Write("Please enter the maximum integer: ");
            max = Int32.Parse(Console.ReadLine());


            int number = r.Next(min, max);
            //Console.WriteLine(number);//For debugging
            int guess = 0;

            Console.Write("Guess a number between " + min + " and " + max + ":");
            
            guess = Int32.Parse(Console.ReadLine());

            if (guess == number)
            {
                Console.WriteLine("Yay, you got it right!");
            }
            else 
            {
                Console.WriteLine("Better luck next time! You guessed " + guess + " but the answer was " + number);
            }
            
        }

     
    }


}
