namespace smartFactoryApp.Models;

public class Parameters
{
    public enum Direction
    {
        Stop,
        Left,
        Right,
        Up,
        Down,
        UpLeft,
        UpRight,
        DownLeft,
        DownRight
    }

    public const int step = 10;
    public const double rotationStep = 10;
}