using System;
public class Translator
{

    public static void Main()
    {
        void TranslationChoice()
        {
            Console.WriteLine(" Enter 1 to translate to Pig Latin ");
            Console.WriteLine(" ");
            Console.WriteLine(" Enter 2 to translate to English ");

            var Choice = Console.ReadLine();
            int choice = int.Parse(Choice);
            // handle exceptions
            List<string> pig = new List<string>();
            List<string> EnglishWord = new List<string>();
            if (choice == 1)
            {
                Console.WriteLine("You Chose to translate to Pig Latin ");
                Console.WriteLine(" ");
                Console.WriteLine("Enter English words");
                var word = Console.ReadLine();
                // List<string> WordArray = new List <string>();
                var WordArray = word.Trim().Split(" ");
                for (int i = 0; i < WordArray.Length; i++)
                {
                    var Pig = WordArray[i].Substring(1, WordArray[i].Length - 1) + WordArray[i].Substring(0, 1) + "ay";
                    // Console.WriteLine(Pig); 
                    pig.Add(Pig);

                }
                string PigLatin = string.Join(" ", pig.ToArray());
                Console.WriteLine(" ");
                Console.WriteLine(PigLatin);
                Console.WriteLine(" ");
                ReTranslate();

            }
            else if (choice == 2)
            {
                Console.WriteLine("You Chose to translate to English ");
                Console.WriteLine(" ");
                Console.WriteLine("Enter pig latin");
                var word = Console.ReadLine();
                var PigArray = word.Trim().Split(" ");
                for (int i = 0; i < PigArray.Length; i++)
                {
                    if (PigArray[i].Length >= 3 && PigArray[i].Substring(PigArray[i].Length- 2,2) == "ay")
                    {
                        var word1 = PigArray[i].Substring(PigArray[i].Length - 3, 1) + PigArray[i].Substring(0, PigArray[i].Length - 3);
                        EnglishWord.Add(word1);
                    }
                    else
                    {
                        Console.WriteLine("Inappriopriate conversion");
                        Console.WriteLine(" ");
                        return;
                        ReTranslate();
                    }

                }

                string FinalWord = string.Join(" ", EnglishWord.ToArray());
                Console.WriteLine(" ");
                Console.WriteLine(FinalWord);
                Console.WriteLine(" ");
                ReTranslate();
            }
            else
            {
                Console.WriteLine("Start again and choose a Valid Option!!");
                Console.WriteLine(" ");
                ReTranslate();
            }
        }
        void ReTranslate(){
            Console.WriteLine("Enter 1 to translate again or any other key to exit");
            var choice = Console.ReadLine();
            if (int.TryParse(choice, out int choice1))
            {
                if (choice1 == 1)
                {
                    TranslationChoice();
                }else{
                    return;
                }
            }else{
                return;
            }
        }
        TranslationChoice();
    }
}
