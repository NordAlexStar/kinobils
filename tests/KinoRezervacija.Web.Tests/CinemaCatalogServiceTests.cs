using KinoRezervacija.Web.Services;

namespace KinoRezervacija.Web.Tests;

public sealed class CinemaCatalogServiceTests
{
    [Fact]
    public void SeededMoviesHaveAnAvailableScreeningAndAValidHall()
    {
        var catalog = new CinemaCatalogService();

        foreach (var movie in catalog.Movies)
        {
            var screening = catalog.GetScreenings(movie.Id).First();
            Assert.Contains(catalog.Halls, hall => hall.Name == screening.Hall);
            Assert.True(screening.FreeSeats > 0);
        }
    }

    [Fact]
    public void AddMovieMakesTheMovieAvailableInTheCatalog()
    {
        var catalog = new CinemaCatalogService();

        catalog.AddMovie("Ziemeļu gaisma", "Drāma", 101, "Jauna filma.", "12+", "Latviešu");

        var movie = Assert.Single(catalog.Movies, item => item.Title == "Ziemeļu gaisma");
        Assert.Equal(101, movie.DurationMinutes);
        Assert.Equal("Drāma", movie.Genre);
    }
}
