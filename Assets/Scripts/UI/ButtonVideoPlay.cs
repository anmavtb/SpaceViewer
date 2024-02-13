using UnityEngine;

public class ButtonVideoPlay : ButtonVideo
{
    protected override void Execute()
    {
        player.Play();
    }
}
