using System;
public class GuessGame
{

    public static void Main()
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 100);

        
        List<int> TriesList = new List<int>();
        int NumberOfTries = 1;


        void CheckGuess()


        {

            Console.WriteLine("Enter a number");

// add a check for input type


                var guess = Console.ReadLine();
            if(  Int32.TryParse(guess,out int guessNum )){
                                             
            if (guessNum == secretNumber)
            {
                Console.WriteLine("correct!");
                Count();
                Console.WriteLine("Press 1 to play Again");
                var value = Console.ReadLine();
                int Value = int.Parse(value);
                if (Value == 1)
                {   
                    
                    Reset();
                }
                else
                {
                    return;
                }

            }
            else if (guessNum < secretNumber)
            {
                Console.WriteLine("Guess is  too small");
                Count();
                Replay();
            }
            else
            {
                Console.WriteLine("Guess is  too big");
                Count();
                Replay();
            }
            }else{
                Console.WriteLine("Wrong Input Type!!! Enter a number!!!");
                Replay();
            }
            void Count()
            { 
                
                if(TriesList.Count > 0){
                int LastTry = TriesList[TriesList.Count -1 ];
                if (LastTry == guessNum )
                {
                    NumberOfTries += 0;
                }
                else
                {
                    NumberOfTries += 1;
                }
                Console.Write("You made ");
                Console.Write(NumberOfTries);
                Console.WriteLine(" guesses");
            }else{
                Console.WriteLine("You made 1 guess");
            }
            TriesList.Add(guessNum);
            }
            
        }
        void Reset()
        {
            int[] tries = new int[] { };
             int secretNumber = random.Next(1, 100);
            CheckGuess();
        }
        void Replay()
        {
            CheckGuess();
        }

        CheckGuess();
    }

}