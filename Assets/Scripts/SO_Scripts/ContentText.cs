using System;
using System.Collections.Generic;
using UnityEngine;

public enum ELanguage
{
    NONE,
    ENGLISH,
    FRENCH
}

[Serializable]
public class TranslatedTextsItems
{
    [SerializeField] public ELanguage language;
    [SerializeField] public string text;
}

[Serializable]
public class TranslatedTexts
{
    [SerializeField] TranslatedTextsItems[] items;

    public Dictionary<ELanguage, string> ToDictionnary()
    {
        Dictionary<ELanguage, string> _newDict = new();
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
    Dictionary<ELanguage, string> translatedTexts;

    void OnEnable()
    {
        translatedTexts = allTexts.ToDictionnary();
    }

    /// <summary>
    /// Getter of the dictionnary of all the texts
    /// </summary>
    /// <param name="_language"></param>
    /// <returns></returns>
    public string GetTranslatedText(ELanguage _language)
    {
        return translatedTexts[_language];
    }
}
