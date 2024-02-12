using UnityEngine;
using UnityEngine.Video;

public class ModuleVideo : Module
{
    /// <summary>
    /// Cast the content in the right format before doing what it needs to do
    /// </summary>
    /// <param name="_content"></param>
    public override void Execute(TemplateSO _content)
    {
        base.Execute(_content);
        ContentVideo _video = _content as ContentVideo;
        InstanciateUI(_video);
    }

    /// <summary>
    /// Display the UI of the video module
    /// </summary>
    protected void InstanciateUI(ContentVideo _contentVideo)
    {
        DebugManager.Instance.DebugString("Draw UI");
        UIVideo _videoUI = UIToDisplay.GetComponent<UIVideo>();
        if (!_videoUI) return;
        _videoUI.gameObject.SetActive(true);
        float _newScale = 2f / Screen.height;
        _videoUI.transform.localScale = new Vector3(_newScale, _newScale, _newScale);
        _videoUI.transform.position = new Vector3(0, 0, -1f); //+ _textUI.transform.up;
        VideoPlayer _videoCompo = _videoUI.GetComponentInChildren<VideoPlayer>();
    }
}
