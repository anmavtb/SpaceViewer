using UnityEngine;

public enum EContentType
{
    OTHER,
    TEXT,
    IMAGE,
    VIDEO
}

public class TemplateSO : ScriptableObject
{
    [SerializeField] protected Texture2D image = null;
    [SerializeField] protected EContentType contentType = EContentType.OTHER;

    public Texture2D Image => image;
    public EContentType ContentType => contentType;
}
