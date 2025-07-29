
# BorderlessTabControl

A drop‑in replacement for WinForms’ built‑in `TabControl` that removes the OS‑drawn border, paints its own buttons (owner‑draw), and keeps the page area _truly_ transparent so the parent control can shine through.

- It’s part of **[Core Keepers Workshop](https://github.com/RussDev7/CoreKeepersWorkshop)** and is released under the **GNU GPL v3**.

![CustomGUIUpdateRaw](https://github.com/user-attachments/assets/af62700a-807c-40a3-aabc-e5c669be9049)

---

## ✨ Key Features

| Feature                   | Details                                                                                                         |
|---------------------------|-----------------------------------------------------------------------------------------------------------------|
| **Borderless Look**       | Strips the standard window border and client edge.                                                              |
| **Owner-drawn Tabs**      | Renders its own buttons, bevels, separators, and pressed/selected states.                                       |
| **Transparent Page Area** | Lets the parent control’s background shine through.                                                             |
| **Uniform Heights**       | Forces `TabAppearance.Normal` to 24 px so it lines up with Buttons/FlatButtons.                                 |
| **Per-tab Theming**       | Store a `BorderlessTabControl.TabColorInfo` in `TabPage.Tag` to change the caption and face color individually. |
| **Pixel-perfect Images**  | Enable `NearestNeighborStretch` to scale pixel-art backgrounds without blur.                                    |
| **One-liner Theming**     | Call `RecolorAllTabs(ThemeMode.Dark|Light)` to recolor every tab.                                               |

---

## 📥 Installation
1. Copy **`BorderlessTabControl.cs`** into your WinForms project.
2. Change the namespace if needed.
3. Re-build; the control will now appear in the designer toolbox.

> ℹ️ No NuGet package (yet) – it’s a single self-contained file.

## 🚀 Quick Start

   ```csharp
   public partial class MainForm : Form
   {
       public MainForm()
       {
           InitializeComponent();

           var tabs = new BorderlessTabControl
           {
               Dock = DockStyle.Fill,       // or wherever you like
               Appearance = TabAppearance.FlatButtons
           };

           tabs.TabPages.Add("Home");
           tabs.TabPages.Add("Settings");

           Controls.Add(tabs);
       }
   }
   ```

### (Optional) Per-Tab Colors

   ```csharp
   var page1 = Main_BorderlessTabControl.TabPages[0];
   page1.Tag = new BorderlessTabControl.TabColorInfo(page1)
   {
       TextFore = Color.White,     // Caption (text) color.
       FaceBack = Color.SteelBlue, // Button background.
       PageBack = Color.AliceBlue  // Optional: Page background.
   };
   ```

### (Optional) Dark/Light Theme Helper

```csharp
using BorderlessTabControlExample; // Extension lives in the classes namespace.

Main_BorderlessTabControl.RecolorAllTabs(BorderlessTabControlExtensions.ThemeMode.Dark);
```

### (Optional) Crisp Pixel-Art Backgrounds

```csharp
Main_BorderlessTabControl.NearestNeighborStretch = true;
page1.BackgroundImage = Properties.Resources.PixelBackdrop;
```

---

## 🛠️ Public API

### Properties

| Property | Type | Purpose |
|----------|------|---------|
| `NearestNeighborStretch` | `bool` | When `true`, stretches `TabPage.BackgroundImage` with **nearest‑neighbor** interpolation (crisp pixels). Default `false` (high‑quality bicubic). |

### Methods / Events

`BorderlessTabControl` intentionally keeps its surface area small—most behaviour is internal.  
Anything you can do with the base `TabControl` still applies (add/remove pages, handle `Selecting`, etc.).

### Extension helpers

```csharp
Main_BorderlessTabControl.RecolorAllTabs(BorderlessTabControlExtensions.ThemeMode.Dark);
```

| Helper | What it does |
|--------|--------------|
| `RecolorAllTabs(ThemeMode theme)` | Iterates every `TabPage` and assigns dark/light `FaceBack` + `TextFore` colors without touching `Page.BackColor`. |

---

## 🎨 Theming & Styling Tips

* **Background images** – Set `TabPage.BackgroundImage` to a bitmap; it will fill the button surface (not the page) and honour `NearestNeighborStretch`.
* **Custom bevel colour** – Change the static `BevelColor` field to match your palette.
* **Dock = Fill inset** – The control intentionally shrinks its **parent** by 8 px on the _first_ handle‑creation when it’s `DockStyle.Fill`. Call `AdjustControlSize(true)` later if you need to re‑apply the inset.

---

## ⚙️ How It Works (Under the Hood)

* **CreateParams override** – Clears `WS_BORDER` and `WS_EX_CLIENTEDGE`.
* **`WndProc` hook** – Catches `TCM_ADJUSTRECT` to expand the client rect → page area stays transparent; swallows `WM_ERASEBKGND` to avoid flicker.
* **`OnPaint`** – Draws each button manually, including pressed/selected states and separators for `FlatButtons`.
* **Height fix** – `ReclaimNormalTabHeight()` sends `TCM_SETITEMSIZE` after handle creation to normalise `TabAppearance.Normal`.
* **Region syncing** – Builds a custom `Region` each time size/layout changes so hit‑testing matches the irregular outline.

---

## 📝 License

`BorderlessTabControl.cs` is licensed under **GNU General Public License v3.0**.  
See the root `LICENSE` file for the full text.

---

## 🙏 Credits

Original author: **RussDev7**  
Special thanks to the WinForms community for years of owner‑draw inspiration.

---

## 📷 Screenshots

_(Images showing the standard vs. borderless tab control.)_
<p align="center">
  <img src="https://github.com/user-attachments/assets/43b2d524-7517-4086-901c-b60d059666e6" alt="Normal TabControl Example"  width="45%">
  <img src="https://github.com/user-attachments/assets/1acce712-ddd0-4ebe-9a7d-f946b00f5449" alt="Borderless TabControl Example" width="45%">
</p>

---

> Found a bug or have an idea? Open an issue or pull request—contributions welcome!
