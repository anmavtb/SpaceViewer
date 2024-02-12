using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class UIText : MonoBehaviour
{
    [SerializeField] List<ButtonLanguage> allLanguagesButtons = new();

    // Start is called before the first frame update
    void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(Camera.main.transform);
    }

    void Init()
    {
        allLanguagesButtons = GetComponentsInChildren<ButtonLanguage>().ToList();
    }
}
