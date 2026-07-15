using Microsoft.Maui;
using Microsoft.Maui.Graphics;

namespace WorkoutSample.Components;

// "Before" - developer art. Named colours picked because they sounded nice,
// mismatched corner radii, white text on a CornflowerBlue background, no icons.
record WorkoutMode(string Title, string Subtitle, Color Color);

class WorkoutListPage : Component
{
    static readonly WorkoutMode[] Modes =
    {
        new("AMRAP", "As many rounds as possible", Colors.DarkOrange),
        new("EMOM", "Every minute on the minute", Colors.MediumPurple),
        new("For Time", "Finish the work, beat the clock", Colors.Tomato),
        new("TABATA", "20s on, 10s off, eight rounds", Colors.MediumSeaGreen),
    };

    public override VisualNode Render()
        => ContentPage(
            ScrollView(
                VStack(
                    Label("Today")
                        .FontSize(28)
                        .TextColor(Colors.White),
                    Label("Ready to train?")
                        .FontSize(16)
                        .TextColor(Colors.White),

                    VStack(Modes.Select(ModeCard).ToArray())
                        .Spacing(10),

                    Button("Start workout")
                        .BackgroundColor(Color.FromArgb("#512BD4"))
                        .TextColor(Colors.White)
                        .CornerRadius(0)
                        .HeightRequest(44)
                )
                .Spacing(20)
                .Padding(20)
            )
            .BackgroundColor(Colors.CornflowerBlue)
        )
        .BackgroundColor(Colors.CornflowerBlue);

    static VisualNode ModeCard(WorkoutMode mode, int index)
        => Button($"{mode.Title} - {mode.Subtitle}")
            .BackgroundColor(mode.Color)
            .TextColor(Colors.White)
            .CornerRadius(index % 2 == 0 ? 25 : 4)
            .HeightRequest(60);
}
