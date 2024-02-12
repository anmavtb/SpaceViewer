using UnityEngine;
using UnityEngine.UI;

public class ButtonLanguage : MonoBehaviour
{
    [SerializeField] ModuleText module;
    [SerializeField] localizedText.ELanguage language = localizedText.ELanguage.NONE;
    Button button = null;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();

        button.onClick.AddListener(() =>
        {
            module.TranslateText(language);
        });
    }
}
