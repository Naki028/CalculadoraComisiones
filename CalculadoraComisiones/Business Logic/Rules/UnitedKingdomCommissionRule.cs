using CalculadoraComisiones.Domain.Enums;

namespace CalculadoraComisiones.Domain.Rules;

public sealed class UnitedKingdomCommissionRule : CommissionRuleBase
{
    public UnitedKingdomCommissionRule() : base(SalesCountry.UnitedKingdom, 0.12m)
    {
    }
}
