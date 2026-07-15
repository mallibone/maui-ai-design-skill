# WorkoutSample - design

This palette was produced by running the [maui-app-design](../../maui-app-design)
skill with the brief: a workout app, mood **energetic / friendly**, no existing
brand colour, both themes.

- **Harmony**: complementary. Primary is a warm orange (hue ~18), the accent is
  its complement, a teal (hue ~190).
- **60-30-10**: warm neutral backgrounds carry the screen, the orange primary
  marks navigation and the main action, the teal accent appears once (the streak
  card).
- **Corner radius**: 12 (friendly), used on every card and button.
- **Spacing**: 4 / 8 / 12 / 16 / 24 / 32 only.
- **Icons**: FluentUI System Icons (Regular), code points verified against
  `FluentSystemIcons-Regular.json` - see `Helpers/IconFont.cs`.

## Palette

| Role            | Light     | Dark      | Contrast (text on its bg) |
| --------------- | --------- | --------- | ------------------------- |
| Primary         | `#C6410F` | `#F0895C` | white on light 5.04:1 / dark text on dark 7.18:1 |
| Accent          | `#0E7C86` | `#4FC4D6` | white on light 4.95:1 / dark text on dark 8.68:1 |
| Secondary       | `#F2A03D` | `#F2A03D` | decorative only           |
| Background      | `#F7F5F2` | `#1A1712` | -                         |
| Surface (cards) | `#FFFFFF` | `#24211B` | -                         |
| Text primary    | `#1E1B18` | `#ECE8E2` | 15.75:1 / 14.64:1 on bg   |
| Text secondary  | `#6B6560` | `#A39D95` | 5.28:1 / 6.65:1 on bg     |
| Success         | `#2E8B57` | -         | -                         |
| Warning         | `#E8A317` | -         | -                         |
| Error           | `#D2402F` | -         | -                         |

Every text/background pair clears WCAG AA (4.5:1 body, 3:1 large). Neutrals are
tinted warm; there is no pure black or white text pairing.
