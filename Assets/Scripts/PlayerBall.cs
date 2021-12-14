public sealed class PlayerBall : Player
{
    private void FixedUpdate()
    {
        Move();
        GetBonus();
        CheckedSpeedP();
    }
}
