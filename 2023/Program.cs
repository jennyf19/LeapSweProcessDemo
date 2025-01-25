
            Console.Write("Welcome to the guessing game! I'm thinking of a number between 1 and 100. Can you guess what it is?");
            int numberToGuess = new Random().Next(1, 101);
            int guess = 0;

            while (guess != numberToGuess)
            {
                Console.WriteLine("Enter your guess: ");

                // Exception handling for non-integer input
                try
                {
                    guess = int.Parse(Console.ReadLine());

                    if (guess > numberToGuess)
                    {
                        Console.WriteLine("Too high! Try again.");
                    }
                    else if (guess < numberToGuess)
                    {
                        Console.WriteLine("Too low! Try again.");
                    }
                    else
                    {
                        Console.WriteLine("Congratulations, you guessed the number!");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }
            Console.ReadLine();
