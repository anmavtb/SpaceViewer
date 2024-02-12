using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class UIText : UIParent
{
    [SerializeField] List<ButtonLanguage> allLanguagesButtons = new();

    protected override void Init()
    {
        allLanguagesButtons = GetComponentsInChildren<ButtonLanguage>().ToList();
    }
}
