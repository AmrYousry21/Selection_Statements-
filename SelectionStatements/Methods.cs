namespace SelectionStatements // Note: actual namespace depends on the project name.
{
    public class Methods 
    
    {
    
        public void GuessMyNumber() 
        {
            int input = 0;
            int myNumber = 7;
            bool rightGuess = false;
            
            while(rightGuess == false) 
            {
                Console.WriteLine("Guess my number (1 to 10)");
                input = int.Parse(Console.ReadLine());

                if (input < myNumber) 
                {
                    Console.WriteLine("Too low. Guess again");
                }

                if (input > myNumber) 
                {
                    Console.WriteLine("Too high, Guess again");
                }
                
                if (input == myNumber) 
                {
                    Console.WriteLine("You guessed it");
                    rightGuess = true;
                }  
            }
        }

        public void FavoriteSubject () 
        {
            string userInput;
            
            Console.WriteLine("What's your favorite school subject? choose from the following (Math, biology, History, Chemistry)");
            userInput = Console.ReadLine().ToLower();

            switch (userInput) 
            {
                case "biology":
                    Console.WriteLine("That's great you probably want to be a doctor");
                    break;

                case "math":
                    Console.WriteLine("You would probably like coding");
                    break;

                case "history":
                    Console.WriteLine("That was my least favorite");
                    break;

                case "chemistry":
                    Console.WriteLine("That was my least favorite");
                    break;

                default:
                    Console.WriteLine("You didn't enter a valid subject");
                    break;
            }
        }
        
    }
}
