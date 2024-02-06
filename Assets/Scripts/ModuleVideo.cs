using UnityEngine;

public class ModuleVideo : Module
{
    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update() { }

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
