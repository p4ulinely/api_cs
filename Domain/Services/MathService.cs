using api.Domain.Interface;

namespace api.Domain.Services;

public class MathService : IMathService
{
    public int CalculaMultiplicacao(int a, int b)
    {
        return a+b;
    }

    public int CalculaSoma(int a, int b)
    {
        return a*b;
    }
}