using UnityEngine;

public class ModuleVideo : Module
{
    /// <summary>
    /// Cast the content in the right format before doing what it needs to do
    /// </summary>
    /// <param name="_content"></param>
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
