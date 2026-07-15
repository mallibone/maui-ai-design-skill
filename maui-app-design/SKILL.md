---
name: maui-app-design
description: >
  Create the initial UI design for a .NET MAUI app. Produces a colour palette
  based on colour theory, sets up an icon font (FluentUI System Icons) and
  generates Colors.xaml, Styles.xaml and the first page scaffolds. Use when
  starting a new MAUI app, when asked to design or restyle app screens, or when
  the UI still looks like the default template.
model: haiku
---

# .NET MAUI initial app design

You are designing the visual foundation of a .NET MAUI app. Follow the steps
in order and do not skip any. Where a step says ASK, ask the user and wait for
the answer. Everywhere else decide yourself using the rules given - do not ask
for permission for decisions the rules already cover.

## Step 1 - Gather the design brief

ASK the user (skip a question if the answer is already known from context):

1. What does the app do? (one sentence)
2. Pick two mood words: calm / trustworthy / professional / playful /
   friendly / energetic / bold
3. Is there an existing brand colour? (hex value, otherwise "none")
4. Light theme, dark theme, or both? (default: both)

## Step 2 - Build the colour palette

### 2.1 Primary colour

- If the user gave a brand colour, that is the primary.
- Otherwise derive it from the mood words:
  - calm / trustworthy: a blue or teal, hue 190-230
  - professional: a desaturated blue or green, saturation 40-60%
  - playful / friendly: orange, coral or violet
  - energetic / bold: a saturated red, orange or magenta

### 2.2 Harmony scheme

Pick the scheme from the FIRST mood word:

| Mood                          | Scheme        | Rule                                      |
| ----------------------------- | ------------- | ----------------------------------------- |
| calm, trustworthy, professional | analogous   | secondary hue = primary hue ± 30°         |
| playful, friendly             | triadic       | secondary/accent = primary hue ± 120°     |
| energetic, bold               | complementary | accent = primary hue + 180°               |

### 2.3 The 60-30-10 rule

Distribute colours so that roughly:

- 60% of any screen is neutral (backgrounds, surfaces)
- 30% is the primary colour (navigation, buttons, headers)
- 10% is the accent colour (highlights, badges, the one action that matters)

The accent is the loudest colour on screen. If everything is accent, nothing
is.

### 2.4 Neutrals

Never use pure black `#000000` or pure white `#FFFFFF`.

- Light theme: background `#F7F7F9`, surface `#FFFFFF` is allowed for cards
  only, text `#1A1A1E`, secondary text `#5A5A66`
- Dark theme: background `#141419`, surface `#1E1E26`, text `#E8E8ED`,
  secondary text `#9A9AA6`
- Tint the neutrals 2-4% towards the primary hue so the app feels coherent.

### 2.5 Dark theme variants

For the dark theme, take the light theme primary and accent and:

- raise lightness by 10-15%
- lower saturation by 10-20%

Saturated colours vibrate on dark backgrounds - always desaturate.

### 2.6 Semantic colours

Add Success (green, ~#2E7D32), Warning (amber, ~#F5A623) and Error (red,
~#D32F2F). Nudge their hues slightly towards the palette temperature (warm
palette = warmer green, cool palette = cooler red).

### 2.7 Contrast check

Every text/background pair must reach WCAG AA: 4.5:1 for body text, 3:1 for
text 24px and larger. Compute the contrast ratio for every pair you deliver.
If a pair fails, adjust the lightness of the text colour until it passes -
never ship a failing pair.

### 2.8 Deliverables of this step

1. A markdown table: colour name, hex (light), hex (dark), role, contrast
   ratio against its background.
2. `Resources/Styles/Colors.xaml` with at least these keys: `Primary`,
   `PrimaryDark`, `Secondary`, `Accent`, `Background`, `BackgroundDark`,
   `Surface`, `SurfaceDark`, `TextPrimary`, `TextPrimaryDark`,
   `TextSecondary`, `TextSecondaryDark`, `Success`, `Warning`, `Error`.

## Step 3 - Icon font

Use FluentUI System Icons as the icon font.

1. Tell the user to download `FluentSystemIcons-Regular.ttf` from the `fonts`
   folder of https://github.com/microsoft/fluentui-system-icons and place it
   in `Resources/Fonts`.
2. Register it in `MauiProgram.cs`:

   ```csharp
   fonts.AddFont("FluentSystemIcons-Regular.ttf", "FluentIcons");
   ```

3. Create a `Helpers/IconFont.cs` static class with one `const string` per
   icon the app needs, for example:

   ```csharp
   public static class IconFont
   {
       public const string Home = "\uE9A9"; // example - always verify, see below
   }
   ```

   IMPORTANT: never guess glyph code points. Look every code up in
   `FluentSystemIcons-Regular.json`, which lives next to the .ttf in the same
   repository folder. If you cannot verify a code, leave a `TODO` comment and
   say so.

4. Usage rules:
   - Tab bar and toolbar icons: `FontImageSource`, size 24
   - Inline icons: `Label` with `FontFamily="FluentIcons"`, size 20
   - Icons use `TextSecondary` colour unless they are interactive - then
     `Primary`.
   - Pick either the Regular or the Filled variant and stay with it. Mixing
     both on one screen looks broken.

## Step 4 - Styles

Generate `Resources/Styles/Styles.xaml`:

- Spacing: only use values from the scale 4 / 8 / 12 / 16 / 24 / 32.
- Corner radius: pick ONE value (8 for professional, 12 for friendly, 24 for
  playful) and use it on every button and card.
- Styles to create: primary `Button`, secondary (outline) `Button`,
  `Label` styles `Headline` (28-32, semibold), `Body` (16), `Caption`
  (13, TextSecondary), and a card `Border` style.
- Every colour reference uses `AppThemeBinding` with the light and dark
  resource, never a literal hex value.

## Step 5 - Verify

Before finishing, confirm this checklist and show it to the user:

- [ ] All text/background pairs pass WCAG AA
- [ ] No literal hex values in any page - only `StaticResource` /
      `AppThemeBinding`
- [ ] Icon font registered and glyph codes verified against the JSON mapping
- [ ] Corner radius and spacing scale used consistently
- [ ] Both themes covered (if requested)

Finish with the palette table and a short list of the files you created or
changed.
