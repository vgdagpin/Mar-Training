﻿using AutoMapper;
using ClassLibrary1.Application.Users.Commands;
using ClassLibrary1.Application.Users.Queries;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;

namespace ClassLibrary1.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection service)
        {
            service.AddMediatR(Assembly.GetExecutingAssembly());
            service.AddAutoMapper(Assembly.GetExecutingAssembly());

            return service;
        }
    }
}
