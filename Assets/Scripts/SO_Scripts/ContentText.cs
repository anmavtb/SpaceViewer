using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public struct localizedText
{
    public enum ELanguage
    {
        NONE,
        ENGLISH,
        FRENCH
    }
}

[Serializable]
public class TranslatedTextsItems
{
    [SerializeField] public localizedText.ELanguage language;
    [SerializeField] public string text;
}

[Serializable]
public class TranslatedTexts
{
    [SerializeField] TranslatedTextsItems[] items;

    public Dictionary<localizedText.ELanguage, string> ToDictionnary()
    {
        Dictionary<localizedText.ELanguage, string> _newDict = new();
        foreach (var item in items)
        {
            _newDict.Add(item.language, item.text);
        }

        return _newDict;
    }
}

[CreateAssetMenu(fileName = "ContentText", menuName = "New Content/Text")]
public class ContentText : TemplateSO
{
    [SerializeField] TranslatedTexts allTexts = new();
    Dictionary<localizedText.ELanguage, string> translatedTexts;

    void OnEnable()
    {
        translatedTexts = allTexts.ToDictionnary();
    }

    public string GetTranslatedText(localizedText.ELanguage _language)
    {
        return translatedTexts[_language];
    }
}
