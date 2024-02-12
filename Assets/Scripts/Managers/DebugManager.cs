using UnityEngine;

public class DebugManager : Singleton<DebugManager>
{
    public bool canUseDebug = false;

    public void DebugString(string _debug)
    {
        if (!canUseDebug) return;
        Debug.Log($"LOG DEBUG : {_debug}");
    }

    public void DebugWarning(string _warning)
    {
        if (!canUseDebug) return;
        Debug.LogWarning($"LOG WARNING : {_warning}");
    }

    public void DebugError(string _error)
    {
        if (!canUseDebug) return;
        Debug.LogError($"LOG ERROR : {_error}");
    }
}