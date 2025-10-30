using Dsw2025Ej14.Api.Data;
using Dsw2025Ej14.Api.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Dsw2025Ej14.Api.Controllers;

[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IPersistencia _persistencia;
    public ProductsController(IPersistencia persistencia)
    {
        _persistencia = persistencia;
    }

    [HttpGet("api/Product")]
    public IActionResult GetProduct()
    {
        var products = _persistencia.GetProducts();
        if (products == null || !products.Any()) return NoContent();
        return Ok(products);
    }

    [HttpGet("api/Product/{sku}")]
    public IActionResult GetProductBySku(string sku)
    {
        var product = _persistencia.GetProductBySku(sku);
        if (product == null) return NotFound();
        return Ok(product);
    }
}
