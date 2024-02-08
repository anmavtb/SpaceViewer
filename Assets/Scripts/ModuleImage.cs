using UnityEngine;

public class ModuleImage : Module
{
    /// <summary>
    /// Cast the content in the right format before doing what it needs to do
    /// </summary>
    /// <param name="_content"></param>
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
