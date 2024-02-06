using UnityEngine;
using UnityEngine.Video;

[CreateAssetMenu(fileName = "ContentVideo", menuName = "New Content/Video")]
public class ContentVideo : TemplateSO
{
    [SerializeField] VideoSource videoToDisplay;
}
