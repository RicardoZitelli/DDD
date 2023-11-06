using DDD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

namespace DDD.Infrastructure.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {

        }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {           
        }

        public DbSet<Customer>? Clientes { get; set; }  
        public DbSet<Product>? Produtos { get; set; }
        public DbSet<ProductType>? TipoProdutos { get; set; }
    }
}
