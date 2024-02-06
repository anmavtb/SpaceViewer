using System;
using UnityEngine;

public class TemplateSO : ScriptableObject
{
    [Serializable]
    public enum EContentType
    {
        OTHER,
        TEXT,
        IMAGE,
        VIDEO
    }

    [SerializeField] protected Texture2D image = null;
    [SerializeField] protected EContentType content = EContentType.OTHER;

    public Texture2D Image => image;
    public EContentType Content => content;
}
