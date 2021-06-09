using System.Data.Entity;

// ReSharper disable RedundantBaseConstructorCall
// ReSharper disable EmptyConstructor
// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace GestionareMagazin.EF
{
    public class ContactsContext : DbContext
    {
        public ContactsContext() : base()
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Person> Persons { get; set; }
    }
}