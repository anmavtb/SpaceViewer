using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ImageScanner : MonoBehaviour
{
    [SerializeField] ARTrackedImageManager imageManager = null;

    private void OnEnable() => imageManager.trackedImagesChanged += OnChanged;

    private void OnDisable() => imageManager.trackedImagesChanged -= OnChanged;

    void OnChanged(ARTrackedImagesChangedEventArgs _eventArgs)
    {
        foreach (var _newImage in _eventArgs.added)
        {
            ModuleManager.Instance.Execute(_newImage);
        }

        foreach (var _updatedImage in _eventArgs.updated)
        {
            if (_updatedImage.trackingState == UnityEngine.XR.ARSubsystems.TrackingState.Tracking)
            {
                Debug.Log($"LOG : TRACK {_updatedImage.referenceImage.name}");
                _updatedImage.gameObject.SetActive(true);
            }
            else
            {
                Debug.LogWarning($"LOG : UN-TRACK {_updatedImage.referenceImage.name}");
                _updatedImage.gameObject.SetActive(false);
            }
        }
    }
}
