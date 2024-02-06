using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ModuleText : Module
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void Execute(TemplateSO _content)
    {
        ContentText _text = _content as ContentText;
        Debug.Log(_text.TextToDisplay);
    }

    protected override void InstanciateUI()
    {

    }

    public override void ManageScan(ARTrackedImage _image)
    {
        foreach (TemplateSO content in dataBase.AllContent)
        {
            if (_image.referenceImage.name != content.Image.name) continue;
            if (content.Content != typeToDispay) continue;
            Execute(content);
        }
    }
}
