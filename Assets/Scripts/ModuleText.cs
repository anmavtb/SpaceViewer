using UnityEngine;

public class ModuleText : Module
{
    /// <summary>
    /// Check if the content is a text
    /// </summary>
    /// <param name="_content"></param>
    public override void ManageScan(TemplateSO _content)
    {
        if (_content.ContentType != typeToDisplay) return;
        Execute(_content);
    }

    public override void Execute(TemplateSO _content)
    {
        ContentText _text = _content as ContentText;
        Debug.Log(_text.TextToDisplay);
    }

    /// <summary>
    /// Display the UI of the text module
    /// </summary>
    protected override void InstanciateUI()
    {

    }
}
