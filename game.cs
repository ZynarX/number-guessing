using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int random_number = (random.Next() % 100) + 1;
            int guess;
            int tries = 0;

            Console.WriteLine("------ Number Guessing Game ------");

            do
            {
                Console.Write("Enter a guess (1-100): ");
                bool guess_result = int.TryParse(Console.ReadLine(), out guess);

                if ( guess_result )
                {
                    tries++;

                    if ( guess != random_number )
                    {
                        if ( guess > random_number)
                        {
                            Console.WriteLine("Wrong guess! go lower!");
                        }
                        else
                        {
                            Console.WriteLine("Wrong guess! go higher!");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Enter a valid integer!");
                }
            } while (guess != random_number);

            if ( tries > 1 )
                Console.WriteLine($"You have guess the number in {tries} tries! it was {random_number}!");
            else if ( tries == 1 )
                Console.WriteLine($"You have guessed the number from the first time! it was {random_number}!");

            Console.ReadKey();
        }
    }
}
