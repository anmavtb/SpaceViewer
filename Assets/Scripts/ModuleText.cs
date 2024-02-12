using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ModuleText : Module
{
    [SerializeField] localizedText.ELanguage actualLanguage = localizedText.ELanguage.ENGLISH;
    TextMeshProUGUI textCompo = null;
    ContentText contentText = null;

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
    protected void InstanciateUI(ContentText _contentText)
    {
        contentText = _contentText;
        DebugManager.Instance.DebugString("Draw UI");
        UIText _textUI = UIToDisplay.GetComponent<UIText>();
        if (!_textUI) return;
        _textUI.gameObject.SetActive(true);
        float _newScale = 2f / Screen.height;
        _textUI.transform.localScale = new Vector3(_newScale, _newScale, _newScale);
        _textUI.transform.position = new Vector3(0, 0, -1f); //+ _textUI.transform.up;
        textCompo = _textUI.GetComponentInChildren<ScrollRect>().GetComponentInChildren<TextMeshProUGUI>();
        TranslateText(actualLanguage);
    }

    public void TranslateText(localizedText.ELanguage _language)
    {
        actualLanguage = _language;
        textCompo.text = contentText.GetTranslatedText(_language);
    }
}
