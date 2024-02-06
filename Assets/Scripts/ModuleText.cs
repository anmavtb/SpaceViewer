using UnityEngine;

public class ModuleText : Module
{
    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update() { }

    public override void Execute(TemplateSO _content)
    {
        ContentText _text = _content as ContentText;
        Debug.Log(_text.TextToDisplay);
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
