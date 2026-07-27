using KinoRezervacija.Web.Services;

namespace KinoRezervacija.Web.Tests;

public sealed class CinemaCatalogServiceTests
{
    [Fact]
    public void AppVersionUsesSemanticVersionFormat()
    {
        Assert.Matches("^\\d+\\.\\d+\\.\\d+$", AppVersion.Value);
    }

    [Fact]
    public void CatalogMoviesExposeAReleaseYear()
    {
        var catalog = new CinemaCatalogService();

        Assert.All(catalog.Movies, movie => Assert.InRange(movie.ReleaseYear, 1888, DateTime.Today.Year));
    }

    [Fact]
    public void HallLayoutCanBeUpdatedForOperatorManagement()
    {
        var catalog = new CinemaCatalogService();

        Assert.True(catalog.UpdateHallLayout("Zāle 1", 8, 12));
        var hall = Assert.Single(catalog.Halls, item => item.Name == "Zāle 1");

        Assert.Equal(8, hall.Rows);
        Assert.Equal(12, hall.SeatsPerRow);
    }

    [Fact]
    public void ValidDiscountCodeReducesTheOrderTotal()
    {
        var discounts = new DiscountService();

        Assert.True(discounts.TryApply("blegh", 20.00m, out var total, out var message));
        Assert.Equal(18.00m, total);
        Assert.Contains("10%", message);
    }

    [Fact]
    public void InvalidDiscountCodeLeavesTheOrderTotalUnchanged()
    {
        var discounts = new DiscountService();

        Assert.False(discounts.TryApply("bleg", 20.00m, out var total, out var message));
        Assert.Equal(20.00m, total);
        Assert.Contains("Nederīgs", message);
    }

    [Fact]
    public void PaymentValidationSupportsCardAndInternetBanking()
    {
        var payments = new PaymentService();

        Assert.True(payments.TryValidate("Kartes maksājums", "4242 4242 4242 4242", "12/30", "123", out _));
        Assert.True(payments.TryValidate("Internetbanka", "", "", "", out _));
        Assert.False(payments.TryValidate("Kartes maksājums", "123", "", "", out var message));
        Assert.Contains("derīgu", message);
    }

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
