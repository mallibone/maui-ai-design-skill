namespace WorkoutSample.Components;

// "Before" - plain text tabs, no icon font.
public class HomePage : Component
{
    public override VisualNode Render()
        => Shell(
            TabBar(
                ShellContent("Workouts")
                    .RenderContent(() => new WorkoutListPage()),
                ShellContent("Profile")
                    .RenderContent(() => new ProfilePage())
            )
        );
}
