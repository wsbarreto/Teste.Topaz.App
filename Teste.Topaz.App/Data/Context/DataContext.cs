using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.SqlClient;

namespace Teste.Topaz.App.Data.Context;

public class DataContext : DbContext
{
    private readonly string connectionString = WebApplication.CreateBuilder().Configuration.GetSection("ConnectionStrings")["connectionString"];

    public IDbConnection CreateConnection() => new SqlConnection(connectionString);

    public DataContext CreateDbContext() => new DataContext(new DbContextOptionsBuilder().UseSqlServer(connectionString).Options);

    public DataContext(DbContextOptions options) : base(options)
    {
        var www = options.Extensions;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.HasDefaultSchema("TOPAZ");
    }
}
