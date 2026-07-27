namespace KinoRezervacija.Web.Services;

public sealed class PaymentService
{
    public bool TryValidate(string method, string cardNumber, string expiry, string cvv, out string message)
    {
        if (method == "Internetbanka")
        {
            message = "Maksājuma veids ir izvēlēts.";
            return true;
        }

        var digits = new string(cardNumber.Where(char.IsDigit).ToArray());
        if (digits.Length != 16 || string.IsNullOrWhiteSpace(expiry) || cvv.Trim().Length != 3)
        {
            message = "Ievadiet derīgu kartes numuru, derīguma termiņu un CVV.";
            return false;
        }

        message = "Kartes dati ir derīgi.";
        return true;
    }
}
