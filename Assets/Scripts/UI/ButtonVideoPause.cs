public class ButtonVideoPause : ButtonVideo
{
    protected override void Execute()
    {
        player.Pause();
    }
}