using System.Text.Json;
using Dsw2025Ej14.Api.Domain;

namespace Dsw2025Ej14.Api.Data
{
    public class PersistenciaEnMemoria : IPersistencia
    {
        private List<Product>? _products;

        public PersistenciaEnMemoria()
        {
            LoadProducts();
        }

        public List<Product>? GetProducts()
        {
            return _products?.Where(p => p.IsActive).ToList();
        }

        public Product? GetProductBySku(string sku)
        {
            return _products?.FirstOrDefault(p => p.Sku == sku && p.IsActive);
        }

        private void LoadProducts()
        {
            var json = File.ReadAllText("products.json");
            _products = JsonSerializer.Deserialize<List<Product>>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
        }
    }
}
