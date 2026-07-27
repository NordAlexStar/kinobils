namespace KinoRezervacija.Web.Services;

public sealed class DiscountService
{
    public bool TryApply(string? code, decimal subtotal, out decimal total, out string message)
    {
        if (string.Equals(code?.Trim(), "blegh", StringComparison.OrdinalIgnoreCase))
        {
            total = Math.Round(subtotal * 0.90m, 2);
            message = "Atlaide 10% ir piemērota.";
            return true;
        }

        total = subtotal;
        message = "Nederīgs atlaides kods.";
        return false;
    }
}
