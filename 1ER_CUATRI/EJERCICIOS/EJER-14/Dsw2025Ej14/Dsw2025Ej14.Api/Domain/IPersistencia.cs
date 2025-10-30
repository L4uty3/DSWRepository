namespace Dsw2025Ej14.Api.Domain
{
    public interface IPersistencia
    {
        Product? GetProductBySku(string sku);
        List<Product>? GetProducts();
    }
}