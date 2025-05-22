﻿using BarberBoss.Application.AutoMapper;
using BarberBoss.Application.UseCases.Expenses.Delete;
using BarberBoss.Application.UseCases.Expenses.GetAll;
using BarberBoss.Application.UseCases.Expenses.GetById;
using BarberBoss.Application.UseCases.Expenses.Register;
using BarberBoss.Application.UseCases.Expenses.Update;
using Microsoft.Extensions.DependencyInjection;

namespace BarberBoss.Application
{
    public static class DependencyInjectionExtension
    {
        public static void AddApplication(this IServiceCollection services)
        {
            AddAutoMapper(services);
            AddUseCases(services);
        }

        private static void AddAutoMapper(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapping));
        }

        private static void AddUseCases(IServiceCollection services)
        {
            services.AddScoped<IRegisterExpenseUseCase, RegisterExpenseUseCase>();
            services.AddScoped<IGetAllExpenseUseCase, GetAllExpenseUseCase>();
            services.AddScoped<IGetExpenseByIdUseCase, GetExpenseByIdUseCase>();
            services.AddScoped<IDeleteExpenseUseCase, DeleteExpenseUseCase>();
            services.AddScoped<IUpdateExpenseUseCase, UpdateExpenseUseCase>();
        }
    }
}