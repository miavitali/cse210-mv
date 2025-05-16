using System;

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
                string prompt = generator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("Response: ");
                string response = Console.ReadLine();
                string date = DateTime.Now.ToShortDateString();
                Entry newEntry = new Entry(date, prompt, response);
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
