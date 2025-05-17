using System;

// ADDED:
// - Added support for a new "Mood" field, allowing the user to enter their mood for the day when creating a journal entry.
// - Included a test block that adds entries containing special characters (commas, quotes, and line breaks).
// - Automatically saves entries to a .csv file using proper CSV formatting.
// - Then reloads from the CSV file and displays the loaded entries.

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator generator = new PromptGenerator();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string option = Console.ReadLine();

            if (option == "1")
            {
                Console.Write("Describe your mood today in one word: ");
                string mood = Console.ReadLine();
                string prompt = generator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("Response: ");
                string response = Console.ReadLine();
                string date = DateTime.Now.ToShortDateString();
                Entry newEntry = new Entry(date, mood, prompt, response);
                journal.AddEntry(newEntry);
            }
            else if (option == "2")
            {
                journal.DisplayAll();
            }
            else if (option == "3")
            {
                Console.Write("What is the filename: ");
                string saveFile = Console.ReadLine();
                journal.SaveToFile(saveFile);
            }
            else if (option == "4")
            {
                Console.Write("What is the filename: ");
                string loadFile = Console.ReadLine();
                journal.LoadFromFile(loadFile);
            }
            else if (option == "5")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }

            Console.WriteLine();
        }
    }
}
