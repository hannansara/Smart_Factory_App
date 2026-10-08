using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;
using smartFactoryApp.ViewModels;

namespace smartFactoryApp.Views;

public partial class MainWindow : Window
{
    private MainViewModel? ViewModel =>
        DataContext as MainViewModel;

    public MainWindow()
    {
        InitializeComponent();

        Opened += (_, _) =>
        {
            UpdateRobotPosition();
            UpdateRobotRotation();
        };
    }

    private void MoveUp_Click(object? sender, RoutedEventArgs e)
    {
        ViewModel?.MoveUp();
        UpdateRobotPosition();
    }

    private void MoveDown_Click(object? sender, RoutedEventArgs e)
    {
        ViewModel?.MoveDown();
        UpdateRobotPosition();
    }

    private void MoveLeft_Click(object? sender, RoutedEventArgs e)
    {
        ViewModel?.MoveLeft();
        UpdateRobotPosition();
    }

    private void MoveRight_Click(object? sender, RoutedEventArgs e)
    {
        ViewModel?.MoveRight();
        UpdateRobotPosition();
    }

    private void MoveUpLeft_Click(object? sender, RoutedEventArgs e)
    {
        ViewModel?.MoveUpLeft();
        UpdateRobotPosition();
    }

    private void MoveUpRight_Click(object? sender, RoutedEventArgs e)
    {
        ViewModel?.MoveUpRight();
        UpdateRobotPosition();
    }

    private void MoveDownLeft_Click(object? sender, RoutedEventArgs e)
    {
        ViewModel?.MoveDownLeft();
        UpdateRobotPosition();
    }

    private void MoveDownRight_Click(object? sender, RoutedEventArgs e)
    {
        ViewModel?.MoveDownRight();
        UpdateRobotPosition();
    }

    private void RotateLeft_Click(object? sender, RoutedEventArgs e)
    {
        ViewModel?.RotateLeft();
        UpdateRobotRotation();
    }

    private void RotateRight_Click(object? sender, RoutedEventArgs e)
    {
        ViewModel?.RotateRight();
        UpdateRobotRotation();
    }

    private void UpdateRobotPosition()
    {
        if (ViewModel == null)
            return;

        Canvas.SetLeft(
            RobotImage,
            ViewModel.Robot.Location.X
        );

        Canvas.SetTop(
            RobotImage,
            ViewModel.Robot.Location.Y
        );
    }

    private void UpdateRobotRotation()
    {
        if (ViewModel == null)
            return;

        RobotImage.RenderTransformOrigin = RelativePoint.Center;

    RobotImage.RenderTransform =
        new RotateTransform(ViewModel.Robot.Rotation);
    }
}