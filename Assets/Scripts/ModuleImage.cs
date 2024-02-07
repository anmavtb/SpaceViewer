using UnityEngine;

public class ModuleImage : Module
{
    /// <summary>
    /// Check if the content is an image
    /// </summary>
    /// <param name="_content"></param>
    public override void ManageScan(TemplateSO _content)
    {
        if (_content.ContentType != typeToDisplay) return;
        Execute(_content);
    }

    public override void Execute(TemplateSO _content)
    {
        ContentImage _image = _content as ContentImage;
        Debug.Log(_image.ImageToDisplay);
    }

    /// <summary>
    /// Display the UI of the image module
    /// </summary>
    protected override void InstanciateUI()
    {

    }
}
