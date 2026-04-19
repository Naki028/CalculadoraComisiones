using CalculadoraComisiones.Domain.Enums;

namespace CalculadoraComisiones.Domain.Models;

public sealed record SalesCommissionRequest(
    decimal TotalSales,
    decimal Discounts,
    SalesCountry Country);
