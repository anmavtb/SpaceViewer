using System.Collections.Generic;
using UnityEngine;

public class ModuleManager : MonoBehaviour
{
    [SerializeField] Module baseModule = null;
    [SerializeField] List<Module> allModules = new();
    [SerializeField] DataBase dataBase = null;

    public Module BaseModule => baseModule;
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

    public void Execute()
    {

    }
}
