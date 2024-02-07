using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ImageScanner : MonoBehaviour
{
    [SerializeField] ARTrackedImageManager imageManager = null;
    [SerializeField] XRReferenceImageLibrary imageLibrary = null;

    private void OnEnable() => imageManager.trackedImagesChanged += OnChange;

    private void OnDisable() => imageManager.trackedImagesChanged -= OnChange;

    void OnChange(ARTrackedImagesChangedEventArgs _eventArgs)
    {
        foreach (var newImage in _eventArgs.added)
        {
            ModuleManager.Instance.Execute(newImage);
        }

        foreach (var updatedImage in _eventArgs.updated)
        { }

        foreach (var removedImage in _eventArgs.removed)
        {
            Debug.Log($"LOG REMOVED");
        }
    }
}
