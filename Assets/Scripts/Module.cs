using System;
using UnityEngine;

public class Module : MonoBehaviour
{
    public event Action<TemplateSO> OnContentUptate = null;

    [SerializeField] protected TemplateSO.EContentType typeToDisplay = TemplateSO.EContentType.OTHER;
    [SerializeField] protected Transform imagePosition = null;
    [SerializeField] protected Canvas UIToDisplay = null;

    public TemplateSO.EContentType TypeToDisplay => typeToDisplay;
    public Transform ImagePosition => imagePosition;

    public virtual void Execute(TemplateSO _content)
    {
        imagePosition = ModuleManager.Instance.ObjectPosition;
    }

    public void SetupUI(UIParent _ui)
    {
        _ui.gameObject.SetActive(true);
        _ui.transform.parent = imagePosition;
        float _newScale = 2f / Screen.height;
        _ui.transform.localPosition = new Vector3(0, 0, .5f);
        _ui.transform.localScale = new Vector3(_newScale, _newScale, _newScale);
    }
}
