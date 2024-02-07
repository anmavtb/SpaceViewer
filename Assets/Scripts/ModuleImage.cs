using UnityEngine;

public class ModuleImage : Module
{
    public override void Execute(TemplateSO _content)
    {
        ContentImage _image = _content as ContentImage;
        Debug.Log(_image.ImageToDisplay);
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
