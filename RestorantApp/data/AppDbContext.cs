using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestorantApp.Models;
using Microsoft.Extensions.Configuration;
namespace RestorantApp
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public AppDbContext() { }
        public DbSet<User> Users { get; set; }
      public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<EmployeeTask> EmployeeTasks { get; set; }
        public DbSet<OrderInfo> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
     public DbSet<ClientFeedback> ClientFeedbacks { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<OrderInfo>()
        .HasOne(o => o.User)               // property në OrderInfo që tregon User-in
        .WithMany(u => u.Orders)           
        .HasForeignKey(o => o.UserId);


        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=MELI\\SQLEXPRESS;Database=RestorantAppDb;User Id=sa;Password=Fjalekalim1!;Encrypt=False;TrustServerCertificate=True;");
            }
        }
    }
}