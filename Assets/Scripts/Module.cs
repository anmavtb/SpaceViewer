using System;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class Module : MonoBehaviour
{
    public event Action<TemplateSO> OnContentUptate = null;

    [SerializeField] protected TemplateSO currentContentToDisplay = null;
    [SerializeField] protected TemplateSO.EContentType typeToDispay = TemplateSO.EContentType.OTHER;
    [SerializeField] protected Canvas UIToDisplay = null;

    [SerializeField] ModuleManager moduleManager = null;
    [SerializeField] protected DataBase dataBase = null;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public virtual void ManageScan(ARTrackedImage _image) { }

    public virtual void Execute(TemplateSO _content) { }

    protected virtual void InstanciateUI() { }

    public TemplateSO GetRelatedContent(ARTrackedImage _image)
    {
        return currentContentToDisplay;
    }
}
