using CalculadoraComisiones.Domain.Interfaces;
using CalculadoraComisiones.Domain.Enums;

namespace CalculadoraComisiones.Infrastructure.Abstractions;

public interface ICommissionRuleProvider
{
    ICommissionRule GetRule(SalesCountry country);

    IReadOnlyCollection<ICommissionRule> GetAllRules();
}
