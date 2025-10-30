using Dsw2025Ej13.Data;
using Dsw2025Ej13.Domain.Interfaces;
using Dsw2025Ej13.Presentation.Views;
using Dsw2025Ej13.Presentation.Controllers;
using Microsoft.Extensions.DependencyInjection;
using Dsw2025Ej13.Presentation.Interfaces;


namespace Dsw2025Ej13;

internal class Program
{
    
    static void Main(string[] args)
    {
        var service = new ServiceCollection();
        service.AddTransient<IPersistencia,PersistenciaEnMemoria>(); 
                            //donde haya una persistencia
                            // se inyecta una PersistenciaEnMemoria
        service.AddTransient<MenuView>();
        service.AddTransient<MenuControlador>();
        service.AddTransient<ListarAnimalesControlador>();
        service.AddTransient<IListarAnimalesViews, ListarAnimalesViews>();
        service.AddTransient<IMenuView, MenuView>();


        var provider = service.BuildServiceProvider();
        var console = provider.GetService<MenuControlador>();

    }
}
