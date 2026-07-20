namespace KinoRezervacija.Web.Services;

public sealed class CustomerSession
{
    public string? Email { get; private set; }
    public bool IsAuthenticated => Email is not null;
    public void SignIn(string email) => Email = email;
    public void SignOut() => Email = null;
}
