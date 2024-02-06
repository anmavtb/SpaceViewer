using System.Net.Mime;
using UnityEngine;

public class TemplateSO : ScriptableObject
{
    [SerializeField] protected Texture2D image = null;
    [SerializeField] protected ContentType content = null;

    public Texture2D Image => image;
    public ContentType Content => content;
}
