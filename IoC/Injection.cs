using api.Domain.Interface;
using api.Domain.Services;

namespace api.IoC;

public static class Injection
{
    public static void RegisterOwnServices(this IServiceCollection services)
    {
        services.AddScoped<IMathService, MathService>();
        services.AddScoped<ITextService, TextService>();
    }
}