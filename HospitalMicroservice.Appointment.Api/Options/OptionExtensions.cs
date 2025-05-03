﻿using Microsoft.Extensions.Options;

namespace HospitalMicroservice.Patient.Api.Options;

public static class OptionExtensions
{
    public static IServiceCollection AddOptionExtension(this IServiceCollection services)
    {
        services.AddOptions<MongoOption>().BindConfiguration(nameof(MongoOption)).ValidateDataAnnotations().ValidateOnStart();
        services.AddSingleton(sp => sp.GetRequiredService<IOptions<MongoOption>>().Value);
        return services;
    }
}
