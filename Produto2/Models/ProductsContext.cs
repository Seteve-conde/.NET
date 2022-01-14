using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
namespace Produto2.Models
{
    public class ProductsContext : DbContext
    {
        public ProductsContext(DbContextOptions<ProductsContext> options)
            : base(options)
        {

        }
        public DbSet<Products> Product { get; set; } = null!;
    }

    
    
}
