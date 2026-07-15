using Microsoft.Maui.Graphics;
using WorkoutSample.Helpers;
using WorkoutSample.Resources.Styles;

namespace WorkoutSample.Components;

public class HomePage : Component
{
    static MauiControls.FontImageSource TabIcon(string glyph)
        => new()
        {
            FontFamily = IconFont.FontFamily,
            Glyph = glyph,
            Size = 22,
            Color = ApplicationTheme.BrandPrimary
        };

    public override VisualNode Render()
        => Shell(
                TabBar(
                    ShellContent("Workouts")
                        .Icon(TabIcon(IconFont.Dumbbell))
                        .RenderContent(() => new WorkoutListPage()),
                    ShellContent("Profile")
                        .Icon(TabIcon(IconFont.Person))
                        .RenderContent(() => new ProfilePage())
                )
            )
            .Set(MauiControls.Shell.TabBarBackgroundColorProperty, ApplicationTheme.CardBackground)
            .Set(MauiControls.Shell.TabBarForegroundColorProperty, ApplicationTheme.BrandPrimary)
            .Set(MauiControls.Shell.TabBarTitleColorProperty, ApplicationTheme.BrandPrimary)
            .Set(MauiControls.Shell.TabBarUnselectedColorProperty, ApplicationTheme.OnBackgroundMuted);
}
