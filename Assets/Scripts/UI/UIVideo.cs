using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class UIVideo : MonoBehaviour
{
    [SerializeField] List<ButtonVideo> allVideoButtons;

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
        allVideoButtons = GetComponentsInChildren<ButtonVideo>().ToList();
    }
}
