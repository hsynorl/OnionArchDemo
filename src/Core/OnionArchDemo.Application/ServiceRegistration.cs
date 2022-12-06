using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchDemo.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationRegistration(this IServiceCollection serviceDescriptors)
        {
            var assm=Assembly.GetExecutingAssembly();
            serviceDescriptors.AddAutoMapper(assm);
            serviceDescriptors.AddMediatR(assm);
        }
    }
}
