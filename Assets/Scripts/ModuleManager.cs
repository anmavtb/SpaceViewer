using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ModuleManager : Singleton<ModuleManager>
{
    [SerializeField] List<Module> allModules = new();
    public List<Module> AllModules => allModules;

    /// <summary>
    /// Send the image to each module
    /// </summary>
    /// <param name="_image"></param>
    public void Execute(ARTrackedImage _image)
    {
        TemplateSO _content = DataBase.Instance.GetContent(_image);
        foreach (Module module in allModules)
        {
            module.ManageScan(_content);
        }
    }
}
