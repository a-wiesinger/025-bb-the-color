namespace _025_bb_the_color.Models;

public class Color
{
    // Properties
    public int CustomRed { get; }
    public int CustomGreen { get;  }
    public int CustomBlue { get; }
    
    // Static color properties
    public static readonly Color White;
    // public static (int, int, int) Black { get; } = (0, 0, 0);
    // public static (int, int, int) Red { get; } = (255, 0, 0);
    // public static (int, int, int) Orange { get; } = (255, 165, 0);
    // public static (int, int, int) Yellow { get; } = (255, 255, 0);
    // public static (int, int, int) Green { get; } = (0, 128, 0);
    // public static (int, int, int) Blue { get; } = (0, 0, 255);
    // public static (int, int, int) Purple { get; } = (128, 0, 128);
    
    // Constructors
    public Color()
    {
        
    }
    
    public Color(int r, int g, int b)
    {
        CustomRed = r;
        CustomGreen = g;
        CustomBlue = b;
    }

    // static Color()
    // {
    //     White = (255, 255, 255);
    // }

    // public Color()
    // {
    //     White = (255, 255, 255);
    //     Black = (0, 0, 0);
    //     Red = (255, 0, 0);
    //     Orange = (255, 165, 0);
    //     Yellow = (255, 255, 0);
    //     Green = (0, 128, 0);
    //     Blue = (0, 0, 255);
    //     Purple = (128, 0, 128);
    // }
}