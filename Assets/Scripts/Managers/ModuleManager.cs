using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ModuleManager : Singleton<ModuleManager>
{
    [ReadOnly] List<Module> allModules = new();
    [SerializeField] ARRaycastManager raycastManager;
    Transform objectPosition = null;

    public List<Module> AllModules => allModules;
    public Transform ObjectPosition => objectPosition;

    private void Start()
    {
        GetComponents(allModules);
    }

    private void Update()
    { }

    /// <summary>
    /// Send the image to the right module
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
            DebugManager.Instance.DebugString($"The module for this image is : {module.TypeToDisplay}");
            objectPosition = _image.transform;
            module.Execute(_content);
        }
    }
}
