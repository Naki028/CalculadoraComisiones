using CalculadoraComisiones.Domain.Enums;

namespace CalculadoraComisiones.Domain.Interfaces;

public interface ICommissionRule
{
    SalesCountry Country { get; }

    decimal Rate { get; }

    decimal CalculateCommission(decimal netSales);
}
