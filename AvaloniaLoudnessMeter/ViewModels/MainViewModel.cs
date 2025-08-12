using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Avalonia.Automation;
using Avalonia.Controls.Documents;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaLoudnessMeter.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty] private string _boldTitle = "AVALONIA";

    [ObservableProperty] private string _regularTitle = "LOUDNESS METER";

    [ObservableProperty] private bool _channelConfigurationIsOpen = false;

    [RelayCommand]
    private void ChannelConfigurationButtonPressed() => ChannelConfigurationIsOpen ^= true;
    
}