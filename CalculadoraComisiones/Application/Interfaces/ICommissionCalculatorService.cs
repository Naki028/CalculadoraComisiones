using CalculadoraComisiones.Domain.Models;

namespace CalculadoraComisiones.Application.Interfaces;

public interface ICommissionCalculatorService
{
    SalesCommissionResult Calculate(SalesCommissionRequest request);
}
