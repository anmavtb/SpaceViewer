using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public abstract class ButtonVideo : MonoBehaviour
{
    [SerializeField] protected VideoPlayer player = null;
    [SerializeField] protected Button button = null;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponentInParent<UIVideo>().GetComponentInChildren<VideoPlayer>();
        button = GetComponent<Button>();

        button.onClick.AddListener(() =>
        {
            Execute();
        });
    }

    protected abstract void Execute();
}
