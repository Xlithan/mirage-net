using SFML.Graphics;
using Font = SFML.Graphics.Font;

namespace Mirage.Modules;

public static class modDirectX
{
    public static RenderWindow Renderer = null!;

    public static Texture DDSD_Sprite;
    public static Texture DDSD_Tile;
    public static Texture DDSD_Item;

    public static Font Font;

    public static void InitDirectX()
    {
        // Initialize direct draw
        My.Forms.frmMirage.Show();

        Renderer = new RenderWindow(My.Forms.frmMirage.picScreen.Handle);

        // Initialize all surfaces
        InitSurfaces();
    }

    public static void InitSurfaces()
    {
        if (!modDatabase.FileExist("Assets/Sprites.png") ||
            !modDatabase.FileExist("Assets/Tiles.png") ||
            !modDatabase.FileExist("Assets/Items.png"))
        {
            MessageBox.Show(
                "You dont have the graphics files in the same directory as this executable!",
                modTypes.GAME_NAME,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            modGameLogic.GameDestroy();
        }

        DDSD_Sprite = new Texture("Assets/Sprites.png");
        DDSD_Tile = new Texture("Assets/Tiles.png");
        DDSD_Item = new Texture("Assets/Items.png");

        Font = new Font("Assets/Fonts/LiberationSans-Regular.ttf");
        Font.SetSmooth(false);
    }
}