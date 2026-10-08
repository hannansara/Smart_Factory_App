using System.Drawing;

namespace smartFactoryApp.Models;

public class Robot
{
    private Point location;
    private Rectangle borders;
    private double rotation;

    private const int robotSize = 50;
    private const int safetyMargin = 11;

    public Point Location
    {
        get { return location; }
        set { location = value; }
    }

    public Rectangle Borders
    {
        get { return borders; }
        set { borders = value; }
    }

    public double Rotation
    {
        get { return rotation; }
        set { rotation = value; }
    }

    // Konstruktor 1
    public Robot(Point location)
    {
        Location = location;
        Rotation = 0;
    }

    // Konstruktor 2
    public Robot(Point location, Rectangle borders)
    {
        Location = location;
        Borders = borders;
        Rotation = 0;
    }

    public void Bewegen(Parameters.Direction direction)
    {
        int x = Location.X;
        int y = Location.Y;

        switch (direction)
        {
            case Parameters.Direction.Up:
                y -= Parameters.step;
                break;

            case Parameters.Direction.Down:
                y += Parameters.step;
                break;

            case Parameters.Direction.Left:
                x -= Parameters.step;
                break;

            case Parameters.Direction.Right:
                x += Parameters.step;
                break;

            case Parameters.Direction.UpLeft:
                x -= Parameters.step;
                y -= Parameters.step;
                break;

            case Parameters.Direction.UpRight:
                x += Parameters.step;
                y -= Parameters.step;
                break;

            case Parameters.Direction.DownLeft:
                x -= Parameters.step;
                y += Parameters.step;
                break;

            case Parameters.Direction.DownRight:
                x += Parameters.step;
                y += Parameters.step;
                break;

            case Parameters.Direction.Stop:
                return;
        }

        // Prüfen, ob der komplette Robot innerhalb
        // der Factory-Grenzen bleibt.
        //
        // safetyMargin sorgt dafür, dass auch beim
        // Drehen keine Ecke über die Grenze geht.
        if (x >= Borders.Left + safetyMargin &&
            x + robotSize <= Borders.Right - safetyMargin &&
            y >= Borders.Top + safetyMargin &&
            y + robotSize <= Borders.Bottom - safetyMargin)
        {
            Location = new Point(x, y);
        }
    }

   public void RotateLeft()
{
    Rotation -= Parameters.rotationStep;
}

public void RotateRight()
{
    Rotation += Parameters.rotationStep;
}
}
