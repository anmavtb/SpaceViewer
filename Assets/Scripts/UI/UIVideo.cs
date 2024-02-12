using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class UIVideo : UIParent
{
    [SerializeField] List<ButtonVideo> allVideoButtons;

    protected override void Init()
    {
        allVideoButtons = GetComponentsInChildren<ButtonVideo>().ToList();
    }
}
