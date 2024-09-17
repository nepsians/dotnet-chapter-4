namespace Chapter4LINQ {
    class Challenge2
    {
        static void Main()
        {
            // Find Words That Start with a Vowel
            List<string> words = new List<string> { "apple", "banana", "orange", "umbrella", "grape", "elephant" };

            var vowelWords = words.Where(w => "aeiouAEIOU".Contains(w[0]));

            Console.WriteLine("Words that start with a vowel:");
            foreach (var word in vowelWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}