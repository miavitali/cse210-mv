using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all your heart and lean not on your own understanding. In all your ways acknowledge him, and he will make straight your paths";

        Scripture scripture = new Scripture(reference, text);

        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");

         while (!scripture.IsCompletelyHidden())
        {
            string input = Console.ReadLine();

            if (input.Trim().ToLower() == "quit")
                break;

            // Hide words
            scripture.HideRandomWords(3);

            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        }
    }
}