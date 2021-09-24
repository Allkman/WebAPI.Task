using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.AutoMapper
{
    public static class AutoMapperExtension
    {
        public static IServiceCollection ConfigureAutomapper(this IServiceCollection services)
        {

            services.AddAutoMapper(
                typeof(EventMapperProfile));
            return services;
        }
    }
}
