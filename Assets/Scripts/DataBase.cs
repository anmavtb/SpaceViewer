using System.Collections.Generic;
using UnityEngine;

public class DataBase : MonoBehaviour
{
    [SerializeField] List<TemplateSO> allContent = new();

    public List<TemplateSO> AllContent => allContent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
