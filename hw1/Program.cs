using System;


namespace hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Random r = new System.Random();
            int number = r.Next(0, 100);
            //Console.WriteLine(number);//For debugging
            int guess = 0;

            Console.Write("Guess a number between 0 and 100: ");
            
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
