public class ButtonVideoStop : ButtonVideo
{
    protected override void Execute()
    {
        player.Stop();
        player.frame = 0;
    }
}
