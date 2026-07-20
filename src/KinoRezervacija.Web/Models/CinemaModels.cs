namespace KinoRezervacija.Web.Models;

public sealed record Movie(int Id, string Title, string Genre, int DurationMinutes, string AgeRating, string Language, string SubtitleLanguage, string Description, decimal FromPrice, string Accent, bool IsFeatured = false, string PosterPath = "");
public sealed record Screening(int Id, int MovieId, DateTime StartsAt, string Hall, decimal Price, int FreeSeats);
public sealed record Hall(string Name, int Rows, int SeatsPerRow);
public sealed record Customer(int Id, string Email, string PasswordHash);
public sealed record TicketOrder(Guid Id, int ScreeningId, IReadOnlyList<string> Seats, string Email, DateTime CreatedAt, string QrToken);
