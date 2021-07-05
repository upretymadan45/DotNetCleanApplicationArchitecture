using Application.DataContext;
using Domain;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly IApplicationDbContext _context;

        public ProductRepository(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(Product product)
        {
            try
            {
                _context.Products.Add(product);
                await _context.SaveChangesAsync(new CancellationTokenSource().Token);
            }
            catch (Exception) { throw; }
        }

        public IEnumerable<Product> GetAll()
        {
            try
            {
                return _context.Products;
            }
            catch (Exception) { throw; }
        }
    }
}
