using Movies.Client.Models;

namespace Movies.Client.ApiServices
{
    public class MovieApiService : IMovieApiService
    {
        public Task<Movie> CreateMovie(Movie movie)
        {
            throw new NotImplementedException();
        }

        public Task<Movie> DeleteMovie(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Movie> GetMovie(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Movie>> GetMovies()
        {
            var movieList = new List<Movie>();
            movieList.Add(new Movie
            {
                Id = 1,
                Genre = "Comics",
                Title = "asd",
                Rating = "9.2",
                ImageUrl = "image/src",
                ReleaseDate = DateTime.Now,
                Owner = "lsminh"
            });

            return await Task.FromResult(movieList);
        }

        public Task<Movie> UpdateMovie(Movie movie)
        {
            throw new NotImplementedException();
        }
    }
}
