using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Installer
{
    public interface IInstaller
    {
        void RegisterDi(IServiceCollection services, IConfiguration configuration);
    }
}
