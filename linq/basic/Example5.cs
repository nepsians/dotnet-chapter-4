namespace Chapter4LINQ {
    class Example5{
            // Counting Words with More Than 3 Characters
            public static void Main(){
            string[] words = { "cat", "dog", "elephant", "ant", "tiger" };

            var wordCount = from word in words
                            where word.Length > 3
                            select word;

            var wordCountTwo = words.Count(w => w.Length > 3);

            Console.WriteLine("Number of words with more than 3 characters: " 
            + wordCount.Count());

            foreach (var name in wordCount)
            {
                Console.WriteLine(name);
            }
        }
    }
}

