namespace api.Models;
public class Product
{
    public int ID { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public double Price { get; private set; }
    public DateTime RegisterDate { get; private set; }
    public string FormattedPrice { get; private set; }
    public string FormattedDate { get; private set; }

    public Product(int id, string name, string description, double price, DateTime registerDate, string formattedPrice, string formattedDate)
    {
        ID = id;
        Name = name;
        Description = description;//TODO Translate
        Price = price;
        RegisterDate = registerDate;
        FormattedPrice = formattedPrice;
        FormattedDate = formattedDate;
    }
}