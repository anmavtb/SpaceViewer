using UnityEngine;

public class ModuleVideo : Module
{
    public override void Execute(TemplateSO _content)
    {
        ContentVideo _video = _content as ContentVideo;
        Debug.Log(_video.VideoToDisplay);
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
