using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class DataBase : Singleton<DataBase>
{
    [SerializeField] List<TemplateSO> allContent = new();

    public List<TemplateSO> AllContent => allContent;

    private void Start()
    {
        InitSO();
    }

    /// <summary>
    /// Get all TemplateSO files in Resources folder and add them to the database
    /// </summary>
    void InitSO()
    {
        Object[] _tempArray = Resources.LoadAll("ScriptableObjects", typeof(TemplateSO));
        int _size = _tempArray.Length;
        if (_size < 1)
        {
            DebugManager.Instance.DebugError("No file TemplateSO in the folder Resources/ScriptableObjects was found.");
            return;
        }
        for (int i = 0; i < _size; i++)
        {
            allContent.Add(_tempArray[i] as TemplateSO);
        }
    }

    /// <summary>
    /// Get the content of the given image
    /// </summary>
    /// <param name="_image">image we want the content of</param>
    /// <returns></returns>
    public TemplateSO GetContent(ARTrackedImage _image)
    {
        if (!_image)
        {
            DebugManager.Instance.DebugError("The image is null or not valid.");
            return null;
        }
        foreach (TemplateSO content in allContent)
        {
            Debug.Log("C");
            DebugManager.Instance.DebugString($"{_image.name} // {_image.referenceImage.name} // {_image.referenceImage}");
            if (_image.referenceImage.name != content.Image.name) continue;
            DebugManager.Instance.DebugString($"This image contains : {content.Image.name}");
            return content;
        }
        return null;
    }
}
