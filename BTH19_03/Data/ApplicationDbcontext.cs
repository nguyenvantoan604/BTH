using BTH19_03.Models;
using Microsoft.EntityFrameworkCore;

namespace BTH19_03.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
    public DbSet<Student> Students {get; set;}
    public DbSet<Persion> Persions {get;set;}


    public DbSet<Customer> Customers {get;set;}
}