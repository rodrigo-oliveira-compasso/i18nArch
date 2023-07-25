using api.Models;

namespace api.Services;

public class TranslationService
{
    private readonly TranslationFakeDataObject _fakeDataObject;
    public TranslationService()
    {
        _fakeDataObject = new TranslationFakeDataObject();
    }

    public List<TranslationFakeData> GetTranslation(string lang)
    {
        return _fakeDataObject.Translation.FindAll(data => data.LangKey.Equals(lang));
    }
}