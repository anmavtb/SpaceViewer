using UnityEngine;

public class ObjectToScan : ScriptableObject
{
    #region Variables
    [SerializeField] protected string label = "";
    [SerializeField] protected string fullName = "";
    [SerializeField] protected GameObject content = null;
    #endregion Variables

    #region Accessors
    public string Label => label;
    public string FullName => fullName;
    public GameObject Content => content;
    #endregion Accessors

    #region Methods
    
    #endregion Methods
}
