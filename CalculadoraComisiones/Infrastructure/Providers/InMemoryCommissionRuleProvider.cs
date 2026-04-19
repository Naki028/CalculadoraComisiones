using CalculadoraComisiones.Domain.Interfaces;
using CalculadoraComisiones.Domain.Enums;
using CalculadoraComisiones.Infrastructure.Abstractions;

namespace CalculadoraComisiones.Infrastructure.Providers;

public sealed class InMemoryCommissionRuleProvider : ICommissionRuleProvider
{
    private readonly IReadOnlyDictionary<SalesCountry, ICommissionRule> _rules;

    public InMemoryCommissionRuleProvider(IEnumerable<ICommissionRule> rules)
    {
        _rules = rules.ToDictionary(rule => rule.Country);
    }

    public IReadOnlyCollection<ICommissionRule> GetAllRules() => _rules.Values.ToList();

    public ICommissionRule GetRule(SalesCountry country)
    {
        return _rules.TryGetValue(country, out var rule)
            ? rule
            : new FallbackCommissionRule(country);
    }

    private sealed class FallbackCommissionRule : ICommissionRule
    {
        public FallbackCommissionRule(SalesCountry country)
        {
            Country = country;
        }

        public SalesCountry Country { get; }

        public decimal Rate => 0m;

        public decimal CalculateCommission(decimal netSales) => 0m;
    }
}
