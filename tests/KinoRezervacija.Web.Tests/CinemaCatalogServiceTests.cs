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

    [Fact]
    public void RegisterAndReservePreventsTheSameSeatFromBeingSoldTwice()
    {
        var booking = new BookingService();

        Assert.True(booking.Register("pircējs@example.com", "Droša!123", out _));
        Assert.True(booking.SignIn("pircējs@example.com", "Droša!123"));
        var order = booking.Reserve(1, ["A3", "A4"], "pircējs@example.com", out _);
        var duplicate = booking.Reserve(1, ["A3"], "viesis@example.com", out var message);

        Assert.NotNull(order);
        Assert.Null(duplicate);
        Assert.Contains("rezervēja", message);
        Assert.False(booking.IsAvailable(1, "A3"));
    }
}
