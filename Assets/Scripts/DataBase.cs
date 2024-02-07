using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class DataBase : Singleton<DataBase>
{
    [SerializeField] List<TemplateSO> allContent = new();
    [SerializeField] List<TemplateSO> SOList = new();

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
        Object[] _tempArray = Resources.LoadAll("", typeof(TemplateSO));
        for (int i = 0; i < _tempArray.Length; i++)
        {
            SOList.Add(_tempArray[i] as TemplateSO);
        }
    }

    /// <summary>
    /// Get the content of the given image
    /// </summary>
    /// <param name="_image">image we want the content of</param>
    /// <returns></returns>
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
