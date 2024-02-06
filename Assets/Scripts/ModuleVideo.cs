using UnityEngine;

public class ModuleVideo : Module
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Execute(EContentType _contentType)
    {
        if (_contentType != typeToDispay) return;
        Debug.Log("LOG : CECI EST UNE VIDEO");
    }

    protected override void InstanciateUI()
    {

    }
}
