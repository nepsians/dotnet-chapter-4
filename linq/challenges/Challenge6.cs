namespace Chapter4LINQ {
    class Challenge6
    {
        static void Main()
        {
            // Get distinct top 3 Scores
            int[] scores = { 85, 90, 78, 92, 88, 95, 67, 80, 91, 95 };

            var topScores = scores.OrderByDescending(s => s).Distinct().Take(3);

            Console.WriteLine("Top 3 scores:");
            foreach (var score in topScores)
            {
                Console.WriteLine(score);
            }
        }
    }
}