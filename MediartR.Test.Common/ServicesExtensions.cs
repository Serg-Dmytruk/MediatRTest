using AutoMapper;
using Common.MapperProfiles;
using Data.Common.GlobalDbServices.UserDbServices;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace MediartR.Test.Common
{
    public static class ServicesExtensions
    {
        public static IServiceCollection AddMediator(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

            return services;
        }

        public static IServiceCollection AddMapper(this IServiceCollection services )
        {
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            return services;
        }

        public static IServiceCollection AddDbServices(this IServiceCollection services)
        {
            services.AddScoped<IUserDbService, UserDbService>();
            return services;
        }
    }
}
