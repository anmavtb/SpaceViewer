using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ModuleManager : Singleton<ModuleManager>
{
    [SerializeField] List<Module> allModules = new();
    public List<Module> AllModules => allModules;

    private void Start()
    {
        GetComponents<Module>(allModules);
    }

    /// <summary>
    /// Send the image to each module
    /// </summary>
    /// <param name="_image"></param>
    public void Execute(ARTrackedImage _image)
    {
        TemplateSO _content = DataBase.Instance.GetContent(_image);
        if (!_content)
        {
            DebugManager.Instance.DebugError("The image sent don't have content or it's content is not valid.");
            return;
        }
        foreach (Module module in allModules)
        {
            if (!module)
            {
                DebugManager.Instance.DebugWarning($"A module in the list is null or not valid.");
                continue;
            }
            if (module.TypeToDisplay != _content.ContentType) continue;
            DebugManager.Instance.DebugString($"The module for this image is : {module.name}");
            module.Execute(_content);
        }
    }
}
