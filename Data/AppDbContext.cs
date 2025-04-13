// Caminho: Data/AppDbContext.cs
using Microsoft.EntityFrameworkCore;
using BookGrap.Models; // faz o pedido para o usuario em Models

namespace BookGrap.Data;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Usuario> Usuarios { get; set; }
}
