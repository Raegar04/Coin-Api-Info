﻿using Application.Abstractions;
using Application.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class DependencyInjection
{
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddScoped<ICryptoCurrencyService, CryptoCurrencyService>();
    }
}
