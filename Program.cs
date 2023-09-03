namespace LeapSwePracticeApp 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to the guesing game! I'm thinking of a number between 1 and 100. Can you guess what it is?");
            int numberToGuess = new Random().Next(1, 101);
            int guess = 0;
            while (guess != numberToGuess)
            {
                Console.Write("Enter your guess: ");
                guess = int.Parse(Console.ReadLine());
                if (guess > numberToGuess)
                {
                    Console.Write("Too low! Try again.");
                }
                else if (guess < numberToGuess)
                {
                    Console.Write("Too high! Try again.");
                }
                else
                {
                    Console.Write("Congratulations, you guessed the number!");
                }
            }
            Console.ReadLine();
        }
    }
}