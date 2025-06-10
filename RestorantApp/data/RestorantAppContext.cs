using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestorantApp;
using RestorantApp.Models;
using Microsoft.EntityFrameworkCore;

namespace RestorantApp.Data
{
    public class RestorantAppContext : DbContext
    {
        public RestorantAppContext(DbContextOptions<RestorantAppContext> options)
            : base(options)
        {
        }
       
     
        public DbSet<User> Users { get; set; }

    }
}
