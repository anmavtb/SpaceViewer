using UnityEngine;

public class ButtonVideoPlay : ButtonVideo
{
    protected override void Execute()
    {
        Debug.Log("PLAY");
        player.Play();
    }
}
