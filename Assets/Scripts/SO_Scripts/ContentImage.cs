using UnityEngine;

[CreateAssetMenu(fileName = "ContentImage", menuName = "New Content/Image")]
public class ContentImage : TemplateSO
{
    [SerializeField] Texture2D imageToDisplay = null;
}
