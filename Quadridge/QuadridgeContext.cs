namespace Quadridge
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

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
            modelBuilder.Entity<Bank>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Firstname)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.CellNo)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.BusinessNo)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.FirstAddressLine)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.SecondAddressLine)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Zip)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Province)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.ClientInteractions)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ClientInteraction>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.AddressLine1)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.AddressLine2)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.Zip)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.Province)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<DealType>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<DealType>()
                .HasMany(e => e.Deals)
                .WithRequired(e => e.DealType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ExpenseType>()
                .Property(e => e.ExpenseType1)
                .IsUnicode(false);

            modelBuilder.Entity<ExpenseType>()
                .HasMany(e => e.Expenses)
                .WithRequired(e => e.ExpenseType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Interaction>()
                .Property(e => e.InteractionType)
                .IsUnicode(false);

            modelBuilder.Entity<Lawyer>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Lawyer>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<Lawyer>()
                .Property(e => e.Firm)
                .IsUnicode(false);

            modelBuilder.Entity<Lawyer>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Lawyer>()
                .Property(e => e.ContactNo)
                .IsUnicode(false);

            modelBuilder.Entity<Revenue>()
                .HasMany(e => e.Expenses)
                .WithRequired(e => e.Revenue)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Status>()
                .Property(e => e.StatusType)
                .IsUnicode(false);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.Deals)
                .WithRequired(e => e.Status)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}
