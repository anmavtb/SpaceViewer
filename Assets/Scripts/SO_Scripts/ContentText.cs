using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
struct localizedText
{
    enum ELanguage
    {
        ENGLISH,
        FRENCH
    }

    ELanguage language;
    string text;
}

[CreateAssetMenu(fileName = "ContentText", menuName = "New Content/Text")]
public class ContentText : TemplateSO
{
    [SerializeField] string textToDisplay = "";
    List<localizedText> allTexts = new();
}
