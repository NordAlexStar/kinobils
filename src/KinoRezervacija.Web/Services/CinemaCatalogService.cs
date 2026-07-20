using KinoRezervacija.Web.Models;

namespace KinoRezervacija.Web.Services;

public sealed class CinemaCatalogService
{
    private readonly List<Movie> _movies = [
        new(1, "Neona pilsēta", "Trilleris", 118, "16+", "Angļu", "Latviešu", "Pēc nakts lietus Rīga iemirdzas neona krāsās. Detektīve Mara atrod pavedienu, kas ved pāri pilsētai un pašai sev pāri.", 8.50m, "violet", true, "/images/posters/neona-pilseta.png"),
        new(2, "Mēness arhīvs", "Zinātniskā fantastika", 132, "12+", "Angļu", "Latviešu", "Uz pamestas Mēness stacijas atstāta balss ieraksta atklāj stāstu, kuru neviens nebija paredzējis dzirdēt.", 9.00m, "blue", false, "/images/posters/meness-arhivs.png"),
        new(3, "Vasaras otra puse", "Drāma", 104, "7+", "Latviešu", "Angļu", "Draudzība, kas sākas vienā vasarā, iemāca pieaugt daudz ātrāk nekā gribētos.", 7.50m, "gold", false, "/images/posters/vasaras-otra-puse.png"),
        new(4, "Savvaļas signāls", "Piedzīvojumu", 96, "7+", "Latviešu", "Nav", "Jauna biologu komanda seko noslēpumainam radiosignālam dziļi mežā.", 7.50m, "green", false, "/images/posters/savvalas-signals.png")];
    private readonly List<Screening> _screenings = [
        new(1, 1, TodayAt(18, 30), "Zāle 1", 8.50m, 42), new(2, 1, TodayAt(21, 15), "Zāle 2", 9.50m, 17),
        new(3, 2, TodayAt(19, 10), "Zāle 3", 9.00m, 31), new(4, 3, TodayAt(17, 45), "Zāle 2", 7.50m, 56), new(5, 4, TodayAt(16, 20), "Zāle 1", 7.50m, 65)];
    public IReadOnlyList<Hall> Halls { get; } = [new("Zāle 1", 6, 10), new("Zāle 2", 5, 8), new("Zāle 3", 7, 12)];
    public IReadOnlyList<Movie> Movies => _movies;
    public IReadOnlyList<Screening> Screenings => _screenings;
    public Movie? FindMovie(int id) => _movies.SingleOrDefault(movie => movie.Id == id);
    public IEnumerable<Screening> GetScreenings(int movieId) => _screenings.Where(screening => screening.MovieId == movieId).OrderBy(screening => screening.StartsAt);
    public void AddMovie(string title, string genre, int duration, string description, string ageRating, string language) => _movies.Add(new(_movies.Max(movie => movie.Id) + 1, title, genre, duration, ageRating, language, "Latviešu", description, 8.00m, "coral"));
    public void AddScreening(int movieId, DateTime startsAt, string hall, decimal price) => _screenings.Add(new(_screenings.Max(screening => screening.Id) + 1, movieId, startsAt, hall, price, 48));
    private static DateTime TodayAt(int hour, int minute) => DateTime.Today.AddHours(hour).AddMinutes(minute);
}
