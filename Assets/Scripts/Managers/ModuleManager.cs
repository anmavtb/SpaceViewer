using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ModuleManager : Singleton<ModuleManager>
{
    [SerializeField] List<Module> allModules = new();
    [SerializeField] ARRaycastManager raycastManager;
    [SerializeField] Transform objectPosition = null;
    List<ARRaycastHit> hitResults = new();

    public List<Module> AllModules => allModules;
    public Transform ObjectPosition => objectPosition;

    private void Start()
    {
        GetComponents(allModules);
    }

    private void Update()
    {
        //TEST();
    }

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
            DebugManager.Instance.DebugString($"Image position : {objectPosition.position}");
            module.Execute(_content);
        }
    }

    /*void TEST()
    {
        Ray _ray = Camera.main.ScreenPointToRay(Camera.main.transform.position);
        DebugManager.Instance.DebugString(_ray.ToString());
        Vector2 _screenPoint = new Vector2(_ray.direction.x, _ray.direction.y);
        bool _hit = raycastManager.Raycast(_ray, hitResults, TrackableType.AllTypes); //(Vector2 screenPoint, List < ARRaycastHit > hitResults, TrackableType trackableTypes TrackableType.Depth)
        if (!_hit)
        {
            DebugManager.Instance.DebugString("_none_");
            return;
        }
        DebugManager.Instance.DebugWarning("!!! FOUND !!!");
        DebugManager.Instance.DebugString(hitResults[0].ToString());
    }*/
}
