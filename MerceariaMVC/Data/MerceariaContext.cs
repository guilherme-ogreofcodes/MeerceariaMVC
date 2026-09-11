using MerceariaMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace MerceariaMVC.Data
{
    public class MerceariaContext:DbContext
    {
        public MerceariaContext(DbContextOptions<MerceariaContext> options) : base(options) 
        {
        }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Cliente> Clientes { get; set;}
    }
}

