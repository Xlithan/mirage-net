using SFML.Graphics;
using SFML.System;
using Color = System.Drawing.Color;

namespace Mirage.Modules;

public static class modText
{
    public const int Black = 0;
    public const int Blue = 1;
    public const int Green = 2;
    public const int Cyan = 3;
    public const int Red = 4;
    public const int Magenta = 5;
    public const int Brown = 6;
    public const int Grey = 7;
    public const int DarkGrey = 8;
    public const int BrightBlue = 9;
    public const int BrightGreen = 10;
    public const int BrightCyan = 11;
    public const int BrightRed = 12;
    public const int Pink = 13;
    public const int Yellow = 14;
    public const int White = 15;

    public const int SayColor = Grey;
    public const int GlobalColor = BrightGreen;
    public const int TellColor = Cyan;
    public const int EmoteColor = BrightCyan;
    public const int HelpColor = Magenta;
    public const int WhoColor = Pink;
    public const int JoinLeftColor = DarkGrey;
    public const int NpcColor = Brown;
    public const int AlertColor = Red;
    public const int NewMapColor = Pink;

    public static Color GetColor(int color)
    {
        return color switch
        {
            Black => Color.Black,
            Blue => Color.Blue,
            Green => Color.Green,
            Cyan => Color.Cyan,
            Red => Color.Red,
            Magenta => Color.Magenta,
            Brown => Color.Brown,
            Grey => Color.Gray,
            DarkGrey => Color.DimGray,
            BrightBlue => Color.DodgerBlue,
            BrightGreen => Color.LawnGreen,
            BrightCyan => Color.LightCyan,
            BrightRed => Color.OrangeRed,
            Pink => Color.HotPink,
            Yellow => Color.Yellow,
            White => Color.White,
            _ => Color.Black,
        };
    }

    private static SFML.Graphics.Color GetSfmlColor(Color color)
    {
        return new SFML.Graphics.Color(color.R, color.G, color.B, color.A);
    }

    private static SFML.Graphics.Color GetSfmlColor(int color)
    {
        return GetSfmlColor(GetColor(color));
    }

    public static void DrawText(int x, int y, string text, int color)
    {
        var s = new Text(text, modDirectX.Font, 14);
        s.Position = new Vector2f(x, y);
        s.FillColor = GetSfmlColor(color);
        s.OutlineColor = SFML.Graphics.Color.Black;
        s.OutlineThickness = 1;
        modDirectX.Renderer.Draw(s);
    }

    public static int MeasureText(string text)
    {
        var s = new Text(text, modDirectX.Font, 14);
        return (int) s.GetLocalBounds().Width;
    }

    public static void AddText(string msg, int color)
    {
        My.Forms.frmMirage.txtChat.SelectionStart = My.Forms.frmMirage.txtChat.TextLength;
        My.Forms.frmMirage.txtChat.SelectionColor = GetColor(color);
        My.Forms.frmMirage.txtChat.SelectedText = $"\r\n{msg}";
        My.Forms.frmMirage.txtChat.SelectionStart = My.Forms.frmMirage.txtChat.TextLength;
        My.Forms.frmMirage.txtChat.ScrollToCaret();
    }
}