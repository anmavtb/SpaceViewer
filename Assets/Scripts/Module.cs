using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

public class Module : MonoBehaviour
{
    [Serializable]
    public enum EContentType
    {
        OTHER,
        TEXT,
        IMAGE,
        VIDEO
    }

    public event Action<TemplateSO> OnContentUptate = null;

    [SerializeField] protected TemplateSO currentContentToDisplay = null;
    [SerializeField] protected EContentType typeToDispay = EContentType.OTHER;
    [SerializeField] protected Canvas UIToDisplay = null;

    [SerializeField] ModuleManager moduleManager = null;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ManageScan(ARTrackedImage _image)
    {
        foreach (TemplateSO content in moduleManager.DataBase.AllContent)
        {
            if (_image.referenceImage.name != content.Image.name) continue;
            Debug.Log("OUI");
        }
    }

    public virtual void Execute(EContentType _contentType)
    {
        foreach (Module module in moduleManager.AllModules)
        {
            module.Execute(_contentType);
        }
    }

    protected virtual void InstanciateUI() { }

    public TemplateSO GetRelatedContent(ARTrackedImage _image)
    {
        return currentContentToDisplay;
    }
}
