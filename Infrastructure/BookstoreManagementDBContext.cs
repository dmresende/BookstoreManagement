using BookstoreManagement.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookstoreManagement.Infrastructure;

public class BookstoreManagementDBContext : DbContext
{
    public DbSet<Book> Book { get; set; } = default!;
    public DbSet<Bookstore> Bookstore { get; set; } = default!;
    public DbSet<Client> Client { get; set; } = default!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source:C:\\dev\\BookstoreManagement\\BookStoreDB.db");
    }
}
