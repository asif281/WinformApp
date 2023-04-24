using BAL.Services.HttpService;
using BAL.Services.UserService;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace Bwhere2023
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run();

           // Application.Run(new FormLogin());


            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<FormLogin>());
        }

        public static IServiceProvider? ServiceProvider { get; private set; }
       
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddTransient<IEasyHttpClient, EasyHttpClient>();
                    services.AddTransient<IUserService, UserService>();
                    services.AddTransient<FormLogin>();
                    services.AddTransient<MinimizeForm>();
                    services.AddTransient<CustomerForm>();
                });
        }
    }
}