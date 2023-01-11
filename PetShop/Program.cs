using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using PetShop.Data;
using PetShop.Forms;
using PetShop.Forms.Angajati;

namespace PetShop
{
    internal static class Program
    {
        public static ServiceProvider ServiceProvider { get; private set; }

        public static void ConfigureServices()
        {
            var services=new ServiceCollection();
            services.AddDbContext<DBContext>();
            services.AddScoped<IInitializer,Initializer>();
            ServiceProvider=services.BuildServiceProvider();
            ValidatorOptions.Global.DefaultClassLevelCascadeMode = CascadeMode.StopOnFirstFailure;
        }

        public static void SeedDB()
        {
            ServiceProvider.GetRequiredService<IInitializer>().Init();
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ConfigureServices();
            SeedDB();
            ApplicationConfiguration.Initialize();
            var first_form = new LoginForm();
            first_form.Show();
            Application.Run();
        }
    }
}