using CalculadoraComisiones.Domain.Interfaces;
using CalculadoraComisiones.Domain.Enums;

namespace CalculadoraComisiones.Domain.Rules;

public abstract class CommissionRuleBase : ICommissionRule
{
    private readonly decimal _rate;

    protected CommissionRuleBase(SalesCountry country, decimal rate)
    {
        Country = country;
        _rate = rate;
    }

    public SalesCountry Country { get; }

    public decimal Rate => _rate;

    public virtual decimal CalculateCommission(decimal netSales)
    {
        if (netSales < 0)
        {
            throw new InvalidOperationException("El monto neto no puede ser negativo.");
        }

        return decimal.Round(netSales * _rate, 2, MidpointRounding.AwayFromZero);
    }
}
