using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Avalonia.Automation;
using Avalonia.Controls.Documents;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaLoudnessMeter.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty] public string boldTitle = "Hello";

    public MainViewModel()
    {
        Task.Run(async () =>
        {
            await Task.Delay(2000);
            BoldTitle = "New Title 2";
        });
    }
    
}