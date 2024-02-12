using UnityEngine;
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
    protected void InstanciateUI(ContentImage _contentImage)
    {
        DebugManager.Instance.DebugString("Draw UI");
        UIImage _imageUI = UIToDisplay.GetComponent<UIImage>();
        if (!_imageUI) return;
        _imageUI.gameObject.SetActive(true);
        float _newScale = 2f / Screen.height;
        _imageUI.transform.localScale = new Vector3(_newScale, _newScale, _newScale);
        _imageUI.transform.position = new Vector3(0, 0, -1f); //+ _textUI.transform.up;
        Image _imageCompo = _imageUI.GetComponentInChildren<Image>();
        _imageCompo.sprite = _contentImage.ImageToDisplay;
    }
}
