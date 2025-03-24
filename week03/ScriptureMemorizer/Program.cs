using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a scripture
        Reference reference = new Reference("John", 3, 16);
        string text = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
        Scripture scripture = new Scripture(reference, text);

        // Main loop
        while (true)
        {
            Console.Clear();
            scripture.Display();

            if (scripture.AreAllWordsHidden())
            {
                Console.WriteLine("\nYou have memorized the entire scripture!");
                break;
            }

            Console.Write("\nPress Enter to hide more words or type 'quit' to exit: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            // Hide random words
            if (!scripture.HideRandomWords(3))
            {
                Console.WriteLine("\nNo more words to hide!");
                break;
            }
        }

        Console.WriteLine("\nThank you for using the Scripture Memorizer Program!");
    }
}