using System.Globalization;

namespace CalculadoraComisiones.Domain.Enums;

public static class SalesCountryExtensions
{
    public static string ToDisplayName(this SalesCountry country)
    {
        return country switch
        {
            SalesCountry.India => "India",
            SalesCountry.UnitedStates => "Estados Unidos (US)",
            SalesCountry.UnitedKingdom => "Reino Unido (UK)",
            _ => country.ToString()
        };
    }

    public static string ToCountryCode(this SalesCountry country)
    {
        return country switch
        {
            SalesCountry.India => "IN",
            SalesCountry.UnitedStates => "US",
            SalesCountry.UnitedKingdom => "UK",
            _ => country.ToString().ToUpper(CultureInfo.InvariantCulture)
        };
    }
}
