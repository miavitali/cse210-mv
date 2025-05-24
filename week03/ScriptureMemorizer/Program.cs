using System;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptureLibrary = new List<Scripture>
        {
        new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding. In all your ways acknowledge him, and he will make straight your paths"),
        new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
        new Scripture(new Reference("Nephi", 3, 7), "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.")
        };


        Random random = new Random();
        int index = random.Next(scriptureLibrary.Count);
        Scripture selectedScripture = scriptureLibrary[index];

        Console.WriteLine(selectedScripture.GetDisplayText());
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");

         while (!selectedScripture.IsCompletelyHidden())
        {
            string input = Console.ReadLine();

            if (input.Trim().ToLower() == "quit")
                break;

            // Hide words
            selectedScripture.HideRandomWords(3);

            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText());
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        }
    }
}