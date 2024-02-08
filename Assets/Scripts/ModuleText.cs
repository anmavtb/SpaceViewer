using UnityEngine;

public class ModuleText : Module
{
    /// <summary>
    /// Cast the content in the right format before doing what it needs to do
    /// </summary>
    /// <param name="_content"></param>
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
