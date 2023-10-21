using ApiNet7WithJwtAndIdentity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ApiNet7WithJwtAndIdentity.Context
{
  public class AuthIdentityDbContext : IdentityDbContext
  {
    public AuthIdentityDbContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<Employee> Employees { get; set; }
  }
}
