namespace ChristmasTree
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ASCII-Weihnachtsbaum ===\n");

            // Step 1: Ask for tree crown height
            Console.Write("Gib die Höhe der Baumkrone ein: ");
            string input = Console.ReadLine();
            int height = Convert.ToInt32(input);

            Console.WriteLine(); // Empty line

            // Step 2: Draw tree crown
            for (int i = 0; i < height; i++)
            {
                // Output spaces for centering
                int spaceCount = height - i - 1;
                for (int j = 0; j < spaceCount; j++)
                {
                    Console.Write(" ");
                }

                // Output stars
                int starCount = 2 * i + 1;
                for (int j = 0; j < starCount; j++)
                {
                    Console.Write("*");
                }

                // Line break
                Console.WriteLine();
            }

            // Step 3: Draw trunk (always 2 rows high, 3 characters wide)
            for (int i = 0; i < 2; i++)
            {
                // Spaces for centering the trunk
                int spaceCount = height - 2;
                for (int j = 0; j < spaceCount; j++)
                {
                    Console.Write(" ");
                }

                // Trunk (3 hash symbols)
                Console.Write("###");

                // Line break
                Console.WriteLine();
            }

            Console.WriteLine("\nFrohe Weihnachten!");
            Console.WriteLine("Drücke eine Taste zum Beenden...");
            Console.ReadKey();
        }
    }
}
