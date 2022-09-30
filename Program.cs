// The Color
// :: Static ::

using System.Threading.Channels;
using  _025_bb_the_color.Models;

Console.Title = "The Color";
Console.Clear();

// Vars
Color customColor = new Color(123, 5, 234); // Const instance
Color presetColor = Color.White; // TODO

// Display result
Console.WriteLine($"{customColor.CustomRed}, {customColor.CustomGreen}, {customColor.CustomBlue}");
Console.WriteLine(presetColor); // TODO
// Need to use a static property for the presetColor var