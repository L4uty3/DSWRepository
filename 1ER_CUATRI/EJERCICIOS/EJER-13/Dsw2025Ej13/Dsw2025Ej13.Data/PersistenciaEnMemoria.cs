﻿using Dsw2025Ej13.Domain.Entities;
using Dsw2025Ej13.Domain.Interfaces;

namespace Dsw2025Ej13.Data;

public class PersistenciaEnMemoria : IPersistencia
{
    private const string Archivo = "..\\..\\..\\..\\Dsw2025Ej13.Data\\Animales.txt";
    private List<Especie> _especies = [];
    private List<Mamifero> _mamiferos = [];
    private List<Sector> _sectores = [];

    public PersistenciaEnMemoria()
    {
        InicializarEspecies();
        InicializarSectores();
        CargarAnimalesDeArchivo();
    }

    private void InicializarEspecies()
    {
        _especies.Add(new Especie(1, "León", 0.2, TipoAlimentacion.CARNIVORO));
        _especies.Add(new Especie(2, "Jirafa", 0, TipoAlimentacion.HERBIVORO));
        _especies.Add(new Especie(3, "Tigre", 0.15, TipoAlimentacion.CARNIVORO));
        _especies.Add(new Especie(4, "Elefante", 0, TipoAlimentacion.HERBIVORO));
    }

    private void InicializarSectores()
    {
        Empleado raul = new("Raul A", "20111222", "Tucumán");
        Empleado maria = new("Maria B", "30111222", "Tucumán");
        _sectores.Add(new Sector(1, -26.250724, -65.522827, 10, TipoAlimentacion.HERBIVORO, raul));
        _sectores.Add(new Sector(2, -26.252359, -65.521511, 10, TipoAlimentacion.CARNIVORO, maria));
        _sectores.Add(new Sector(3, -26.254661, -65.522726, 10, TipoAlimentacion.HERBIVORO, maria));
        _sectores.Add(new Sector(4, -26.257250, -65.523514, 10, TipoAlimentacion.CARNIVORO, raul));
    }

    private void CargarAnimalesDeArchivo()
    {
        string[] animales = File.ReadAllLines(Archivo);
        foreach (var animal in animales)
        {
            string[] datos = animal.Split(',');
            Mamifero? mamifero;
            if (ParseInt(datos[0]) == (int)TipoAlimentacion.CARNIVORO)
            {
                mamifero = new Carnivoro(
                     ParseInt(datos[1]),
                     ParseDouble(datos[2]),
                     GetEspecie(ParseInt(datos[3])),
                     GetSector(ParseInt(datos[4])));
            }
            else
            {
                mamifero = new Herbivoro(
                     ParseInt(datos[1]),
                     ParseDouble(datos[2]),
                     GetEspecie(ParseInt(datos[3])),
                     GetSector(ParseInt(datos[4])),
                     ParseDouble(datos[5]));
            }
            _mamiferos.Add(mamifero);
        }
    }

    public Especie? GetEspecie(int codigo)
    {
        foreach (Especie especie in _especies)
        {
            if (especie.GetCodigo() == codigo)
            {
                return especie;
            }
        }
        return null;
    }
    public Sector? GetSector(int numero)
    {
        foreach (Sector sector in _sectores)
        {
            if (sector.GetNumero() == numero)
            {
                return sector;
            }
        }
        return null;
    }
    public List<Mamifero> GetMamiferos()
    {
        return _mamiferos;
    }
    private int ParseInt(string? valor)
    {
        return int.TryParse(valor, out int resultado) ? resultado : 0;
    }
    private double ParseDouble(string? valor)
    {
        return double.TryParse(valor, out double resultado) ? resultado : 0.0;
    }
    public double GetTotalComida(TipoAlimentacion tipoAlimentacion)
    {
        double total = 0;
        foreach (Mamifero animal in _mamiferos)
        {
            total += animal.TieneAlimentacion(tipoAlimentacion) ? animal.CalcularCantidadDeComida() : 0;
        }
        return total;
    }
}
