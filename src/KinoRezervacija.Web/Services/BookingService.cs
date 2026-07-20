using System.Security.Cryptography;
using System.Text;
using KinoRezervacija.Web.Models;

namespace KinoRezervacija.Web.Services;

public sealed class BookingService
{
    private readonly List<Customer> _customers = [];
    private readonly List<TicketOrder> _orders = [];
    private readonly Dictionary<int, HashSet<string>> _reservedSeats = [];
    private readonly object _gate = new();

    public bool Register(string email, string password, out string message)
    {
        lock (_gate)
        {
            if (_customers.Any(customer => customer.Email.Equals(email, StringComparison.OrdinalIgnoreCase))) { message = "Šis e-pasts jau ir reģistrēts."; return false; }
            _customers.Add(new Customer(_customers.Count + 1, email, Hash(password))); message = "Konts ir izveidots."; return true;
        }
    }

    public bool SignIn(string email, string password) => _customers.Any(customer => customer.Email.Equals(email, StringComparison.OrdinalIgnoreCase) && customer.PasswordHash == Hash(password));
    public bool IsAvailable(int screeningId, string seat) => !_reservedSeats.TryGetValue(screeningId, out var seats) || !seats.Contains(seat);
    public TicketOrder? Reserve(int screeningId, IReadOnlyList<string> seats, string email, out string message)
    {
        lock (_gate)
        {
            if (seats.Count == 0) { message = "Izvēlieties vismaz vienu vietu."; return null; }
            var taken = _reservedSeats.GetValueOrDefault(screeningId) ?? [];
            if (seats.Any(taken.Contains)) { message = "Kādu no izvēlētajām vietām tikko rezervēja cits pircējs."; return null; }
            foreach (var seat in seats) taken.Add(seat); _reservedSeats[screeningId] = taken;
            var order = new TicketOrder(Guid.NewGuid(), screeningId, seats, email, DateTime.Now, Convert.ToHexString(RandomNumberGenerator.GetBytes(8)));
            _orders.Add(order); message = "Maksājums apstiprināts, biļete ir sagatavota."; return order;
        }
    }
    public TicketOrder? FindOrder(Guid id) => _orders.SingleOrDefault(order => order.Id == id);
    private static string Hash(string password) => Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(password)));
}
