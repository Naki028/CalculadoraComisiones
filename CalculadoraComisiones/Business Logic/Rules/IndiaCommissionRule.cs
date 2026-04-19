using CalculadoraComisiones.Domain.Enums;

namespace CalculadoraComisiones.Domain.Rules;

public sealed class IndiaCommissionRule : CommissionRuleBase
{
    public IndiaCommissionRule() : base(SalesCountry.India, 0.10m)
    {
    }
}
