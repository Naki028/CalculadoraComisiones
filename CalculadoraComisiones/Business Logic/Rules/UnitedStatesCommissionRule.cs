using CalculadoraComisiones.Domain.Enums;

namespace CalculadoraComisiones.Domain.Rules;

public sealed class UnitedStatesCommissionRule : CommissionRuleBase
{
    public UnitedStatesCommissionRule() : base(SalesCountry.UnitedStates, 0.15m)
    {
    }
}
