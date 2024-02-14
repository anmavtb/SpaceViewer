using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ModuleText : Module
{
    [SerializeField, ReadOnly] ELanguage actualLanguage = ELanguage.ENGLISH;
    [SerializeField, ReadOnly] TextMeshProUGUI textCompo = null;
    [SerializeField, ReadOnly] ContentText contentText = null;

    /// <summary>
    /// Cast the content in the right format before doing what it needs to do
    /// </summary>
    /// <param name="_content"></param>
    public override void Execute(TemplateSO _content)
    {
        base.Execute(_content);
        ContentText _text = _content as ContentText;
        InstanciateUI(_text);
    }

    /// <summary>
    /// Display the UI of the text module
    /// </summary>
    /// <param name="_contentText"></param>
    protected void InstanciateUI(ContentText _contentText)
    {
        contentText = _contentText;
        DebugManager.Instance.DebugString("Draw Text UI");
        UIText _textUI = UIToDisplay.GetComponent<UIText>();
        if (!_textUI) return;
        SetupUI(_textUI);
        textCompo = _textUI.GetComponentInChildren<Scrollbar>().GetComponentInParent<ScrollRect>().GetComponentInChildren<TextMeshProUGUI>();
        TranslateText(actualLanguage);
    }

    /// <summary>
    /// Translate the displayed text with the language sent
    /// </summary>
    /// <param name="_language"></param>
    public void TranslateText(ELanguage _language)
    {
        actualLanguage = _language;
        textCompo.text = contentText.GetTranslatedText(_language);
    }
}
