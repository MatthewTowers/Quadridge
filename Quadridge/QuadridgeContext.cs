namespace Quadridge
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Quadridge.EntityConfigurations;
    using Microsoft.AspNet.Identity.EntityFramework;

    public partial class QuadridgeContext : DbContext
    {
        public QuadridgeContext()
            : base("name=QuadridgeContext")
        {
        }

        public virtual DbSet<Bank> Banks { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<ClientInteraction> ClientInteractions { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Deal> Deals { get; set; }
        public virtual DbSet<DealType> DealTypes { get; set; }
        public virtual DbSet<Expense> Expenses { get; set; }
        public virtual DbSet<ExpenseType> ExpenseTypes { get; set; }
        public virtual DbSet<Interaction> Interactions { get; set; }
        public virtual DbSet<Lawyer> Lawyers { get; set; }
        public virtual DbSet<Revenue> Revenues { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BankConfiguration());
            modelBuilder.Configurations.Add(new ClientConfiguration());
            modelBuilder.Configurations.Add(new ClientInteractionConfiguration());
            modelBuilder.Configurations.Add(new CompanyConfiguration());
            modelBuilder.Configurations.Add(new DealTypeConfiguration());
            modelBuilder.Configurations.Add(new ExpenseTypeConfiguration());
            modelBuilder.Configurations.Add(new InteractionConfiguration());
            modelBuilder.Configurations.Add(new LawyerConfiguration());
            modelBuilder.Configurations.Add(new RevenueConfiguration());
            modelBuilder.Configurations.Add(new StatusConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
        }
    }
}
