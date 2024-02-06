using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ModuleManager : MonoBehaviour
{
    [SerializeField] List<Module> allModules = new();
    [SerializeField] DataBase dataBase = null;
    public DataBase DataBase => dataBase;
    public List<Module> AllModules => allModules;

    // Start is called before the first frame update
    void Start()
    {
        dataBase = GetComponent<DataBase>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Execute(ARTrackedImage _image)
    {
        foreach (Module module in allModules)
        {
            module.ManageScan(_image);
        }
    }
}
