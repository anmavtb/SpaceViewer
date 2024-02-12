using System;
using UnityEngine;

public class Module : MonoBehaviour
{
    public event Action<TemplateSO> OnContentUptate = null;

    [SerializeField] protected TemplateSO.EContentType typeToDisplay = TemplateSO.EContentType.OTHER;
    [SerializeField] protected Vector3 imagePosition = Vector3.zero;
    [SerializeField] protected Canvas UIToDisplay = null;

    public TemplateSO.EContentType TypeToDisplay => typeToDisplay;
    public Vector3 ImagePosition => imagePosition;

    public virtual void Execute(TemplateSO _content)
    {
        imagePosition = ModuleManager.Instance.ObjectPosition;
    }
}
