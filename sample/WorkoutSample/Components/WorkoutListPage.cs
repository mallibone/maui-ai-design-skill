using Microsoft.Maui;
using Microsoft.Maui.Graphics;
using MauiReactor.Shapes;
using WorkoutSample.Helpers;
using WorkoutSample.Resources.Styles;

namespace WorkoutSample.Components;

record WorkoutMode(string Icon, string Title, string Subtitle);

class WorkoutListPage : Component
{
    static readonly WorkoutMode[] Modes =
    {
        new(IconFont.Timer, "AMRAP", "As many rounds as possible"),
        new(IconFont.HeartPulse, "EMOM", "Every minute on the minute"),
        new(IconFont.Dumbbell, "For Time", "Finish the work, beat the clock"),
        new(IconFont.Trophy, "TABATA", "20s on, 10s off, eight rounds"),
    };

    public override VisualNode Render()
        => ContentPage(
            ScrollView(
                VStack(
                    Label("Today")
                        .FontSize(32)
                        .FontAttributes(FontAttributes.Bold)
                        .TextColor(ApplicationTheme.OnBackground),

                    Label("Ready to train?")
                        .FontSize(16)
                        .TextColor(ApplicationTheme.OnBackgroundMuted)
                        .Margin(0, 0, 0, 8),

                    StreakCard(),

                    Label("Choose a mode")
                        .FontSize(13)
                        .FontAttributes(FontAttributes.Bold)
                        .TextColor(ApplicationTheme.OnBackgroundMuted)
                        .Margin(0, 8, 0, 0),

                    VStack(Modes.Select(ModeCard).ToArray())
                        .Spacing(12),

                    Button("Start workout")
                        .BackgroundColor(ApplicationTheme.BrandPrimary)
                        .TextColor(ApplicationTheme.OnBrand)
                        .FontAttributes(FontAttributes.Bold)
                        .CornerRadius(ApplicationTheme.CornerRadius)
                        .HeightRequest(52)
                        .Margin(0, 16, 0, 0)
                )
                .Spacing(16)
                .Padding(24)
            )
            .BackgroundColor(ApplicationTheme.PageBackground)
        )
        .BackgroundColor(ApplicationTheme.PageBackground);

    static VisualNode StreakCard()
        => Border(
            Grid("Auto", "Auto,*",
                Label(IconFont.HeartPulse)
                    .FontFamily(IconFont.FontFamily)
                    .FontSize(30)
                    .TextColor(ApplicationTheme.OnBrand)
                    .VCenter()
                    .GridColumn(0)
                    .Margin(0, 0, 16, 0),
                VStack(
                    Label("12 workouts this month")
                        .FontSize(18)
                        .FontAttributes(FontAttributes.Bold)
                        .TextColor(ApplicationTheme.OnBrand),
                    Label("3 day streak - keep it going")
                        .FontSize(13)
                        .TextColor(ApplicationTheme.OnBrand)
                )
                .Spacing(2)
                .VCenter()
                .GridColumn(1)
            )
            .Padding(20)
        )
        .BackgroundColor(ApplicationTheme.BrandAccent)
        .StrokeThickness(0)
        .StrokeShape(new RoundRectangle().CornerRadius(ApplicationTheme.CornerRadius));

    static VisualNode ModeCard(WorkoutMode mode)
        => Border(
            Grid("Auto", "48,*,Auto",
                Label(mode.Icon)
                    .FontFamily(IconFont.FontFamily)
                    .FontSize(26)
                    .TextColor(ApplicationTheme.BrandPrimary)
                    .HorizontalTextAlignment(TextAlignment.Center)
                    .VCenter()
                    .GridColumn(0),
                VStack(
                    Label(mode.Title)
                        .FontSize(17)
                        .FontAttributes(FontAttributes.Bold)
                        .TextColor(ApplicationTheme.OnBackground),
                    Label(mode.Subtitle)
                        .FontSize(13)
                        .TextColor(ApplicationTheme.OnBackgroundMuted)
                )
                .Spacing(2)
                .VCenter()
                .GridColumn(1),
                Label(IconFont.ChevronRight)
                    .FontFamily(IconFont.FontFamily)
                    .FontSize(20)
                    .TextColor(ApplicationTheme.OnBackgroundMuted)
                    .VCenter()
                    .GridColumn(2)
            )
            .Padding(16)
        )
        .BackgroundColor(ApplicationTheme.CardBackground)
        .StrokeThickness(0)
        .StrokeShape(new RoundRectangle().CornerRadius(ApplicationTheme.CornerRadius));
}
