using eTickets.Data.Base;
using eTickets.Models;
using System.Threading.Tasks;
using eTickets.Data.ViewModels;

namespace eTickets.Data.Services
{
    public interface IMoviesService:IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
        Task AddNewMovieAsync(NewMovieVM data);
        Task UpdateMovieAsync(NewMovieVM data);
        Task DeleteMovieAsync(NewMovieVM data);
    }
}