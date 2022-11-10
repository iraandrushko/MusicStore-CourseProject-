using Microsoft.Extensions.DependencyInjection;
using MusicStore.BLL.Services;
using System;
using System.Windows.Forms;

namespace MusicStore.WinForms
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            var services = new ServiceCollection();
            ConfigureServices(services);
            ServiceProvider = services.BuildServiceProvider();

            Application.Run(ServiceProvider.GetRequiredService<MainForm>());
        }

        public static ServiceProvider ServiceProvider { get; private set; }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<IApplicationContext, ApplicationContext>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IAlbumService, AlbumService>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IAuthenticationService, AuthenticationService>();

            services.AddTransient<LoginForm>();
            services.AddTransient<RegisterForm>();
            services.AddTransient<ResetPasswordForm>();
            services.AddTransient<MyOrdersForm>();
            services.AddTransient<MainForm>();
        }

    }
}
