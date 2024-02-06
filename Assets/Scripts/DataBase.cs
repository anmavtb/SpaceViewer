using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class DataBase : MonoBehaviour
{
    [SerializeField] List<TemplateSO> allContent = new();

    public List<TemplateSO> AllContent => allContent;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update() { }

    // Get the content of the given image
    public TemplateSO GetContent(ARTrackedImage _image)
    {
        foreach (TemplateSO content in allContent)
        {
            if (_image.referenceImage.name != content.Image.name) continue;
            return content;
        }
        return null;
    }
}
