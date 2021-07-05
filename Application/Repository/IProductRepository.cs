using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Task CreateAsync(Product product);
    }
}
