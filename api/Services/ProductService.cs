using System.Globalization;
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
        List<Product> products = new()
        {
            GetTranslatedProduct(1,lang),
            GetTranslatedProduct(2,lang),
            GetTranslatedProduct(3,lang)
        };
        return products;
    }

    private Product GetTranslatedProduct(int id, string lang)
    {
        Product product = null;
        CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture(lang);
        if (lang.Equals("pt-BR"))
        {
            if (id.Equals(1))
            {
                product = new Product(
                    id: 1,
                    name: "Carro Vermelho",
                    description: "Carro feito na cor vermelha",
                    price: 123456.78,
                    registerDate: DateTime.Now,
                    formattedPrice: $"{cultureInfo.NumberFormat.CurrencySymbol} {123456.78.ToString(cultureInfo)}",
                    formattedDate: DateTime.Now.ToString(cultureInfo),
                    imageURL: "https://i.pinimg.com/originals/57/e0/49/57e04903bd3475ffa87c0552b01d6801.jpg");
            }
            else if (id.Equals(2))
            {
                product = new Product(
                    id: 2,
                    name: "Bola Azul",
                    description: "Bola feita na cor azul",
                    price: 123.45,
                    registerDate: DateTime.Now,
                    formattedPrice: $"{cultureInfo.NumberFormat.CurrencySymbol} {123.45.ToString(cultureInfo)}",
                    formattedDate: DateTime.Now.ToString(cultureInfo),
                    imageURL: "https://m.media-amazon.com/images/I/61ZBt3lKPYS.__AC_SX300_SY300_QL70_ML2_.jpg");
            }
            else if (id.Equals(3))
            {
                product = new Product(
                    id: 3,
                    name: "Casa Verde",
                    description: "Casa feita na cor verde",
                    price: 1234567.89,
                    registerDate: DateTime.Now,
                    formattedPrice: $"{cultureInfo.NumberFormat.CurrencySymbol} {1234567.89.ToString(cultureInfo)}",
                    formattedDate: DateTime.Now.ToString(cultureInfo),
                    imageURL: "https://www.vaicomtudo.com/wp-content/uploads/2015/02/Fachada-verde-para-casas-%C3%A9-a-nova-tend%C3%AAncia-0011.jpg");
            }
        }
        else
        {
            if (id.Equals(1))
            {
                product = new Product(
                    id: 1,
                    name: "Red Car",
                    description: "Car made using the red color",
                    price: 123456.78,
                    registerDate: DateTime.Now,
                    formattedPrice: $"{cultureInfo.NumberFormat.CurrencySymbol} {123456.78.ToString(cultureInfo)}",
                    formattedDate: DateTime.Now.ToString(cultureInfo),
                    imageURL: "https://i.pinimg.com/originals/57/e0/49/57e04903bd3475ffa87c0552b01d6801.jpg");
            }
            else if (id.Equals(2))
            {
                product = new Product(
                    id: 2,
                    name: "Blue ball",
                    description: "Ball made using the blue color",
                    price: 123.45,
                    registerDate: DateTime.Now,
                    formattedPrice: $"{cultureInfo.NumberFormat.CurrencySymbol} {123.45.ToString(cultureInfo)}",
                    formattedDate: DateTime.Now.ToString(cultureInfo),
                    imageURL: "https://m.media-amazon.com/images/I/61ZBt3lKPYS.__AC_SX300_SY300_QL70_ML2_.jpg");
            }
            else if (id.Equals(3))
            {
                product = new Product(
                    id: 3,
                    name: "Green house",
                    description: "House made using the green color",
                    price: 1234567.89,
                    registerDate: DateTime.Now,
                    formattedPrice: $"{cultureInfo.NumberFormat.CurrencySymbol} {1234567.89.ToString(cultureInfo)}",
                    formattedDate: DateTime.Now.ToString(cultureInfo),
                    imageURL: "https://www.vaicomtudo.com/wp-content/uploads/2015/02/Fachada-verde-para-casas-%C3%A9-a-nova-tend%C3%AAncia-0011.jpg");
            }
        }
        return product;
    }
}