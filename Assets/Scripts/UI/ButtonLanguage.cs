using UnityEngine;
using UnityEngine.UI;

public class ButtonLanguage : MonoBehaviour
{
    [SerializeField] ELanguage language = ELanguage.NONE;
    [SerializeField, ReadOnly] ModuleText module;
    [SerializeField, ReadOnly] Button button = null;

    // Start is called before the first frame update
    void Start()
    {
        module = FindFirstObjectByType<ModuleText>();
        button = GetComponent<Button>();

        button.onClick.AddListener(() =>
        {
            module.TranslateText(language);
        });
    }
}
