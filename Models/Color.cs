namespace _025_bb_the_color.Models;

public class Color
{
    // Properties
    public int Red { get; }
    public int Green { get; }
    public int Blue { get; }
    
    // Static properties
    public static Color PresetWhite { get; set; } = GetWhite();
    public static Color PresetBlack { get; set; } = GetBlack();
    public static Color PresetRed { get; set; } = GetRed();
    public static Color PresetOrange { get; set; } = GetOrange();
    public static Color PresetYellow { get; set; } = GetYellow();
    public static Color PresetGreen { get; set; } = GetGreen();
    public static Color PresetBlue { get; set; } = GetBlue();
    public static Color PresetPurple { get; set; } = GetPurple();

    // Constructors
    public Color(int r, int g, int b)
    {
        Red = r;
        Green = g;
        Blue = b;
    }

    // Methods
    private static Color GetWhite() => new Color(255, 255, 255);
    private static Color GetBlack() => new Color(0, 0, 0);
    private static Color GetRed() => new Color(255, 0, 0);
    private static Color GetOrange() => new Color(255, 165, 0);
    private static Color GetYellow() => new Color(255, 255, 0);
    private static Color GetGreen() => new Color(0, 128, 0);
    private static Color GetBlue() => new Color(0, 0, 255);
    private static Color GetPurple() => new Color(128, 0, 128);
}