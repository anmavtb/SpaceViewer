using UnityEngine;

public class ModuleVideo : Module
{
    /// <summary>
    /// Check if the content is a video
    /// </summary>
    /// <param name="_content"></param>
    public override void ManageScan(TemplateSO _content)
    {
        if (_content.ContentType != typeToDisplay) return;
        Execute(_content);
    }

    public override void Execute(TemplateSO _content)
    {
        ContentVideo _video = _content as ContentVideo;
        Debug.Log(_video.VideoToDisplay);
    }

    /// <summary>
    /// Display the UI of the video module
    /// </summary>
    protected override void InstanciateUI()
    {

    }
}
