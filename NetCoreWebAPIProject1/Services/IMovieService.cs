using NetCoreWebAPIProject1.DTOs;

namespace NetCoreWebAPIProject1.Services;

public interface IMovieService
{
    Task<MovieDto> CreateMovieAsync(CreateMovieDto command);
    Task<MovieDto?> GetMovieByIdAsync(Guid id);
    Task<IEnumerable<MovieDto>> GetAllMoviesAsync();
    Task UpdateMovieAsync(Guid id, UpdateMovieDto command);
    Task DeleteMovieAsync(Guid id);
}