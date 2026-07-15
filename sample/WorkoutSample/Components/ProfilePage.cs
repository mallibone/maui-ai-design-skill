using Microsoft.Maui;
using WorkoutSample.Helpers;
using WorkoutSample.Resources.Styles;

namespace WorkoutSample.Components;

class ProfilePage : Component
{
    public override VisualNode Render()
        => ContentPage(
            VStack(
                Label(IconFont.Person)
                    .FontFamily(IconFont.FontFamily)
                    .FontSize(64)
                    .TextColor(ApplicationTheme.BrandPrimary)
                    .HCenter(),
                Label("Your profile")
                    .FontSize(22)
                    .FontAttributes(FontAttributes.Bold)
                    .TextColor(ApplicationTheme.OnBackground)
                    .HCenter(),
                Label("Stats, history and settings live here.")
                    .FontSize(14)
                    .TextColor(ApplicationTheme.OnBackgroundMuted)
                    .HCenter()
            )
            .Spacing(12)
            .VCenter()
            .Padding(24)
        )
        .BackgroundColor(ApplicationTheme.PageBackground);
}
