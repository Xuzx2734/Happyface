using AutoMapper;
using Contracts;
using Entities;
using CoreWeb.Filter;
using LoggerService;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts.ServiceContract;
using System.Reflection;

namespace CoreWeb.ServiceConfig
{
    public static class ServiceExtensions
    {
        /// <summary>
        ///  Cross-Origin Resource Sharing Configure
        /// </summary>
        /// <param name="services"></param>
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowCredentials());
            });
        }

        /// <summary>
        /// IIS mode config
        /// </summary>
        /// <param name="services"></param>
        public static void ConfigureIISIntergration(this IServiceCollection services)
        {
            services.Configure<IISOptions>(options =>{});
        }

        /// <summary>
        /// connectstr config
        /// </summary>
        /// <param name="services"></param>
        /// <param name="config"></param>
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration config)
        {
            var conDic = config.GetSection("sqlconnection").Get<Dictionary<string, string>>();
            
            Action<DbContextOptionsBuilder> optionBuilder = null;
            foreach(var item in conDic)
            {
                if (!string.IsNullOrEmpty(item.Value))
                {
                    if ("SqlServerconnectionstring".Equals(item.Key))
                    {
                        optionBuilder = options => options.UseSqlServer(item.Value);
                    }
                    else if ("MySqlconnectionstring".Equals(item.Key))
                    {
                        optionBuilder = options => options.UseMySql(item.Value);
                    }
                }
            }

            if (optionBuilder == null) throw new Exception("sqlconnection need to config in appsettings.json");

            ////if you want to register multiple context type here , you should use generic context parameter in your ctor.           
            services.AddDbContext<RepositoryContext>(optionBuilder);
        }

        /// <summary>
        ///  logger config
        /// </summary>
        /// <param name="services"></param>
        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerManager, LoggerManager>();
        }

        /// <summary>
        /// repo config
        /// </summary>
        /// <param name="services"></param>
        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }

        /// <summary>
        /// action filter config
        /// </summary>
        /// <param name="services"></param>
        public static void ConfigureActionFilter(this IServiceCollection services)
        {
            services.AddScoped<ActionFilter>();
        }

        /// <summary>
        /// authorization filter config
        /// </summary>
        /// <param name="services"></param>
        public static void ConfigureAuthorizationFilter(this IServiceCollection services)
        {
            services.AddScoped<AuthorizationFilter>();
        }

        /// <summary>
        /// service DI
        /// </summary>
        /// <param name="services"></param>
        public static void ConfigureServicesContainer(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();

            // if not declare DI above ; all interface will be DI under the  namespace of Contracts.ServiceContract
            var serviceList = services.Where(x => x.ServiceType.Namespace == "Contracts.ServiceContract").Select(x => x.ServiceType.Name).ToList();
            if (serviceList.Any()){
                Assembly assembly = Assembly.Load("Contracts");
                var serviceContractList = assembly.GetTypes().Where(x => x.Namespace == "Contracts.ServiceContract").ToList();
                if (serviceContractList.Any())
                {
                    Assembly serviceAssembly = Assembly.Load("Services");
                    foreach(var item in serviceContractList.Where(x => !serviceList.Contains(x.Name)))
                    {
                        var serviceType = serviceAssembly.GetType($"Services.{item.Name.Substring(1)}");
                        if(serviceType != null)
                        {
                            services.AddTransient(item.GetType(), serviceType);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// config automapper mapping relationship
        /// </summary>
        /// <param name="services"></param>
        public static void ConfigureAutoMapper(this IServiceCollection services)
        {
            var config = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfileConfig());
            });

            var mapper = config.CreateMapper();

            services.AddSingleton(mapper);

        }

    }
}
