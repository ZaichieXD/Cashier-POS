using Microsoft.EntityFrameworkCore;
using Cashier_POS.Models;

namespace Cashier_POS.Persistence;

public class CashierPosDBContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CashierPOS;Trusted_Connection=True;MultipleActiveResultSets=true;");
    }

    public DbSet<UserModel> Users { get; set; }
}