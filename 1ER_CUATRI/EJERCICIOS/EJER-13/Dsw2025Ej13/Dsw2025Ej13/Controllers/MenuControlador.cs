using System.Runtime.CompilerServices;
using Dsw2025Ej13.Data;
using Dsw2025Ej13.Domain.Entities;
using Dsw2025Ej13.Domain.Interfaces;
using Dsw2025Ej13.Presentation.Interfaces;
using Dsw2025Ej13.Presentation.Models;

namespace Dsw2025Ej13.Presentation.Controllers;

public class MenuControlador
{
    private IMenuView _vista;
    public MenuControlador(IMenuView vista)
    {
        _vista = vista;
        _vista.DibujarMenu();
    }
}
