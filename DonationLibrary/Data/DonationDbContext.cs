using DonationLibrary.Model;
using DonationLibrary.Donation;

namespace DonationLibrary.Data
{
    public class DonationDbContext : DbContext
    {
        public DonationDbContext(DbContextOptions<DonationDbContext> options) : base(options)
        {
        }

        public DbSet<Donations> Donations { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<TransactionType> TransactionTypes { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Donations>().ToTable("Donations");
            modelBuilder.Entity<Contact>().ToTable("Contact");
            modelBuilder.Entity<TransactionType>().ToTable("TransactionType");
            modelBuilder.Entity<PaymentMethod>().ToTable("PaymentMethod");

            // base.OnModelCreating(modelBuilder);
            // modelBuilder.Seed();
            
            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    AccoutNo = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "JDoe@gmail.com",
                    Street = "1234 Main St",
                    City = "New York",
                    PostalCode = "12345",
                    Country = "USA"
                },
                new Contact
                {
                    AccoutNo = 2,
                    FirstName = "Jane",
                    LastName = "Doe",
                    Email = "JaDoe@gmail.com",
                    Street = "1236 Main St",
                    City = "New York",
                    PostalCode = "12347",
                    Country = "USA"
                },
                new Contact
                {
                    AccoutNo = 3,
                    FirstName = "John",
                    LastName = "Smith",
                    Email = "JSmith@gmail.com",
                    Street = "1324 Main St",
                    City = "New York",
                    PostalCode = "13245",
                    Country = "USA"
                }
            );

            modelBuilder.Entity<TransactionType>().HasData(
                new TransactionType
                {
                    TransactionTypeId = 1,
                    Name = "Donation",
                    Description = "Donation"
                },
                new TransactionType
                {
                    TransactionTypeId = 2,
                    Name = "Membership",
                    Description = "Membership"
                },
                new TransactionType
                {
                    TransactionTypeId = 3,
                    Name = "Event",
                    Description = "Event"
                }
            );

            modelBuilder.Entity<PaymentMethod>().HasData(
                new PaymentMethod
                {
                    PaymentMethodId = 1,
                    Name = "Cash"
                },
                new PaymentMethod
                {
                    PaymentMethodId = 2,
                    Name = "Credit Card"
                },
                new PaymentMethod
                {
                    PaymentMethodId = 3,
                    Name = "PayPal"
                }
            );

            modelBuilder.Entity<Donations>().HasData(
                new Donations
                {
                    TransId = 1,
                    Date = new DateTime(2020, 1, 1,10,45,0),
                    AccountNo = 1,
                    TransactionTypeId = 1,
                    Amount = 100,
                    PaymentMethodId = 1,
                    Notes = "Donation for the month of January"
                },
                new Donations
                {
                    TransId = 2,
                    Date = new DateTime(2020, 2, 1,10,45,0),
                    AccountNo = 1,
                    TransactionTypeId = 1,
                    Amount = 100,
                    PaymentMethodId = 1,
                    Notes = "Donation for the month of February"
                },
                new Donations
                {
                    TransId = 3,
                    Date = new DateTime(2020, 3, 1,10,45,0),
                    AccountNo = 1,
                    TransactionTypeId = 1,
                    Amount = 100,
                    PaymentMethodId = 1,
                    Notes = "Donation for the month of March"
                }
                );
        }
    }
}
