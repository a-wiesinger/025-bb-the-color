// The Color
// :: Static ::

using  _025_bb_the_color.Models;

Console.Title = "The Color";
Console.Clear();

// Variables
Color customColor = new Color(123, 5, 234);
Color presetColor = Color.PresetGreen; // Change property to access diff colors

// Display result
Console.WriteLine($"Custom: {customColor.Red}, {customColor.Green}, {customColor.Blue}");
Console.WriteLine($"Preset: {presetColor.Red}, {presetColor.Green}, {presetColor.Blue}");