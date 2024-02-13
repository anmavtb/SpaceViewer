using UnityEngine;

public class ButtonVideoStop : ButtonVideo
{
    protected override void Execute()
    {
        player.Stop();
    }
}
