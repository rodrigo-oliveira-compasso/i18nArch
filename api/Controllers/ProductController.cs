using api.Models;
using api.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class ProductController : ControllerBase
{

    public ProductController()
    {
    }

    [HttpGet(Name = "GetProducts")]    
    public List<Product> GetProducts(string lang)
    {
        ProductService service = new();
        return service.GetProducts(lang);
    }

}
