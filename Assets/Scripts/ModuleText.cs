using UnityEngine;

public class ModuleText : Module
{
    public override void Execute(TemplateSO _content)
    {
        ContentText _text = _content as ContentText;
        Debug.Log(_text.TextToDisplay);
    }

    protected override void InstanciateUI()
    {

    }

    public override void ManageScan(TemplateSO _content)
    {
        if (_content.Content != typeToDispay) return;
        Execute(_content);
    }
}
