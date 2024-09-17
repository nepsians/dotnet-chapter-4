namespace Chapter4LINQ {
    class Challenge3
    {
        static void Main()
        {
            // Find the Longest Word
            string[] words = { "dog", "elephant", "cat", "hippopotamus", "whale" };

            // Approach: 1
            var longestWords = words.Where(w => w.Length == words.Max(w2 => w2.Length));
            Console.WriteLine("Longest word(s): "+ longestWords.First());

            // Approach: 2
            var longestWordsTwo = words.OrderByDescending(w => w.Length);
            Console.WriteLine("Longest word(s): " + longestWordsTwo.First());
        }
    }
}