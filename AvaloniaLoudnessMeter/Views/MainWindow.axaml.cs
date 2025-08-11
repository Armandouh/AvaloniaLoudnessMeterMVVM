using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;

namespace AvaloniaLoudnessMeter.Views;

public partial class MainWindow : Window
{
    #region Private Members

    private Control mChannelConfigPopup;
    private Control mChannelConfigButton;
    private Control mMainGrid;

    #endregion
    public MainWindow()
    {
        try
        {
            InitializeComponent();
            mChannelConfigButton = this.FindControl<Control>("ChannelConfigurationButton") ?? throw new Exception("Cannot find Channel Configuration Button by name");
            mChannelConfigPopup = this.FindControl<Control>("ChannelConfigurationPopup") ?? throw new Exception("Cannot find Channel Configuration Popup by name");
            mMainGrid = this.FindControl<Control>("MainGrid") ?? throw new Exception("Cannot find Main Grid by name");

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error in mainWindow {ex}");
            throw;
        }
    }

    public override void Render(DrawingContext context)
    {
        base.Render(context);
        
        var pos = mChannelConfigButton.TranslatePoint(new Point(), mMainGrid) ?? throw new Exception("Cannot find the position of a Button");
        mChannelConfigPopup.Margin = new Thickness(
            pos.X,
            0,
            0,
            mMainGrid.Bounds.Height - pos.Y - mChannelConfigButton.Bounds.Height
        );
    }
}