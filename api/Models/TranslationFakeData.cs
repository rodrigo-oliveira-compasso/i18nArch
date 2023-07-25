using System.Globalization;

namespace api.Models;

public class TranslationFakeDataObject
{
    public List<TranslationFakeData> Translation { get; set; }

    public TranslationFakeDataObject()
    {
        double value = 123456.78;
        DateTime date = DateTime.Now;
        var pt_BR = CultureInfo.CreateSpecificCulture("pt-BR");
        var en_US = CultureInfo.CreateSpecificCulture("en-US");
        Translation = new List<TranslationFakeData>()
        {
            new TranslationFakeData(langKey: "pt-BR", textKey: "product_name", textValue: "Carro Vermelho"),
            new TranslationFakeData(langKey: "pt-BR", textKey: "product_description", textValue: "Carro feito na cor vermelha"),
            new TranslationFakeData(langKey: "pt-BR", textKey: "product_price", textValue: value.ToString(pt_BR)),
            new TranslationFakeData(langKey: "pt-BR", textKey: "product_date", textValue: date.ToString(pt_BR)),
            new TranslationFakeData(langKey: "pt-BR", textKey: "product_description", textValue: "Carro feito na cor vermelha"),
            new TranslationFakeData(langKey: "en-US", textKey: "product_name", textValue: "Red Car"),
            new TranslationFakeData(langKey: "en-US", textKey: "product_description", textValue: "Car made using the red color"),
            new TranslationFakeData(langKey: "en-US", textKey: "product_price", textValue: value.ToString(en_US)),
            new TranslationFakeData(langKey: "en-US", textKey: "product_date", textValue: date.ToString(en_US)),
        };
    }
}

public class TranslationFakeData
{
    public string LangKey { get; private set; }
    public string TextKey { get; private set; }
    public string TextValue { get; private set; }

    public TranslationFakeData(string langKey, string textKey, string textValue)
    {
        LangKey = langKey;
        TextKey = textKey;
        TextValue = textValue;
    }
}