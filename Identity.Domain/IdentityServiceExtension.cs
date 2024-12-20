﻿using Identity.Domain.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Domain
{
    public static class IdentityServiceExtension
    {
        public static IServiceCollection AddIdentityServices (this IServiceCollection services)
        {
            services.AddScoped<IClientService, ClientService>();
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IUserTokenService, UserTokenService>();

            return services;
        }
    }
}
