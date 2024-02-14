using UnityEngine;

public class Module : MonoBehaviour
{
    [SerializeField] protected EContentType typeToDisplay = EContentType.OTHER;
    [SerializeField] protected Canvas UIToDisplay = null;
    protected Transform imagePosition = null;

    public EContentType TypeToDisplay => typeToDisplay;
    public Transform ImagePosition => imagePosition;

    public virtual void Execute(TemplateSO _content)
    {
        imagePosition = ModuleManager.Instance.ObjectPosition;
    }

    /// <summary>
    /// Activate the UI if not already and place it on the world
    /// </summary>
    /// <param name="_ui"></param>
    public void SetupUI(UIParent _ui)
    {
        if (!_ui.gameObject.activeSelf)
            SwapActivation(_ui.gameObject);
        _ui.transform.parent = imagePosition;
        float _newScale = 2f / Screen.height;
        _ui.transform.localPosition = Vector3.zero;
        _ui.transform.localScale = Vector3.one * _newScale;
    }

    /// <summary>
    /// Change the activation status of the given GameObject
    /// </summary>
    /// <param name="_go"></param>
    public void SwapActivation(GameObject _go)
    {
        _go.SetActive(!_go.activeSelf);
    }
}
