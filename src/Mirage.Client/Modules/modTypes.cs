using MessagePack;

namespace Mirage.Modules;

public static class modTypes
{
    // Winsock globals
    public const int GAME_PORT = 4000;

    // General constants
    public const string GAME_NAME = "Mirage Online";
    public const int MAX_PLAYERS = 70;
    public const int MAX_ITEMS = 255;
    public const int MAX_NPCS = 255;
    public const int MAX_INV = 50;
    public const int MAX_MAP_ITEMS = 20;
    public const int MAX_MAP_NPCS = 5;
    public const int MAX_SHOPS = 255;
    public const int MAX_PLAYER_SPELLS = 20;
    public const int MAX_SPELLS = 255;
    public const int MAX_TRADES = 8;

    public const int NO = 0;
    public const int YES = 1;

    // Account constants
    public const int NAME_LENGTH = 20;
    public const int MAX_CHARS = 3;

    // Sex constants
    public const int SEX_MALE = 0;
    public const int SEX_FEMALE = 1;

    // Map constants
    public const int MAX_MAPS = 1000;
    public const int MAX_MAPX = 15;
    public const int MAX_MAPY = 11;
    public const int MAP_MORAL_NONE = 0;
    public const int MAP_MORAL_SAFE = 1;

    // Image constants
    public const int PIC_X = 32;
    public const int PIC_Y = 32;

    // Tile consants
    public const int TILE_TYPE_WALKABLE = 0;
    public const int TILE_TYPE_BLOCKED = 1;
    public const int TILE_TYPE_WARP = 2;
    public const int TILE_TYPE_ITEM = 3;
    public const int TILE_TYPE_NPCAVOID = 4;
    public const int TILE_TYPE_KEY = 5;
    public const int TILE_TYPE_KEYOPEN = 6;

    // Item constants
    public const int ITEM_TYPE_NONE = 0;
    public const int ITEM_TYPE_WEAPON = 1;
    public const int ITEM_TYPE_ARMOR = 2;
    public const int ITEM_TYPE_HELMET = 3;
    public const int ITEM_TYPE_SHIELD = 4;
    public const int ITEM_TYPE_POTIONADDHP = 5;
    public const int ITEM_TYPE_POTIONADDMP = 6;
    public const int ITEM_TYPE_POTIONADDSP = 7;
    public const int ITEM_TYPE_POTIONSUBHP = 8;
    public const int ITEM_TYPE_POTIONSUBMP = 9;
    public const int ITEM_TYPE_POTIONSUBSP = 10;
    public const int ITEM_TYPE_KEY = 11;
    public const int ITEM_TYPE_CURRENCY = 12;
    public const int ITEM_TYPE_SPELL = 13;

    // Direction constants
    public const int DIR_UP = 0;
    public const int DIR_DOWN = 1;
    public const int DIR_LEFT = 2;
    public const int DIR_RIGHT = 3;

    // Constants for player movement
    public const int MOVING_WALKING = 1;
    public const int MOVING_RUNNING = 2;

    // Weather constants
    public const int WEATHER_NONE = 0;
    public const int WEATHER_RAINING = 1;
    public const int WEATHER_SNOWING = 2;

    // Time constants
    public const int TIME_DAY = 0;
    public const int TIME_NIGHT = 1;

    // Admin constants
    public const int ADMIN_MONITER = 1;
    public const int ADMIN_MAPPER = 2;
    public const int ADMIN_DEVELOPER = 3;
    public const int ADMIN_CREATOR = 4;

    // NPC constants
    public const int NPC_BEHAVIOR_ATTACKONSIGHT = 0;
    public const int NPC_BEHAVIOR_ATTACKWHENATTACKED = 1;
    public const int NPC_BEHAVIOR_FRIENDLY = 2;
    public const int NPC_BEHAVIOR_SHOPKEEPER = 3;
    public const int NPC_BEHAVIOR_GUARD = 4;

    // Spell constants
    public const int SPELL_TYPE_ADDHP = 0;
    public const int SPELL_TYPE_ADDMP = 1;
    public const int SPELL_TYPE_ADDSP = 2;
    public const int SPELL_TYPE_SUBHP = 3;
    public const int SPELL_TYPE_SUBMP = 4;
    public const int SPELL_TYPE_SUBSP = 5;
    public const int SPELL_TYPE_GIVEITEM = 6;


    public struct PlayerInvRec
    {
        public int Num;
        public int Value;
        public int Dur;
    }

    public struct PlayerRec()
    {
        // General
        public string Name = string.Empty;
        public byte Class;
        public int Sprite;
        public byte Level;
        public int Exp;
        public byte Access;
        public byte PK;

        // Vitals
        public int HP;
        public int MP;
        public int SP;

        // Stats
        public byte STR;
        public byte DEF;
        public byte SPEED;
        public byte MAGI;
        public byte POINTS;

        // Worn equipment
        public int ArmorSlot;
        public int WeaponSlot;
        public int HelmetSlot;
        public int ShieldSlot;

        // Inventory
        public readonly PlayerInvRec[] Inv = new PlayerInvRec[MAX_INV + 1];
        public readonly int[] Spell = new int[MAX_PLAYER_SPELLS + 1];

        // Position
        public int Map;
        public byte X;
        public byte Y;
        public byte Dir;

        // Client use only
        public int MaxHP;
        public int MaxMP;
        public int MaxSP;
        public int XOffset;
        public int YOffset;
        public int Moving;
        public byte Attacking;
        public int AttackTimer;
        public int MapGetTimer;
        public byte CastedSpell;
    }

    [MessagePackObject]
    public struct TileRec
    {
        [Key(0)] public int Ground;
        [Key(1)] public int Mask;
        [Key(2)] public int Anim;
        [Key(3)] public int Fringe;
        [Key(4)] public int Type;
        [Key(5)] public int Data1;
        [Key(6)] public int Data2;
        [Key(7)] public int Data3;
    }

    [MessagePackObject]
    public struct MapRec()
    {
        [Key(0)] public string Name = string.Empty;
        [Key(1)] public int Revision;
        [Key(2)] public int Moral;
        [Key(3)] public int Up;
        [Key(4)] public int Down;
        [Key(5)] public int Left;
        [Key(6)] public int Right;
        [Key(7)] public int Music;
        [Key(8)] public int BootMap;
        [Key(9)] public int BootX;
        [Key(10)] public int BootY;
        [Key(11)] public int Shop;
        [Key(12)] public TileRec[,] Tile = new TileRec[MAX_MAPX + 1, MAX_MAPY + 1];
        [Key(13)] public int[] Npc = new int[MAX_MAP_NPCS + 1];
    }

    public struct ClassRec()
    {
        public string Name = string.Empty;
        public int Sprite;

        public int STR;
        public int DEF;
        public int SPEED;
        public int MAGI;

        // For client use
        public int HP;
        public int MP;
        public int SP;
    }

    public struct ItemRec()
    {
        public string Name = string.Empty;

        public int Pic;
        public int Type;
        public int Data1;
        public int Data2;
        public int Data3;
    }

    public struct MapItemRec
    {
        public int Num;
        public int Value;
        public int Dur;

        public int X;
        public int Y;
    }

    public struct NpcRec()
    {
        public string Name = string.Empty;
        public string AttackSay = string.Empty;

        public int Sprite;
        public int SpawnSecs;
        public int Behavior;
        public int Range;

        public int DropChance;
        public int DropItem;
        public int DropItemValue;

        public int STR;
        public int DEF;
        public int SPEED;
        public int MAGI;
    }

    public struct MapNpcRec
    {
        public int Num;

        public int Target;

        public int HP;
        public int MP;
        public int SP;

        public int Map;
        public int X;
        public int Y;
        public int Dir;

        // Client use only
        public int XOffset;
        public int YOffset;
        public int Moving;
        public byte Attacking;
        public int AttackTimer;
    }

    public struct TradeItemRec
    {
        public int GiveItem;
        public int GiveValue;
        public int GetItem;
        public int GetValue;
    }

    public struct ShopRec()
    {
        public string Name = string.Empty;
        public string JoinSay = string.Empty;
        public string LeaveSay = string.Empty;
        public int FixesItems;
        public readonly TradeItemRec[] TradeItem = new TradeItemRec[MAX_TRADES + 1];
    }

    public struct SpellRec()
    {
        public string Name = string.Empty;
        public int ClassReq;
        public int LevelReq;
        public int Type;
        public int Data1;
        public int Data2;
        public int Data3;
    }

    public struct TempTileRec
    {
        public int DoorOpen;
    }

    // Used for parsing
    public static readonly char SEP_CHAR = (char) 0;

    // Maximum classes
    public static int Max_Classes;

    public static MapRec Map = new();
    public static readonly TempTileRec[,] TempTile = new TempTileRec[MAX_MAPX + 1, MAX_MAPY + 1];
    public static readonly PlayerRec[] Player = new PlayerRec[MAX_PLAYERS + 1];
    public static ClassRec[] Class = [];
    public static readonly ItemRec[] Item = new ItemRec[MAX_ITEMS + 1];
    public static readonly NpcRec[] Npc = new NpcRec[MAX_NPCS + 1];
    public static readonly MapItemRec[] MapItem = new MapItemRec[MAX_MAP_ITEMS + 1];
    public static readonly MapNpcRec[] MapNpc = new MapNpcRec[MAX_MAP_NPCS + 1];
    public static readonly ShopRec[] Shop = new ShopRec[MAX_SHOPS + 1];
    public static readonly SpellRec[] Spell = new SpellRec[MAX_SPELLS + 1];

    static modTypes()
    {
        for (var i = 0; i < Player.Length; i++)
        {
            Player[i] = new PlayerRec();
        }
        
        for (var i = 0; i < Item.Length; i++)
        {
            Item[i] = new ItemRec();
        }
        
        for (var i = 0; i < Npc.Length; i++)
        {
            Npc[i] = new NpcRec();
        }
        
        for (var i = 0; i < MapItem.Length; i++)
        {
            MapItem[i] = new MapItemRec();
        }
        
        for (var i = 0; i < MapNpc.Length; i++)
        {
            MapNpc[i] = new MapNpcRec();
        }
        
        for (var i = 0; i < Shop.Length; i++)
        {
            Shop[i] = new ShopRec();
        }

        for (var i = 0; i < Spell.Length; i++)
        {
            Spell[i] = new SpellRec();
        }

        ClearTempTile();
    }

    public static void ClearTempTile()
    {
        for (var x = 0; x <= MAX_MAPX; x++)
        {
            for (var y = 0; y <= MAX_MAPY; y++)
            {
                TempTile[x, y].DoorOpen = NO;
            }
        }
    }
    
    public static void ClearItem(int index)
    {
        Item[index].Name = "";

        Item[index].Type = 0;
        Item[index].Data1 = 0;
        Item[index].Data2 = 0;
        Item[index].Data3 = 0;
    }

    public static void ClearItems()
    {
        for (var i = 1; i <= MAX_ITEMS; i++)
        {
            ClearItem(i);
        }
    }

    public static void ClearMapItem(int index)
    {
        MapItem[index].Num = 0;
        MapItem[index].Value = 0;
        MapItem[index].Dur = 0;
        MapItem[index].X = 0;
        MapItem[index].Y = 0;
    }

    public static void ClearMapItems()
    {
        for (var i = 1; i <= MAX_MAP_ITEMS; i++)
        {
            ClearMapItem(i);
        }
    }

    public static void ClearMapNpc(int index)
    {
        MapNpc[index].Num = 0;
        MapNpc[index].Target = 0;
        MapNpc[index].HP = 0;
        MapNpc[index].MP = 0;
        MapNpc[index].SP = 0;
        MapNpc[index].Map = 0;
        MapNpc[index].X = 0;
        MapNpc[index].Y = 0;
        MapNpc[index].Dir = 0;

        // Client use only
        MapNpc[index].XOffset = 0;
        MapNpc[index].YOffset = 0;
        MapNpc[index].Moving = 0;
        MapNpc[index].Attacking = 0;
        MapNpc[index].AttackTimer = 0;
    }

    public static void ClearMapNpcs()
    {
        for (var i = 1; i <= MAX_MAP_NPCS; i++)
        {
            ClearMapNpc(i);
        }
    }

    public static void ClearMap()
    {
        Map.Name = "";
        Map.Revision = 0;
        Map.Moral = 0;
        Map.Up = 0;
        Map.Down = 0;
        Map.Left = 0;
        Map.Right = 0;

        for (var x = 0; x < MAX_MAPX; x++)
        {
            for (var y = 0; y < MAX_MAPY; y++)
            {
                Map.Tile[x, y].Ground = 0;
                Map.Tile[x, y].Mask = 0;
                Map.Tile[x, y].Anim = 0;
                Map.Tile[x, y].Fringe = 0;
                Map.Tile[x, y].Type = 0;
                Map.Tile[x, y].Data1 = 0;
                Map.Tile[x, y].Data2 = 0;
                Map.Tile[x, y].Data3 = 0;
            }
        }
    }

    public static string GetPlayerName(int index)
    {
        return Player[index].Name;
    }

    public static void SetPlayerName(int index, string name)
    {
        Player[index].Name = name;
    }

    public static int GetPlayerClass(int index)
    {
        return Player[index].Class;
    }

    public static void SetPlayerClass(int index, int classNum)
    {
        Player[index].Class = (byte) classNum;
    }

    public static int GetPlayerSprite(int index)
    {
        return Player[index].Sprite;
    }

    public static void SetPlayerSprite(int index, int spriteNum)
    {
        Player[index].Sprite = spriteNum;
    }

    public static int GetPlayerLevel(int index)
    {
        return Player[index].Level;
    }

    public static void SetPlayerLevel(int index, int level)
    {
        Player[index].Level = (byte) level;
    }

    public static int GetPlayerExp(int index)
    {
        return Player[index].Exp;
    }

    public static void SetPlayerExp(int index, int exp)
    {
        Player[index].Exp = exp;
    }

    public static int GetPlayerAccess(int index)
    {
        return Player[index].Access;
    }

    public static void SetPlayerAccess(int index, int access)
    {
        Player[index].Access = (byte) access;
    }

    public static int GetPlayerPK(int index)
    {
        return Player[index].PK;
    }

    public static void SetPlayerPK(int index, int pk)
    {
        Player[index].PK = (byte) pk;
    }


    public static int GetPlayerHP(int index)
    {
        return Player[index].HP;
    }

    public static void SetPlayerHP(int index, int hp)
    {
        Player[index].HP = hp;

        if (GetPlayerHP(index) > GetPlayerMaxHP(index))
        {
            Player[index].HP = GetPlayerMaxHP(index);
        }
    }

    public static int GetPlayerMP(int index)
    {
        return Player[index].MP;
    }

    public static void SetPlayerMP(int index, int mp)
    {
        Player[index].MP = mp;

        if (GetPlayerMP(index) > GetPlayerMaxMP(index))
        {
            Player[index].MP = GetPlayerMaxMP(index);
        }
    }

    public static int GetPlayerSP(int index)
    {
        return Player[index].SP;
    }

    public static void SetPlayerSP(int index, int sp)
    {
        Player[index].SP = sp;

        if (GetPlayerSP(index) > GetPlayerMaxSP(index))
        {
            Player[index].SP = GetPlayerMaxSP(index);
        }
    }

    public static int GetPlayerMaxHP(int index)
    {
        return Player[index].MaxHP;
    }

    public static int GetPlayerMaxMP(int index)
    {
        return Player[index].MaxMP;
    }

    public static int GetPlayerMaxSP(int index)
    {
        return Player[index].MaxSP;
    }


    public static int GetPlayerSTR(int index)
    {
        return Player[index].STR;
    }

    public static void SetPlayerSTR(int index, int str)
    {
        Player[index].STR = (byte) str;
    }

    public static int GetPlayerDEF(int index)
    {
        return Player[index].DEF;
    }

    public static void SetPlayerDEF(int index, int def)
    {
        Player[index].DEF = (byte) def;
    }

    public static int GetPlayerSPEED(int index)
    {
        return Player[index].SPEED;
    }

    public static void SetPlayerSPEED(int index, int speed)
    {
        Player[index].SPEED = (byte) speed;
    }

    public static int GetPlayerMAGI(int index)
    {
        return Player[index].MAGI;
    }

    public static void SetPlayerMAGI(int index, int magi)
    {
        Player[index].MAGI = (byte) magi;
    }

    public static int GetPlayerPOINTS(int index)
    {
        return Player[index].POINTS;
    }

    public static void SetPlayerPOINTS(int index, int points)
    {
        Player[index].POINTS = (byte) points;
    }

    public static int GetPlayerMap(int index)
    {
        return Player[index].Map;
    }

    public static void SetPlayerMap(int index, int mapNum)
    {
        Player[index].Map = mapNum;
    }

    public static int GetPlayerX(int index)
    {
        return Player[index].X;
    }

    public static void SetPlayerX(int index, int x)
    {
        Player[index].X = (byte) x;
    }

    public static int GetPlayerY(int index)
    {
        return Player[index].Y;
    }

    public static void SetPlayerY(int index, int y)
    {
        Player[index].Y = (byte) y;
    }

    public static int GetPlayerDir(int index)
    {
        return Player[index].Dir;
    }

    public static void SetPlayerDir(int index, int dir)
    {
        Player[index].Dir = (byte) dir;
    }

    public static int GetPlayerInvItemNum(int index, int invSlot)
    {
        return Player[index].Inv[invSlot].Num;
    }

    public static void SetPlayerInvItemNum(int index, int invSlot, int itemNum)
    {
        Player[index].Inv[invSlot].Num = itemNum;
    }

    public static int GetPlayerInvItemValue(int index, int invSlot)
    {
        return Player[index].Inv[invSlot].Value;
    }

    public static void SetPlayerInvItemValue(int index, int invSlot, int itemValue)
    {
        Player[index].Inv[invSlot].Value = itemValue;
    }

    public static int GetPlayerInvItemDur(int index, int invSlot)
    {
        return Player[index].Inv[invSlot].Dur;
    }

    public static void SetPlayerInvItemDur(int index, int invSlot, int itemDur)
    {
        Player[index].Inv[invSlot].Dur = itemDur;
    }

    public static int GetPlayerArmorSlot(int index)
    {
        return Player[index].ArmorSlot;
    }

    public static void SetPlayerArmorSlot(int index, int invNum)
    {
        Player[index].ArmorSlot = invNum;
    }

    public static int GetPlayerWeaponSlot(int index)
    {
        return Player[index].WeaponSlot;
    }

    public static void SetPlayerWeaponSlot(int index, int invNum)
    {
        Player[index].WeaponSlot = invNum;
    }

    public static int GetPlayerHelmetSlot(int index)
    {
        return Player[index].HelmetSlot;
    }

    public static void SetPlayerHelmetSlot(int index, int invNum)
    {
        Player[index].HelmetSlot = invNum;
    }

    public static int GetPlayerShieldSlot(int index)
    {
        return Player[index].ShieldSlot;
    }

    public static void SetPlayerShieldSlot(int index, int invNum)
    {
        Player[index].ShieldSlot = invNum;
    }
}