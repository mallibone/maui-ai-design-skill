using Microsoft.Maui;
using Microsoft.Maui.Graphics;

namespace WorkoutSample.Components;

class ProfilePage : Component
{
    public override VisualNode Render()
        => ContentPage(
            VStack(
                Label("Your profile")
                    .FontSize(24)
                    .TextColor(Colors.White)
                    .HCenter(),
                Label("Stats, history and settings live here.")
                    .FontSize(14)
                    .TextColor(Colors.White)
                    .HCenter()
            )
            .Spacing(10)
            .VCenter()
            .Padding(20)
        )
        .BackgroundColor(Colors.CornflowerBlue);
}
