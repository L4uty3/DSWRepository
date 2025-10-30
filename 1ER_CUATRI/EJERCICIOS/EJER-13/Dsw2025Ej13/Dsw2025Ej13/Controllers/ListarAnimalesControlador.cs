using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dsw2025Ej13.Domain.Entities;
using Dsw2025Ej13.Domain.Interfaces;
using Dsw2025Ej13.Presentation.Interfaces;
using Dsw2025Ej13.Presentation.Models;

namespace Dsw2025Ej13.Presentation.Controllers
{
    public class ListarAnimalesControlador
    {
        private IPersistencia _persistencia;
        private IListarAnimalesViews _vista;
        public ListarAnimalesControlador(IPersistencia persistencia,IListarAnimalesViews vista)
        {
            _persistencia = persistencia;
        }
        public List<AnimalViewModel> ObtenerAnimales()
        {
            List<AnimalViewModel> animales = [];
            foreach (var animal in _persistencia.GetMamiferos())
            {
                animales.Add(new AnimalViewModel(animal));
            }
            return animales;
        }

        public ComidaViewModel CalcularComida()
        {
            double totalCarnivoros = _persistencia.GetTotalComida(TipoAlimentacion.CARNIVORO);
            double totalHerbivoros = _persistencia.GetTotalComida(TipoAlimentacion.HERBIVORO);
            return new ComidaViewModel(totalCarnivoros, totalHerbivoros);
        }
    }
}
