using System;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class Module : MonoBehaviour
{
    public event Action<TemplateSO> OnContentUptate = null;

    [SerializeField] protected TemplateSO currentContentToDisplay = null;
    [SerializeField] protected TemplateSO.EContentType typeToDisplay = TemplateSO.EContentType.OTHER;
    [SerializeField] protected Canvas UIToDisplay = null;

    public virtual void ManageScan(TemplateSO _content) { }

    public virtual void Execute(TemplateSO _content) { }

    protected virtual void InstanciateUI() { }
}
