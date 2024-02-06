using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ImageScanner : MonoBehaviour
{
    [SerializeField] ARTrackedImageManager imageManager = null;
    [SerializeField] XRReferenceImageLibrary imageLibrary = null;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnEnable() => imageManager.trackedImagesChanged += OnChange;

    private void OnDisable() => imageManager.trackedImagesChanged -= OnChange;

    void OnChange(ARTrackedImagesChangedEventArgs _eventArgs)
    {
        foreach (var newImage in _eventArgs.added)
        {
            Debug.Log($"LOG1 {newImage}");
            Debug.Log($"LOG2 {newImage.referenceImage}");
            Debug.Log($"LOG3 {newImage.referenceImage.name}");
            Debug.Log($"");
        }

        foreach (var updatedImage in _eventArgs.updated)
        {

        }

        foreach (var removedImage in _eventArgs.removed)
        {
            Debug.Log($"LOG REMOVED");
        }
    }
}
