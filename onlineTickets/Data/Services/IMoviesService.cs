using onlineTickets.Data.Base;
using onlineTickets.Models;

namespace onlineTickets.Data.Services
{
    public interface IMoviesService: IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
    }
}
