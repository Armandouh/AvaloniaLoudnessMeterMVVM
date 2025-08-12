using System;
using Avalonia;
using Avalonia.Controls;

namespace AvaloniaLoudnessMeter.Views;

public partial class MainWindow : Window
{
    #region Private Members

    private readonly Control _mChannelConfigPopup;
    private readonly Control _mChannelConfigButton;
    private readonly Control _mMainGrid;

    #endregion

    public MainWindow()
    {
        InitializeComponent();

        _mChannelConfigButton = this.FindControl<Control>("ChannelConfigurationButton")
                               ?? throw new Exception("Cannot find Channel Configuration Button by name");
        
        _mChannelConfigPopup = this.FindControl<Control>("ChannelConfigurationPopup")
                              ?? throw new Exception("Cannot find Channel Configuration Popup by name");

        _mMainGrid = this.FindControl<Control>("MainGrid")
                    ?? throw new Exception("Cannot find Main Grid by name");

        // Wait until layout is ready
        this.LayoutUpdated += OnLayoutUpdated;
    }


    private void OnLayoutUpdated(object? sender, EventArgs e)
    {
        // Get relative position of button 
        var pos = _mChannelConfigButton.TranslatePoint(new Point(0, 0), _mMainGrid)
                  ?? throw new Exception("Cannot find control position");
        
        // Set the position of the Popup to bottom left of the button
        _mChannelConfigPopup.Margin = new Thickness(
            pos.X,
            0,
            0,
            _mMainGrid.Bounds.Height - pos.Y - _mChannelConfigButton.Bounds.Height);
    }
}