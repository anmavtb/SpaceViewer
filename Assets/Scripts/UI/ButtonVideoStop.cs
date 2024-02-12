using UnityEngine;

public class ButtonVideoStop : ButtonVideo
{
    protected override void Execute()
    {
        Debug.Log("STOP");
        player.Stop();
    }
}
