using Microsoft.EntityFrameworkCore;

namespace QuickAzureDBApi.Entities
{
    public class PersonDbContext : DbContext
    {

        public PersonDbContext(DbContextOptions<PersonDbContext> options) :
            base(options)
        {
        }

        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Person>().HasData(new Person
            {
                Id = 1,
                FirstName = "Fred",
                LastName = "Flintstone"
            });
            modelBuilder.Entity<Person>().HasData(new Person
            {
                Id = 2,
                FirstName = "Wilma",
                LastName = "Flintstone"
            });
            modelBuilder.Entity<Person>().HasData(new Person
            {
                Id = 3,
                FirstName = "Barney",
                LastName = "Rubble"
            });
            modelBuilder.Entity<Person>().HasData(new Person
            {
                Id = 4,
                FirstName = "Betty",
                LastName = "Rubble"
            });
        }
    }
}
