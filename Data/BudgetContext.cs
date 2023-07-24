using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HomeAutomation.Models;

namespace HomeAutomation.Data
{
    public class BudgetContext : DbContext
    {
        public BudgetContext (DbContextOptions<BudgetContext> options)
            : base(options)
        {
        }

        public DbSet<HomeAutomation.Models.Client> Client { get; set; } = default!;        
        public DbSet<HomeAutomation.Models.Service> Services { get; set; } = default!;
        public DbSet<HomeAutomation.Models.Budget> Budgets { get; set; } = default!;
        public DbSet<HomeAutomation.Models.Item> Itens { get; set; } = default!;
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().ToTable("Client");
            modelBuilder.Entity<Service>().ToTable("Service");
            modelBuilder.Entity<Budget>().ToTable("Budget");
            modelBuilder.Entity<Item>().ToTable("Item");
            
        }
        /*
        public DbSet<HomeAutomation.Models.Service> Services { get; set; } = default!;
        public DbSet<HomeAutomation.Models.Budget> Budgets { get; set; } = default!;
        public DbSet<HomeAutomation.Models.Item> Itens { get; set; } = default!;
        */

    }
}
