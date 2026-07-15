# maui-app-design skill

One SKILL.md, two assistants. The [Agent Skills](https://agentskills.io)
format is an open standard, so the same file works in Claude Code and GitHub
Copilot.

## Install

**Claude Code** - copy the folder to your app repository:

```bash
mkdir -p .claude/skills
cp -r maui-app-design .claude/skills/
```

Or install it user-wide under `~/.claude/skills/maui-app-design`.

**GitHub Copilot (VS Code, CLI, coding agent)** - copy the folder to:

```bash
mkdir -p .github/skills
cp -r maui-app-design .github/skills/
```

Tip: keep one copy and symlink the other location so the two never drift.

## Use

- Claude Code: type `/maui-app-design` or just ask "design the UI for my new
  app". The `model: haiku` frontmatter runs it on Haiku - cheap and fast,
  because the skill already contains the thinking.
- Copilot: use agent mode and ask for an initial app design; Copilot picks the
  skill up automatically. Copilot ignores the `model` field.
