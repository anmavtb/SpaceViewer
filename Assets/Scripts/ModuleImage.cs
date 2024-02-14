using UnityEngine.UI;

public class ModuleImage : Module
{
    /// <summary>
    /// Cast the content in the right format before doing what it needs to do
    /// </summary>
    /// <param name="_content"></param>
    public override void Execute(TemplateSO _content)
    {
        base.Execute(_content);
        ContentImage _image = _content as ContentImage;
        InstanciateUI(_image);
    }

    /// <summary>
    /// Display the UI of the image module
    /// </summary>
    /// <param name="_contentImage"></param>
    protected void InstanciateUI(ContentImage _contentImage)
    {
        DebugManager.Instance.DebugString("Draw UI");
        UIImage _imageUI = UIToDisplay.GetComponent<UIImage>();
        if (!_imageUI) return;
        SetupUI(_imageUI);
        Image _imageCompo = _imageUI.GetComponentInChildren<Image>();
        _imageCompo.sprite = _contentImage.ImageToDisplay;
    }
}
