using Application.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Installer
{
    public class RepositoryInstaller : IInstaller
    {
        public void RegisterDi(IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IProductRepository, ProductRepository>();
        }
    }
}
