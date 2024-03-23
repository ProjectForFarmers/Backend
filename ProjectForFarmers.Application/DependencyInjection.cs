﻿using FarmersMarketplace.Application.Services;
using FarmersMarketplace.Application.Services.Auth;
using FarmersMarketplace.Application.Services.Business;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using FarmersMarketplace.Application.Mappings;

namespace FarmersMarketplace.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IAuthService, AuthService>();
            services.AddTransient<IFarmService, FarmService>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<ISubcategoryService, SubcategoryService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IDashboardService, DashboardService>();
            services.AddTransient<IAccountService, AccountService>();

            services.AddAutoMapper(config =>
            {
                config.AddProfile(new FarmMappingProfile());
                config.AddProfile(new OrderMappingProfile());
                config.AddProfile(new CategoryMappingProfile());
                config.AddProfile(new ProductMappingProfile());
            });

            return services;
        }
    }
}
