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
    /// <param name="_contentVideo"></param>
    protected void InstanciateUI(ContentVideo _contentVideo)
    {
        UIVideo _videoUI = UIToDisplay.GetComponent<UIVideo>();
        if (!_videoUI) return;
        SetupUI(_videoUI);
        VideoPlayer _videoCompo = _videoUI.GetComponentInChildren<VideoPlayer>();
        _videoCompo.clip = _contentVideo.VideoToDisplay;
    }
}
