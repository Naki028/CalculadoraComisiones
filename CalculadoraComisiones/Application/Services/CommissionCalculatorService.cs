using CalculadoraComisiones.Application.Interfaces;
using CalculadoraComisiones.Domain.Models;
using CalculadoraComisiones.Infrastructure.Abstractions;

namespace CalculadoraComisiones.Application.Services;

public sealed class CommissionCalculatorService : ICommissionCalculatorService
{
    private readonly ICommissionRuleProvider _ruleProvider;

    public CommissionCalculatorService(ICommissionRuleProvider ruleProvider)
    {
        _ruleProvider = ruleProvider;
    }

    public SalesCommissionResult Calculate(SalesCommissionRequest request)
    {
        if (request.TotalSales < 0)
        {
            throw new InvalidOperationException("Las ventas totales no pueden ser negativas.");
        }

        if (request.Discounts < 0)
        {
            throw new InvalidOperationException("Los descuentos no pueden ser negativos.");
        }

        if (request.Discounts > request.TotalSales)
        {
            throw new InvalidOperationException("Los descuentos no pueden superar las ventas totales.");
        }

        var netSales = request.TotalSales - request.Discounts;
        var rule = _ruleProvider.GetRule(request.Country);
        var commission = rule.CalculateCommission(netSales);

        return new SalesCommissionResult(
            request.Country,
            request.TotalSales,
            request.Discounts,
            netSales,
            rule.Rate,
            commission);
    }
}
