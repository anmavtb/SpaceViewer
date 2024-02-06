using UnityEngine;

public class ModuleImage : Module
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
        Debug.Log("LOG : CECI EST UNE IMAGE");
    }

    protected override void InstanciateUI()
    {

    }
}
