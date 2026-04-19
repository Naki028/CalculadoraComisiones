using CalculadoraComisiones.Domain.Enums;

namespace CalculadoraComisiones.Domain.Models;

public sealed record SalesCommissionResult(
    SalesCountry Country,
    decimal TotalSales,
    decimal Discounts,
    decimal NetSales,
    decimal CommissionRate,
    decimal CommissionAmount);
