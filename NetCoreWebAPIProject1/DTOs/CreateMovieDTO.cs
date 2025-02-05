namespace NetCoreWebAPIProject1.DTOs;

public record CreateMovieDto(string Title, string Genre, DateTimeOffset ReleaseDate, double Rating);
