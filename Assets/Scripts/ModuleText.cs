using UnityEngine;

public class ModuleText : Module
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void Execute()
    {
        Debug.Log("LOG : CECI EST UN TEXTE");
    }

    protected override void InstanciateUI()
    {

    }
}
