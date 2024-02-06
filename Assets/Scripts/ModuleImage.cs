using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ModuleImage : Module
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
        ContentImage _image = _content as ContentImage;
        Debug.Log(_image.ImageToDisplay);
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
