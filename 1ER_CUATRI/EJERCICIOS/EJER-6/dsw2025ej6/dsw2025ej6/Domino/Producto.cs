using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsw2025ej6.Domino
{
    public class Producto
    {

        private long _codigoProducto;
        private string _descripcion;
        private bool _activo;
        private double _precioVenta;
        private float _impuesto = 0.21f;
        private int _stock;
        private char _presentacion;
        private DateTime _fechaAlta;

        public long CodigoProducto { get => _codigoProducto; set => _codigoProducto = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public bool Activo { get => _activo; set => _activo = value; }
        public double PrecioVenta { get => _precioVenta; set => _precioVenta = value; }
        public float Impuesto { get => _impuesto; set => _impuesto = value; }
        public int Stock { get => _stock; set => _stock = value; }
        public char Presentacion { get => _presentacion; set => _presentacion = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }

        public double mostrarPrecioSInImpuesto()
        {
            double precioSinImp = PrecioVenta - (PrecioVenta * Impuesto);
            return precioSinImp;
        }

        public void mostrarProducto()
        {
            string mensaje = $"[{_codigoProducto}][{Descripcion}][{_presentacion}]";
            Console.WriteLine(mensaje);
        }

        public void aumentarStock(int valor)
        {
            Stock = Stock + valor;
            Console.WriteLine($"El stock aumentado es: {Stock}");
        }

        public void decreceStock(int valor)
        {
            Stock = Stock - valor;
            Console.WriteLine($"El stock decrecido es: {Stock}");
        }

        public void agregarStockPorc(int valor)
        {
            Stock =(Stock + Stock * valor/100);
            Console.WriteLine($"El % stock aumentado es: {Stock}");
        }
    }
}
