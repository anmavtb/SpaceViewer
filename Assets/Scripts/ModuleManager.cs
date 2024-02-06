using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ModuleManager : MonoBehaviour
{
    [SerializeField] List<Module> allModules = new();
    public List<Module> AllModules => allModules;
    [SerializeField] DataBase database = null;

    // Start is called before the first frame update
    void Start()
    {
        database = GetComponent<DataBase>();
    }

    // Update is called once per frame
    void Update() { }

    public void Execute(ARTrackedImage _image)
    {
        TemplateSO _content = database.GetContent(_image);
        foreach (Module module in allModules)
        {
            module.ManageScan(_content);
        }
    }
}
