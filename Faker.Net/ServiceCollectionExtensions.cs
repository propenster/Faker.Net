using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using Faker.Net.Attributes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Faker.Net
{
    public static class ServiceCollectionExtensions
    {
        //public static IServiceCollection AddAutoMapper(this IServiceCollection services, Action<IMapperConfigurationExpression> configAction, params Type[] profileAssemblyMarkerTypes)
        //    => AddAutoMapperClasses(services, (sp, cfg) => configAction?.Invoke(cfg), profileAssemblyMarkerTypes.Select(t => t.GetTypeInfo().Assembly));
        public static IServiceCollection AddFakerFactory(this IServiceCollection services)
          
        {
            //return AddIdentityMongoDbProvider<TUser, TRole, TKey>(services, x => { }, setupDatabaseAction);
            return services.AddSingleton<IFakerFactory>(x => new FakerFactory());
        }

      
        






    }
}

