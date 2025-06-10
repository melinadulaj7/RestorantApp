using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
using RestorantApp.Forms;
using BCrypt.Net;
namespace RestorantApp.Models
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration((context, config) =>
                {
                    config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                })
                .ConfigureServices((context, services) =>
                {
                    var connectionString = context.Configuration.GetConnectionString("RestorantAppDb");
                    services.AddDbContext<AppDbContext>(options =>
                        options.UseSqlServer(connectionString));

                    // Regjistro formën e login-it dhe dashboard-et
                    services.AddTransient<LoginForm>();
                    services.AddTransient<EmployeeDashboard>();
                    services.AddTransient<AdminDashboard>();
                    services.AddTransient<UserManagmentForm>();

                    // Mos regjistro FinancialReportsForm (ose InvoiceForm), pasi ti do ta fshish
                    // services.AddTransient<FinancialReportsForm>();  <-- hequr
                })
                .Build();
            using (var context = new AppDbContext())
            {
                // Kontrollo nëse ka menu items tashmë
                if (!context.MenuItems.Any())
                {
                    var items = new List<MenuItem>
        {
            new MenuItem { Name = "Pizza Margherita", Price = 7.5m, CostPrice = 3m, IsAvailable = true },
            new MenuItem { Name = "Burger Classic", Price = 5.0m, CostPrice = 2.5m, IsAvailable = true },
            new MenuItem { Name = "Salad Caesar", Price = 4.0m, CostPrice = 1.5m, IsAvailable = true },
            new MenuItem { Name = "Pasta Carbonara", Price = 6.5m, CostPrice = 2.8m, IsAvailable = true }
        };

                    context.MenuItems.AddRange(items);
                    context.SaveChanges();
                }
            }
            using (var scope = host.Services.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                db.Database.EnsureCreated();

                SeedMenuItems(db);
                // Nuk do të bëjmë seed për porosi këtu, sepse po i fshin nga ti
            }

            var serviceProvider = host.Services;
            var loginForm = serviceProvider.GetRequiredService<LoginForm>();
            Application.Run(loginForm);
        }

        private static void SeedMenuItems(AppDbContext context)
        {
            if (!context.MenuItems.Any())
            {
                context.MenuItems.AddRange(
                    new MenuItem
                    {
                        Name = "Pizza Margherita",
                        Description = "Pica tradicionale me domate dhe djathë",
                        Price = 5.99m,
                        Category = "Pjata Kryesore",
                        IsAvailable = true
                    },
                    new MenuItem
                    {
                        Name = "Spaghetti Carbonara",
                        Description = "Spaghetti me vezë, djathë dhe pancetta",
                        Price = 7.99m,
                        Category = "Pjata Kryesore",
                        IsAvailable = true
                    },
                    new MenuItem
                    {
                        Name = "Saladë Greke",
                        Description = "Saladë me domate, kastravec, ullinj dhe djathë feta",
                        Price = 4.50m,
                        Category = "Parapjata",
                        IsAvailable = true
                    }
                );
                context.SaveChanges();
            }
        }
    }
}