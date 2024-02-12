using UnityEngine;

public class ButtonVideoPause : ButtonVideo
{
    protected override void Execute()
    {
        Debug.Log("PAUSE");
        player.Pause();
    }
}
