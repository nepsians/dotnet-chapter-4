namespace Chapter4LINQ {
    class Movie
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        public int ReleaseYear { get; set; }
        public double Rating { get; set; }

        public Movie(string title, string director,  string genre, int releaseYear, double rating) {
            Title = title;
            Director = director;
            Rating = rating;
            Genre = genre;
            ReleaseYear = releaseYear;
        }
    }

    class Advanced5
    {
        static void Main()
        {
            List<Movie> movies = new List<Movie>
            {
                new Movie ("Inception", "Christopher Nolan", "Action", 2010, 8.8),
                new Movie ("The Dark Knight", "Christopher Nolan", "Action", 2008, 9.0),
                new Movie ("Interstellar", "Christopher Nolan", "Sci-Fi", 2014, 8.6),
                new Movie ("Tenet", "Christopher Nolan", "Action", 2020, 7.5)
            };

            // 1. Find all movies with a rating above 7.0
            var highRatedMovies = movies.Where(m => m.Rating > 7.0);

            Console.WriteLine("Movies with a rating above 7.0:");
            foreach (var movie in highRatedMovies)
            {
                Console.WriteLine($"{movie.Title}, Rating: {movie.Rating}");
            }

            // 2. Sort movies by release year in descending order
            var sortedMovies = movies.OrderByDescending(m => m.ReleaseYear);

            Console.WriteLine("\nMovies sorted by release year:");
            foreach (var movie in sortedMovies)
            {
                Console.WriteLine($"{movie.Title}, Released: {movie.ReleaseYear}");
            }

            // 3. Display movies in the Action genre directed by Christopher Nolan
            var actionMoviesByNolan = movies
                .Where(m => m.Genre == "Action" && m.Director == "Christopher Nolan");

            Console.WriteLine("\nAction movies by Christopher Nolan:");
            foreach (var movie in actionMoviesByNolan)
            {
                Console.WriteLine(movie.Title);
            }

            // Challenge: Group movies by Genre and display average rating for each genre
            var averageRatingByGenre = movies
                .GroupBy(m => m.Genre)
                .Select(g => new { Genre = g.Key, AverageRating = g.Average(m => m.Rating) });

            Console.WriteLine("\nAverage rating by genre:");
            foreach (var genreGroup in averageRatingByGenre)
            {
                Console.WriteLine($"{genreGroup.Genre}: {genreGroup.AverageRating}");
            }
        }
    }
}