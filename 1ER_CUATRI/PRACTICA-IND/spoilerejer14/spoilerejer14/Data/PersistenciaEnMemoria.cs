using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using spoilerejer14.Domain;

namespace spoilerejer14.Data
{
    internal class PersistenciaEnMemoria
    {
        public async Task<Product> LoadProducts()
        {
            var json = await File.ReadAllTextAsync("products.json");
            var products = JsonSerializer.Deserialize<List<Product>>(json);

            return products?.AddRabge() ?? new Product
            {
                Sku = "default-sku",
                Name = "Default Product",
                CurrentUnitPrice = 0.0m,
                IsActive = true
            };
        }
    }
}
