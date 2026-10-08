using System.Drawing;
using smartFactoryApp.Models;

namespace smartFactoryApp.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    private Robot robot;

    public Robot Robot
    {
        get { return robot; }
    }

    public MainViewModel()
    {
        Rectangle borders = Rectangle.FromLTRB(
            35,
            30,
            570,
            570
        );


        robot = new Robot(
            new Point(280, 250),
            borders
        );
    }

    public void MoveUp()
    {
        robot.Bewegen(Parameters.Direction.Up);
    }

    public void MoveDown()
    {
        robot.Bewegen(Parameters.Direction.Down);
    }

    public void MoveLeft()
    {
        robot.Bewegen(Parameters.Direction.Left);
    }

    public void MoveRight()
    {
        robot.Bewegen(Parameters.Direction.Right);
    }

    public void MoveUpLeft()
    {
        robot.Bewegen(Parameters.Direction.UpLeft);
    }

    public void MoveUpRight()
    {
        robot.Bewegen(Parameters.Direction.UpRight);
    }

    public void MoveDownLeft()
    {
        robot.Bewegen(Parameters.Direction.DownLeft);
    }

    public void MoveDownRight()
    {
        robot.Bewegen(Parameters.Direction.DownRight);
    }

    public void RotateLeft()
    {
        robot.RotateLeft();
    }

    public void RotateRight()
    {
        robot.RotateRight();
    }
}