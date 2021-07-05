using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WebUI.Installer
{
    public interface IInstaller
    {
        void RegisterDi(IServiceCollection service, IConfiguration configuration);
    }
}
