using MauiReactor;
using WorkoutSample.Components;
using WorkoutSample.Resources.Styles;

namespace WorkoutSample;

public partial class App : MauiReactorApplication
{
    public App(IServiceProvider serviceProvider)
        : base(serviceProvider)
    {
        InitializeComponent();
    }
}


public abstract class MauiReactorApplication : ReactorApplication<HomePage>
{
    public MauiReactorApplication(IServiceProvider serviceProvider)
        : base(serviceProvider)
    {
        this.UseTheme<ApplicationTheme>();
    }
}