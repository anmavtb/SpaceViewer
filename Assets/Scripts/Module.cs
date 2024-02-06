using System;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public abstract class Module : MonoBehaviour
{
    public event Action<TemplateSO> OnContentUptate = null;

    [SerializeField] protected TemplateSO currentContentToDisplay = null;
    [SerializeField] protected ContentType typeToDisplay = null;
    [SerializeField] protected Canvas UIToDisplay = null;

    [SerializeField] List<TemplateSO> allContents;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public abstract void Execute();

    protected abstract void InstanciateUI();

    public void ManageScan(ARTrackedImage _image)
    {
        string _imageName = _image.referenceImage.name;
        foreach (var _content in allContents)
        {
            if (_content.Image.name != _imageName) continue;
            currentContentToDisplay = _content;
            typeToDisplay = _content.Content;
            Debug.Log($"LOG1 {currentContentToDisplay}");
            Debug.Log($"LOG2 {_content.Content}");
            Debug.Log($"LOG3 {typeToDisplay}");
            //Execute();
            return;
        }
    }

    TemplateSO GetRelatedContent(ARTrackedImage _image)
    {
        return currentContentToDisplay;
    }
}
