# maui-ai-design-skill

An [Agent Skills](https://agentskills.io) skill that gives Claude and GitHub
Copilot enough colour theory, typography and icon-font know-how to produce a
decent initial UI design for a .NET MAUI app - so your apps stop looking like
developer art.

Companion code for the blog post
[*From developer art to good looking apps*](https://mallibone.com/2026/07/15/maui-ai-design-skill.html)
(MAUI UI July 2026).

## What's here

| Folder | What it is |
| ------ | ---------- |
| [`maui-app-design/`](maui-app-design) | The skill. One `SKILL.md`, works in Claude Code and GitHub Copilot. |
| [`sample/WorkoutSample`](sample/WorkoutSample) | A small **MAUI Reactor** workout app the skill designed. `main` is the skill-designed version. |

The `before` branch of this repo holds the same app *before* the skill touched
it - the developer-art version - so you can diff the two and reproduce the
before/after screenshots.

## The skill

See [`maui-app-design/README.md`](maui-app-design/README.md) for install and
usage. Short version:

- **Claude Code**: copy the folder to `.claude/skills/` (or `~/.claude/skills/`)
  and run `/maui-app-design`. It's pinned to Haiku - the thinking lives in the
  skill, so a small model executes it fine.
- **GitHub Copilot**: copy it to `.github/skills/` and ask for an app design in
  agent mode.

## The sample

The sample is a MAUI Reactor app, because the skill's output (XAML
`Colors.xaml` / `Styles.xaml`, an icon font and a `Helpers/IconFont.cs`) drops
straight into a Reactor project - see [`sample/WorkoutSample/DESIGN.md`](sample/WorkoutSample/DESIGN.md)
for the generated palette and the WCAG contrast table.

```bash
cd sample/WorkoutSample
dotnet build -t:Run -f net10.0-ios      # or net10.0-maccatalyst / net10.0-android
```
