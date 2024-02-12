using UnityEngine;

[CreateAssetMenu(fileName = "ContentImage", menuName = "New Content/Image")]
public class ContentImage : TemplateSO
{
    [SerializeField] Sprite imageToDisplay = null;

    public Sprite ImageToDisplay => imageToDisplay;
}
