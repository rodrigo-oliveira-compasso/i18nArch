using System.Reflection.Metadata.Ecma335;
using api.Models;

namespace api.Services;
public class ProductService
{
    public ProductService()
    {
    }

    public List<Product> GetProducts(string lang = "pt-BR")
    {
        TranslationService translationService = new TranslationService();
        var translations = translationService.GetTranslation(lang);
        List<Product> products = new()
        {
            new Product(
                id: 1,
                name: translations.Find(item=> item.TextKey.Equals("product_name")).TextValue,
                description:translations.Find(item=> item.TextKey.Equals("product_description")).TextValue,
                price: 123456.78,
                registerDate: DateTime.Now,
                formattedDate: translations.Find(item=> item.TextKey.Equals("product_date")).TextValue,
                formattedPrice: translations.Find(item=> item.TextKey.Equals("product_price")).TextValue)
        };

        return products;
    }
}