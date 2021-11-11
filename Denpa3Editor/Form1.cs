using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Denpa3Editor
{
    public partial class Form1 : Form
    {
        // For saving file, will be reused

        FileStream save_stream;

        // Offsets for denpa values

        enum Offsets : int
        {
            name = 0x13A50,
            antenna = 0x13AA8,
            headshape = 0x13A8F,
            faceshape = 0x13A90,
            hair = 0x13A91,
            eyebrows = 0x13A92,
            eyes = 0x13A93,
            nose = 0x13A94,
            mouth = 0x13A95,
            cheeks = 0x13A96,
            glasses = 0x13A97,
            body = 0x13A98,
            color = 0x13A9A,
            skin = 0x13A9B,
            haircolor = 0x13A9C,
            antenna_appearances = 0x13A8E,
            level = 0x13AAC,
            jewels = 0x0000,
            gold = 0x00,
            ap = 0x13AB0,
            hp = 0x13AAE,
            new_denpa = 0x13A40,
            goldandjewels = 0x655,
        }

        // Default Value for creating new denpas

        byte[] new_denpa = { 0x02, 0x00, 0x11, 0x00, 0x91, 0x78, 0x05, 0x2A, 0x02, 0x00, 0x00, 0x00, 0xD8, 0x1A, 0x00, 0x00, 0x4E, 0x00, 0x65, 0x00, 0x77, 0x00, 0x20, 0x00, 0x44, 0x00, 0x65, 0x00, 0x6E, 0x00, 0x70, 0x00, 0x61, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x06, 0x00, 0x00, 0x01, 0x00, 0x00, 0x01, 0x00, 0x83, 0x07, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xC7, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xE0, 0x15, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x04, 0x00, 0x00, 0x00 };

        // For opening, saving, and storing file.

        string file_name;
        string short_file_name;
        byte[] sf_buffer = new byte[348000];

        // Used to keep forms from updating

        bool loading = false;

        // Used for writing to PictureBox

        Graphics g;
        Image dat;
        Rectangle cloneRect;
        Bitmap decals = (Bitmap)Properties.Resources.decals;
  
        // Antenna Values

        Dictionary<string, int> antenna_values = new Dictionary<string, int>()
        {
            {"None", 0},
            {"Treasure", 1},
            {"Rare Treasure", 2},
            {"Gold", 3},
            {"Stealthy", 4},
            {"Heal", 5},
            {"Heal (All)", 6},
            {"Revive", 7},
            {"Revive (All)", 8},
            {"Antidote", 9},
            {"Cure Burn", 10},
            {"Dry", 11},
            {"Cure Sniffles", 12},
            {"Mud Off", 13},
            {"Purify", 14},
            {"Cure Shock", 15},
            {"Hot Blanket", 16},
            {"Mobilize", 17},
            {"Awaken", 18},
            {"Eye drops", 19},
            {"Invincible", 20},
            {"Excite", 21},
            {"Steroids", 22},
            {"Reflect", 23},
            {"Rage", 24},
            {"Rage (All)", 25},
            {"Wall", 26},
            {"Wall (All)", 27},
            {"Haste", 28},
            {"Haste (All)", 29},
            {"Dodge", 30},
            {"Dodge (All)", 31},
            {"Poison Signal", 32},
            {"Fatal", 33},
            {"Lullaby", 34},
            {"Paralyze", 35},
            {"Blindfold", 36},
            {"Breath Plug", 37},
            {"Weaken", 38},
            {"Weaken (All)", 39},
            {"Insult", 40},
            {"Insult (All)", 41},
            {"Chain", 42},
            {"Chain (All)", 43},
            {"Fireball", 44},
            {"Fire Cracker", 45},
            {"Forest Fire", 46},
            {"Icicle", 47},
            {"On The Rocks", 48},
            {"Hailstorm", 49},
            {"Whirlwind", 50},
            {"Breeze", 51},
            {"Twister", 52},
            {"Falling Rock", 53},
            {"Pebbles", 54},
            {"Magnitude 3", 55},
            {"Static", 56},
            {"Lightning", 57},
            {"100 Volts", 58},
            {"Water Gun", 59},
            {"Bucket of Water", 60},
            {"High Wave", 61},
            {"Weak Flash", 62},
            {"Spotlight", 63},
            {"Winter Sunlight", 64},
            {"Scare", 65},
            {"Dark Ball", 66},
            {"Dark Mist", 67},
            {"Catch", 68},
        };

        Dictionary<string, Tuple<int, string>> antenna_appearance_values = new Dictionary<string, Tuple<int, string>>()
        {
            {"None", Tuple.Create(0,"None")},
            {"Antenna Root", Tuple.Create(1,"Revive")},
            {"Treasure x2", Tuple.Create(2,"Treasure")},
            {"Treasure x3", Tuple.Create(3,"Treasure")},
            {"Treasure x5", Tuple.Create(4,"Treasure")},
            {"Rare Treasure x2", Tuple.Create(5,"Rare Treasure")},
            {"Rare Treasure x3", Tuple.Create(6,"Rare Treasure")},
            {"Rare Treasure x5", Tuple.Create(7,"Rare Treasure")},
            {"Gold x2", Tuple.Create(8,"Gold")},
            {"Gold x3", Tuple.Create(9,"Gold")},
            {"Gold x5", Tuple.Create(10,"Gold")},
            {"Stealthy", Tuple.Create(11,"Stealthy")},
            {"Stealthier", Tuple.Create(12,"Stealthy")},
            {"Stealhiest", Tuple.Create(13,"Stealthy")},
            {"Tiny Heal", Tuple.Create(14,"Heal")},
            {"Medium Heal", Tuple.Create(15,"Heal")},
            {"Full Heal", Tuple.Create(16,"Heal")},
            {"Tiny Heal (All)", Tuple.Create(17,"Heal (All)")},
            {"Medium Heal (All)", Tuple.Create(18,"Heal (All)")},
            {"Full Heal (All)", Tuple.Create(19,"Heal (All)")},
            {"Small Revive", Tuple.Create(20,"Revive")},
            {"Revive", Tuple.Create(21,"Revive")},
            {"Full Revive", Tuple.Create(22,"Revive")},
            {"Small Revive (All)", Tuple.Create(23,"Revive (All)")},
            {"Revive  (All)", Tuple.Create(24,"Revive (All)")},
            {"Full Revive (All)", Tuple.Create(25,"Revive (All)")},
            {"Antidote", Tuple.Create(26,"Antidote")},
            {"Antidote (All)", Tuple.Create(27,"Antidote")},
            {"Cure Burn", Tuple.Create(28,"Cure Burn")},
            {"Cure Burn (All)", Tuple.Create(29,"Cure Burn")},
            {"Dry", Tuple.Create(30,"Dry")},
            {"Dry (All)", Tuple.Create(31,"Dry")},
            {"Cure Sniffles", Tuple.Create(32,"Cure Sniffles")},
            {"Cure Sniffles (All)", Tuple.Create(33,"Cure Sniffles")},
            {"Mud Off", Tuple.Create(34,"Mud Off")},
            {"Mud Off (All)", Tuple.Create(35,"Mud Off")},
            {"Purify", Tuple.Create(36,"Purify")},
            {"Purify (All)", Tuple.Create(37,"Purify")},
            {"Cure Shock", Tuple.Create(38,"Cure Shock")},
            {"Cure Shock (All)", Tuple.Create(39,"Cure Shock")},
            {"Hot Blanket", Tuple.Create(40,"Hot Blanket")},
            {"Hot Blanket (All)", Tuple.Create(41,"Hot Blanket")},
            {"Mobilize", Tuple.Create(42,"Mobilize")},
            {"Mobilize (All)", Tuple.Create(43,"Mobilize")},
            {"Awaken", Tuple.Create(44,"Awaken")},
            {"Awaken (All)", Tuple.Create(45,"Awaken")},
            {"Eye Drops", Tuple.Create(46,"Eye Drops")},
            {"Eye Drops (All)", Tuple.Create(47,"Eye Drops")},
            {"Invincible", Tuple.Create(48,"Invincible")},
            {"Invincible (All)", Tuple.Create(49,"Invincible")},
            {"Excite (All)", Tuple.Create(50,"Excite")},
            {"Steroids", Tuple.Create(51,"Steroids")},
            {"Steroids (All)", Tuple.Create(52,"Steroids")},
            {"Reflect", Tuple.Create(53,"Reflect")},
            {"Reflect (All)", Tuple.Create(54,"Reflect")},
            {"Tiny Rage", Tuple.Create(55,"Rage")},
            {"Rage", Tuple.Create(56,"Rage")},
            {"Great Rage", Tuple.Create(57,"Rage")},
            {"Tiny Rage (All)", Tuple.Create(58,"Rage (All)")},
            {"Rage (All)", Tuple.Create(59,"Rage (All)")},
            {"Great Rage (All)", Tuple.Create(60,"Rage (All)")},
            {"Tiny Wall", Tuple.Create(61,"Wall")},
            {"Wall", Tuple.Create(62,"Wall")},
            {"Great Wall", Tuple.Create(63,"Wall")},
            {"Tiny Wall (All)", Tuple.Create(64,"Wall (All)")},
            {"Wall (All)", Tuple.Create(65,"Wall (All)")},
            {"Great Wall (All)", Tuple.Create(66,"Wall (All)")},
            {"Tiny Haste", Tuple.Create(67,"Haste")},
            {"Haste", Tuple.Create(68,"Haste")},
            {"Great Haste", Tuple.Create(69,"Haste")},
            {"Tiny Haste (All)", Tuple.Create(70,"Haste (All)")},
            {"Haste (All)", Tuple.Create(71,"Haste (All)")},
            {"Great Haste (All)", Tuple.Create(72,"Haste (All)")},
            {"Tiny Dodge", Tuple.Create(73,"Dodge")},
            {"Dodge", Tuple.Create(74,"Dodge")},
            {"Great Dodge", Tuple.Create(75,"Dodge")},
            {"Tiny Dodge (All)", Tuple.Create(76,"Dodge (All)")},
            {"Dodge (All)", Tuple.Create(77,"Dodge (All)")},
            {"Great Dodge (All)", Tuple.Create(78,"Dodge (All)")},
            {"Poison Signal", Tuple.Create(79,"Poison Signal")},
            {"Poison Wave", Tuple.Create(80,"Poison Signal")},
            {"Fatal", Tuple.Create(81,"Fatal")},
            {"Fatal (All)", Tuple.Create(82,"Fatal")},
            {"Lullably", Tuple.Create(83,"Lullaby")},
            {"Lullably (All)", Tuple.Create(84,"Lullaby")},
            {"Paralyze", Tuple.Create(85,"Paralyze")},
            {"Paralyze (All)", Tuple.Create(86,"Paralyze")},
            {"Blindfold ", Tuple.Create(87,"Blindfold")},
            {"Blindfold (All)", Tuple.Create(88,"Blindfold")},
            {"Breath Plug", Tuple.Create(89,"Breath Plug")},
            {"Breath Plug (All)", Tuple.Create(90,"Breath Plug")},
            {"Tiny Weaken", Tuple.Create(91,"Weaken")},
            {"Weaken", Tuple.Create(92,"Weaken")},
            {"Great Weaken", Tuple.Create(93,"Weaken")},
            {"Tiny Weaken (All)", Tuple.Create(94,"Weaken (All)")},
            {"Weaken (All)", Tuple.Create(95,"Weaken (All)")},
            {"Great Weaken (All)", Tuple.Create(96,"Weaken (All)")},
            {"Tiny Insult", Tuple.Create(97,"Insult")},
            {"Insult", Tuple.Create(98,"Insult")},
            {"Great Insult", Tuple.Create(99,"Insult")},
            {"Tiny Insult (All)", Tuple.Create(100,"Insult (All)")},
            {"Insult (All)", Tuple.Create(101,"Insult (All)")},
            {"Great Insult (All)", Tuple.Create(102,"Insult (All)")},
            {"Tiny Chain", Tuple.Create(103,"Chain")},
            {"Chain", Tuple.Create(104,"Chain")},
            {"Great Chain", Tuple.Create(105,"Chain")},
            {"Tiny Chain (All)", Tuple.Create(106,"Chain (All)")},
            {"Chain (All)", Tuple.Create(107,"Chain (All)")},
            {"Great Chain (All)", Tuple.Create(108,"Chain (All)")},
            {"Fireball", Tuple.Create(109,"Fireball")},
            {"Flame Thrower", Tuple.Create(110,"Fireball")},
            {"Rising Flames", Tuple.Create(111,"Fireball")},
            {"Fire Cracker", Tuple.Create(112,"Fire Cracker")},
            {"Explosion", Tuple.Create(113,"Fire Cracker")},
            {"Big Bang", Tuple.Create(114,"Fire Cracker")},
            {"Forest Fire", Tuple.Create(115,"Forest Fire")},
            {"Magma Wave", Tuple.Create(116,"Forest Fire")},
            {"Fire Wall", Tuple.Create(117,"Forest Fire")},
            {"Icicle", Tuple.Create(118,"Icicle")},
            {"Ice Blade", Tuple.Create(119,"Icicle")},
            {"Ice Missle", Tuple.Create(120,"Icicle")},
            {"On The Rocks", Tuple.Create(121,"On The Rocks")},
            {"Eternal Ice", Tuple.Create(122,"On The Rocks")},
            {"Diamond Dust", Tuple.Create(123,"On The Rocks")},
            {"Hailstorm", Tuple.Create(124,"Hailstorm")},
            {"Snowstorm", Tuple.Create(125,"Hailstorm")},
            {"Blizzard", Tuple.Create(126,"Hailstorm")},
            {"Whirlwind", Tuple.Create(127,"Whirlwind")},
            {"Sandstorm", Tuple.Create(128,"Whirlwind")},
            {"Cyclone", Tuple.Create(129,"Whirlwind")},
            {"Breeze", Tuple.Create(130,"Breeze")},
            {"Storm", Tuple.Create(131,"Breeze")},
            {"Hurricane", Tuple.Create(132,"Breeze")},
            {"Twister", Tuple.Create(133,"Twister")},
            {"Jet Current", Tuple.Create(134,"Twister")},
            {"Downburst", Tuple.Create(135,"Twister")},
            {"Failling Rock", Tuple.Create(136,"Falling Rock")},
            {"Landslide", Tuple.Create(137,"Falling Rock")},
            {"Avalanche", Tuple.Create(138,"Falling Rock")},
            {"Pebbles", Tuple.Create(139,"Pebbles")},
            {"Rock Crush", Tuple.Create(140,"Pebbles")},
            {"Comet Crash", Tuple.Create(141,"Pebbles")},
            {"Magnitude 3", Tuple.Create(142,"Magnitude 3")},
            {"Magnitude 6", Tuple.Create(143,"Magnitude 3")},
            {"Magnitude 12", Tuple.Create(144,"Magnitude 3")},
            {"Static", Tuple.Create(145,"Static")},
            {"Shock", Tuple.Create(146,"Static")},
            {"Spark", Tuple.Create(147,"Static")},
            {"Lightning", Tuple.Create(148,"Lightning")},
            {"Thunder", Tuple.Create(149,"Lightning")},
            {"Bolt from the Blue", Tuple.Create(150,"Lightning")},
            {"100 Volts", Tuple.Create(151,"100 Volts")},
            {"10000 Volts", Tuple.Create(152,"100 Volts")},
            {"1 Billion Volts", Tuple.Create(153,"100 Volts")},
            {"Water Gun", Tuple.Create(154,"Water Gun")},
            {"Water Cannon", Tuple.Create(155,"Water Gun")},
            {"Mud Stream", Tuple.Create(156,"Water Gun")},
            {"Bucket of Water", Tuple.Create(157,"Bucket of Water")},
            {"Waterfall", Tuple.Create(158,"Bucket of Water")},
            {"Jet Splash", Tuple.Create(159,"Bucket of Water")},
            {"High Wave", Tuple.Create(160,"High Wave")},
            {"Tidal Wave", Tuple.Create(161,"High Wave")},
            {"Island Destroyer", Tuple.Create(162,"High Wave")},
            {"Weak Flash", Tuple.Create(163,"Weak Flash")},
            {"Bright Flash", Tuple.Create(164,"Weak Flash")},
            {"Laser Beam", Tuple.Create(165,"Weak Flash")},
            {"Spotlight", Tuple.Create(166,"Spotlight")},
            {"Light Burst", Tuple.Create(167,"Spotlight")},
            {"Flare", Tuple.Create(168,"Spotlight")},
            {"Winter Sunlight", Tuple.Create(169,"Winter Sunlight")},
            {"Summer Sun", Tuple.Create(170,"Winter Sunlight")},
            {"Supernova", Tuple.Create(171,"Winter Sunlight")},
            {"Scare", Tuple.Create(172,"Scare")},
            {"Surprise", Tuple.Create(173,"Scare")},
            {"Dark Messenger", Tuple.Create(174,"Scare")},
            {"Dark Ball", Tuple.Create(175,"Dark Ball")},
            {"Black Whirl", Tuple.Create(176,"Dark Ball")},
            {"Black Hole", Tuple.Create(177,"Dark Ball")},
            {"Dark Mist", Tuple.Create(178,"Dark Mist")},
            {"Deep Shadow", Tuple.Create(179,"Dark Mist")},
            {"Abyss", Tuple.Create(180,"Dark Mist")},
            {"Ferocious Flames", Tuple.Create(181,"")},
            {"Iceberg", Tuple.Create(182,"")},
            {"Vengeful Wind", Tuple.Create(183,"")},
            {"Cave-In", Tuple.Create(184,"")},
            {"Lightning Ball", Tuple.Create(185,"")},
            {"Fierce Rapids", Tuple.Create(186,"")},
            {"Blinding Flash", Tuple.Create(187,"")},
            {"Servant of Darkness", Tuple.Create(188,"")},
            {"Scorched Ice", Tuple.Create(189,"")},
            {"Flame Ice", Tuple.Create(190,"")},
            {"Burning Wind", Tuple.Create(191,"")},
            {"Firestorm", Tuple.Create(192,"")},
            {"Eruption", Tuple.Create(193,"")},
            {"Meteor", Tuple.Create(194,"")},
            {"Lightning Scorch", Tuple.Create(195,"")},
            {"Thundering Fire", Tuple.Create(196,"")},
            {"Sea of Fire", Tuple.Create(197,"")},
            {"Hydro Fire", Tuple.Create(198,"")},
            {"Ice Storm", Tuple.Create(199,"")},
            {"Jet Blizzard", Tuple.Create(200,"")},
            {"Frozen Fossil", Tuple.Create(201,"")},
            {"Ice Meteor", Tuple.Create(202,"")},
            {"Shocking Snow", Tuple.Create(203,"")},
            {"Thunder Blizzard", Tuple.Create(204,"")},
            {"Hail", Tuple.Create(205,"")},
            {"Ice Squall", Tuple.Create(206,"")},
            {"Dust Storm", Tuple.Create(207,"")},
            {"Mud Hurricane ", Tuple.Create(208,"")},
            {"Lightning Storm", Tuple.Create(209,"")},
            {"Thunder Hurricane", Tuple.Create(210,"")},
            {"Horizontal Rain", Tuple.Create(211,"")},
            {"Hydro Storm", Tuple.Create(212,"Hydro Storm")},
            {"Shock Rock", Tuple.Create(213,"Hydro Storm")},
            {"Thundering Ground", Tuple.Create(214,"Hydro Storm")},
            {"Streaming Stones", Tuple.Create(215,"Hydro Storm")},
            {"Muddy Flood", Tuple.Create(216,"Muddy Flood")},
            {"Thunderstorm", Tuple.Create(217,"Muddy Flood")},
            {"Thunder Squall", Tuple.Create(218,"Muddy Flood")},
            {"Black Sun", Tuple.Create(219,"")},
            {"Dark Shine", Tuple.Create(220,"")},
            {"Catch", Tuple.Create(221,"Catch")},
            {"Catch x2", Tuple.Create(222,"Catch")},
            {"Catch x3", Tuple.Create(223,"Catch")},
        };

        byte[][] names = {new byte[15],new byte[15],new byte[15],new byte[15],new byte[15],new byte[15],new byte[15],new byte[15]};
        bool[] denpas = {false,false,false,false,false,false,false,false};
        byte[] antenna = { 0, 0, 0, 0, 0, 0, 0, 0 };
        byte[] headshape = { 0, 0, 0, 0, 0, 0, 0, 0 };
        byte[] faceshape = { 0, 0, 0, 0, 0, 0, 0, 0 };
        byte[] hair = { 0, 0, 0, 0, 0, 0, 0, 0 };
        byte[] eyebrows = { 0, 0, 0, 0, 0, 0, 0, 0 };
        byte[] eyes = { 0, 0, 0, 0, 0, 0, 0, 0 };
        byte[] nose = { 0, 0, 0, 0, 0, 0, 0, 0 };
        byte[] mouth = { 0, 0, 0, 0, 0, 0, 0, 0 };
        byte[] cheeks = { 0, 0, 0, 0, 0, 0, 0, 0 };
        byte[] glasses = { 0, 0, 0, 0, 0, 0, 0, 0 };
        byte[] body = { 0, 0, 0, 0, 0, 0, 0, 0 };
        byte[] color = { 0, 0, 0, 0, 0, 0, 0, 0 };
        byte[] skin = { 0, 0, 0, 0, 0, 0, 0, 0 };
        byte[] haircolor = { 0, 0, 0, 0, 0, 0, 0, 0 };
        byte[] antenna_appearances = { 0, 0, 0, 0, 0, 0, 0, 0 };
        ushort[] levels = { 0, 0, 0, 0, 0, 0, 0, 0 };
        ushort[] ap = { 0, 0, 0, 0, 0, 0, 0, 0 };
        ushort[] hp = { 0, 0, 0, 0, 0, 0, 0, 0 };

        int current_denpa = 0;
        int offset_distance = 0x9C;

        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create Graphics Object for PictureBox

            g = pictureBox1.CreateGraphics();

            // Backup Folder for previous saves

            System.IO.Directory.CreateDirectory("Backup");
        }

        private void CFButton_Click(object sender, EventArgs e)
        {
            // Create File Dialog 

            FileStream open_stream;

            var file_dialog = new OpenFileDialog();
            file_dialog.Title = "Choose Denpa Men 3 Save File";
            file_dialog.DefaultExt = "bin";
            file_dialog.Filter = "TDM3 Save File (*.bin)|*.bin| All files (*.*)|*.*";
            file_dialog.ShowDialog();

            // Attempt to open File, if user selects "Cancel", and the user opened a file previously, open that file.

            try
            {
                open_stream = File.Open(file_dialog.FileName, FileMode.Open);
                file_name = file_dialog.FileName;
                short_file_name = file_dialog.SafeFileName;
            }
            catch (System.ArgumentException)
            {

                if (file_name != null)
                {

                    open_stream = File.Open(file_name, FileMode.Open);
                }
                else
                {
                    MessageBox.Show("Error: File not found");
                    return;
                }

            }

            // Copy file to buffer

            sf_buffer = new byte[open_stream.Length];
            open_stream.Read(sf_buffer, 0, (int)open_stream.Length);
            open_stream.Close(); FileName.Text = file_name;

            // Attempt to create backup

            try
            {
                FileStream backup_stream = File.Open("Backup/" + (DateTime.Now.Day + "" + DateTime.Now.Hour + "" + DateTime.Now.Minute + "" + DateTime.Now.Second + "" + DateTime.Now.Millisecond) + ".bin", FileMode.Create);
                backup_stream.Write(sf_buffer, 0, sf_buffer.Length);
                backup_stream.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Unable to create backup");
            }
            
            // Set default values for the Forms and enable saving

            setDefaults();
            opencontrols();

        } 
   

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // Attempt to save the file

            try
            {
                save_stream = File.Open(file_name, FileMode.Create);
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("Error: File not found");
                return;
            }

            savetobuffer();
            save_stream.Write(sf_buffer, 0, sf_buffer.Length);
            save_stream.Close();
        }


        private void SaveAsButton_Click(object sender, EventArgs e)
        {
            // Allow user to save as new file

            var file_dialog = new SaveFileDialog();
            file_dialog.Title = "Save As";
            file_dialog.Filter = "TDM3 Save File (*.bin)|*.bin| All files (*.*)|*.*";
            file_dialog.DefaultExt = "bin";
            file_dialog.ShowDialog();

            // Attempt to save the file to a specified location

            try
            {
                save_stream = File.Open(file_dialog.FileName, FileMode.Create);
                file_name = file_dialog.FileName;
                short_file_name = file_dialog.FileName;
                
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("Error: File not found");
                return;

            }
            
            // Reset values

            savetobuffer();
            save_stream.Write(sf_buffer, 0, sf_buffer.Length);
            save_stream.Close();
            setDefaults();
        }
        
        void setDefaults()
        {
            // Set text for FileName label

            FileName.Text = short_file_name;

            for (int i = 0; i < 8; i++)
            {
                int offset = (i * offset_distance);

                // If there is no denpa in this location, skip

                if (sf_buffer[(int)Offsets.new_denpa + offset] == 0)
                {
                    continue;
                }

                // Set all default values

                denpas[i] = true;
                names[i] = new byte[15];
                buildname((int)Offsets.name + offset, 0, sf_buffer, names[i], 2, 1,12);
                antenna[i] = sf_buffer[(int)Offsets.antenna + offset];
                headshape[i] = sf_buffer[(int)Offsets.headshape + offset];
                faceshape[i] = sf_buffer[(int)Offsets.faceshape + offset];
                hair[i] = sf_buffer[(int)Offsets.hair + offset];
                eyebrows[i] = sf_buffer[(int)Offsets.eyebrows + offset];
                eyes[i] = sf_buffer[(int)Offsets.eyes + offset];
                nose[i] = sf_buffer[(int)Offsets.nose + offset];
                mouth[i] = sf_buffer[(int)Offsets.mouth + offset];
                cheeks[i] = sf_buffer[(int)Offsets.cheeks + offset];
                glasses[i] = sf_buffer[(int)Offsets.glasses + offset];
                body[i] = sf_buffer[(int)Offsets.body + offset];
                color[i] = sf_buffer[(int)Offsets.color + offset];
                skin[i] = sf_buffer[(int)Offsets.skin + offset];
                haircolor[i] = sf_buffer[(int)Offsets.haircolor + offset];
                antenna_appearances[i] = sf_buffer[(int)Offsets.antenna_appearances + offset];
                levels[i] = sf_buffer[(int)Offsets.level + offset];
                ap[i] = sf_buffer[(int)Offsets.ap + offset];
                hp[i] = sf_buffer[(int)Offsets.hp + offset];
            }

            current_denpa = 0; // Hero

            updateforms();

        }

        void buildname(int offset,int offset2, byte[] source_array, byte[]des_array,int skip1, int skip2,int len)
        {
            // Denpa names are stored with a space between each character.

            for (int i = 0; i < len; i++) {
                try {
                    des_array[offset2 + (i * skip2)] = source_array[offset + (i * skip1)];

                }
                catch (IndexOutOfRangeException) {
                    MessageBox.Show("Error: Name is too long");
                }
            }

        }

        void writeushort(ushort value, byte[] des, int offset)
        {
            // Writing a short require 2 bytes.

            byte upper = (byte)(value >> 8);
            byte lower = (byte)(value & 0xff);

            des[offset] = lower;
            des[offset + 1] = upper;
        }

        void writearray(byte[] values, byte[] des, int offset)
        {
            //Write an array of bytes to a specified offset

            for (int i = 0; i < values.Length; i++)
            {
                des[i + offset] = values[i];
            }
        }

        void savetobuffer()
        {
            for (int i = 0; i < 8;i++) {

                // If the denpa does not exist, non of it's values should be saved.

                if (!denpas[i])
                {
                    continue;
                }

                int offset = (i * offset_distance);

                buildname(0, (int)Offsets.name + offset,names[i],sf_buffer,1,2,names[i].Length);
                sf_buffer[(int)Offsets.antenna + offset] = antenna[i];
                sf_buffer[(int)Offsets.headshape + offset] = headshape[i];
                sf_buffer[(int)Offsets.faceshape + offset] = faceshape[i];
                sf_buffer[(int)Offsets.hair + offset] = hair[i];
                sf_buffer[(int)Offsets.eyebrows + offset] = eyebrows[i];
                sf_buffer[(int)Offsets.eyes + offset] = eyes[i];
                sf_buffer[(int)Offsets.nose + offset] = nose[i];
                sf_buffer[(int)Offsets.mouth + offset] = mouth[i];
                sf_buffer[(int)Offsets.cheeks + offset] = cheeks[i];
                sf_buffer[(int)Offsets.glasses + offset] = glasses[i];
                sf_buffer[(int)Offsets.body + offset] = body[i];
                sf_buffer[(int)Offsets.color + offset] = color[i];
                sf_buffer[(int)Offsets.skin + offset] = skin[i];
                sf_buffer[(int)Offsets.haircolor + offset] = haircolor[i];
                sf_buffer[(int)Offsets.antenna_appearances + offset] = antenna_appearances[i];
                writeushort(levels[i], sf_buffer, (int)Offsets.level + offset);
                writeushort(ap[i], sf_buffer, (int)Offsets.ap + offset);
                writeushort(hp[i], sf_buffer, (int)Offsets.ap + offset);

            }
        }

        

        void updateforms()
        {         

            if (current_denpa > 7)
            {
                current_denpa = 0;
            }
            else if (current_denpa < 0)
            {
                current_denpa = 7;
            }

            if (current_denpa == 0)
            {
                CurrentDenpaLabel.Text = "Hero";
            }
            else
            {
                if (denpas[current_denpa])
                {
                    CurrentDenpaLabel.Text = "Party Member " + current_denpa.ToString();
                }
                else
                {
                    CurrentDenpaLabel.Text = "Empty Slot (" + current_denpa.ToString() + ")";
                }
            }


            // Don't allow input until a new denpa has been created

            if (denpas[current_denpa])
            {
                openforms();
            }
            else
            {
                button3.Enabled = true;
                closeforms();
                return;
            }

            loading = true;
            DenpaName.Text = System.Text.Encoding.ASCII.GetString(names[current_denpa]);
            HeadShapeComboBox.SelectedIndex = headshape[current_denpa];
            FaceShapeComboBox.SelectedIndex = faceshape[current_denpa];
            HairComboBox.SelectedIndex = hair[current_denpa];
            EyebrowsComboBox.SelectedIndex = eyebrows[current_denpa];
            EyesComboBox.SelectedIndex = eyes[current_denpa];
            NoseComboBox.SelectedIndex = nose[current_denpa];
            MouthComboBox.SelectedIndex = mouth[current_denpa];
            CheeksComboBox.SelectedIndex = cheeks[current_denpa];
            BodyComboBox.SelectedIndex = body[current_denpa];
            GlassesComboBox.SelectedIndex = glasses[current_denpa];
            SkinComboBox.SelectedIndex = skin[current_denpa];
            HairColorComboBox.SelectedIndex = haircolor[current_denpa];
            ColorComboBox.SelectedIndex = color[current_denpa];
            AntennaAppearanceComboBox.SelectedIndex = antenna_appearances[current_denpa];
            LevelNumericUpDown.Value = levels[current_denpa];
            APNumberUpDown.Value = ap[current_denpa];
            HPNumericUpDown.Value = hp[current_denpa];

            loading = false;

            // Draw to PictureBox

            updatecanvas();
        }

        void closeforms()
        {
            loading = true;

            DenpaName.Text = "";
            HeadShapeComboBox.SelectedIndex = 0;
            FaceShapeComboBox.SelectedIndex = 0;
            HairComboBox.SelectedIndex = 0;
            EyebrowsComboBox.SelectedIndex = 0;
            EyesComboBox.SelectedIndex = 0;
            NoseComboBox.SelectedIndex = 0;
            MouthComboBox.SelectedIndex = 0;
            CheeksComboBox.SelectedIndex = 0;
            BodyComboBox.SelectedIndex = 0;
            GlassesComboBox.SelectedIndex = 0;
            SkinComboBox.SelectedIndex = 0;
            HairColorComboBox.SelectedIndex = 0;
            ColorComboBox.SelectedIndex = 0;
            AntennaAppearanceComboBox.SelectedIndex = 0;
            LevelNumericUpDown.Value = 0;
            APNumberUpDown.Value = 0;
            HPNumericUpDown.Value = 0;

            DenpaName.Enabled = false;
            HeadShapeComboBox.Enabled = false;
            FaceShapeComboBox.Enabled = false;
            HairComboBox.Enabled = false;
            EyebrowsComboBox.Enabled = false;
            EyesComboBox.Enabled = false;
            NoseComboBox.Enabled = false;
            MouthComboBox.Enabled = false;
            CheeksComboBox.Enabled = false;
            BodyComboBox.Enabled = false;
            GlassesComboBox.Enabled = false;
            SkinComboBox.Enabled = false;
            HairColorComboBox.Enabled = false;
            ColorComboBox.Enabled = false;
            AntennaAppearanceComboBox.Enabled = false;
            LevelNumericUpDown.Enabled = false;
            APNumberUpDown.Enabled = false;
            HPNumericUpDown.Enabled = false;

            loading = false;

        }

        void opencontrols()
        {
            NextDenpaButton.Enabled = true;
            PreviousDenpaButton.Enabled = true;
            SaveASButton.Enabled = true;
            SaveButton.Enabled = true;
            button1.Enabled = true;
        }

        void openforms()
        {
            DenpaName.Enabled = true;
            HeadShapeComboBox.Enabled = true;
            FaceShapeComboBox.Enabled = true;
            HairComboBox.Enabled = true;
            EyebrowsComboBox.Enabled = true;
            EyesComboBox.Enabled = true;
            NoseComboBox.Enabled = true;
            MouthComboBox.Enabled = true;
            CheeksComboBox.Enabled = true;
            BodyComboBox.Enabled = true;
            GlassesComboBox.Enabled = true;
            SkinComboBox.Enabled = true;
            HairColorComboBox.Enabled = true;
            ColorComboBox.Enabled = true;
            AntennaAppearanceComboBox.Enabled = true;
            LevelNumericUpDown.Enabled = true;
            APNumberUpDown.Enabled = true;
            HPNumericUpDown.Enabled = true;

        }

        void updatecanvas()
        {
            // If forms are being updated don't draw. Will cause lag

            if (loading)
            {
                return;
            }

            cloneRect.X = 5 + (32 * (eyes[current_denpa] / 16));
            cloneRect.Y = 32 * (eyes[current_denpa] % 16);
            cloneRect.Width = 32;
            cloneRect.Height = 32;

            dat = decals.Clone(cloneRect, decals.PixelFormat);

            g.DrawImage(dat, 0, 0, 75, 75);

            cloneRect.X = (320) + (32 * (nose[current_denpa] / 16));
            cloneRect.Y = 32 * (nose[current_denpa] % 16); 
            dat = decals.Clone(cloneRect, decals.PixelFormat);
            g.DrawImage(dat, 150, 0, 75, 75);

            cloneRect.X = (135) + (65 * (mouth[current_denpa] / 16));
            cloneRect.Y = 32 * (mouth[current_denpa] % 16);
            cloneRect.Width = 45;
            cloneRect.Height = 32;

            dat = decals.Clone(cloneRect, decals.PixelFormat);
            g.DrawImage(dat, 75, 0, 75, 75);

            cloneRect.X = (384 + (32* (eyebrows[current_denpa] / 16)));
            cloneRect.Y = 32 * (eyebrows[current_denpa] % 16);
            cloneRect.Width = 32;
            cloneRect.Height = 32;

            dat = decals.Clone(cloneRect, decals.PixelFormat);
            g.DrawImage(dat, 0, 75, 75, 75);

            cloneRect.X = (416 + (32 * (cheeks[current_denpa] / 16)));
            cloneRect.Y = 32 * ((4 + cheeks[current_denpa]) % 16);
            cloneRect.Width = 32;
            cloneRect.Height = 32;

            dat = decals.Clone(cloneRect, decals.PixelFormat);
            g.DrawImage(dat, 75, 75, 75, 75);

            cloneRect.X = (448 + (32 * (glasses[current_denpa] / 16)));
            cloneRect.Y = 32 * ((glasses[current_denpa] % 16));
            cloneRect.Width = 32;
            cloneRect.Height = 32;

            dat = decals.Clone(cloneRect, decals.PixelFormat);
            g.DrawImage(dat, 150, 75, 75, 75);

            cloneRect.X = (520 + (80 * (hair[current_denpa] / 8)));
            cloneRect.Y = 57 * ((hair[current_denpa] % 8));
            cloneRect.Width = 65;
            cloneRect.Height = 57;

            dat = decals.Clone(cloneRect, decals.PixelFormat);
            g.DrawImage(dat, 0, 150, 75, 75);

            dat.Dispose();
            g.Dispose();
            g = pictureBox1.CreateGraphics();


        }

        private void HeadShapeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            headshape[current_denpa] = (byte)HeadShapeComboBox.SelectedIndex;
            updatecanvas();
        }

        private void FaceShapeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            faceshape[current_denpa] = (byte)FaceShapeComboBox.SelectedIndex;
            updatecanvas();
        }

        private void HairComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            hair[current_denpa] = (byte)HairComboBox.SelectedIndex;
            updatecanvas();
        }

        private void EyebrowsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            eyebrows[current_denpa] = (byte)EyebrowsComboBox.SelectedIndex;
            updatecanvas();
        }

        private void EyesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            eyes[current_denpa] = (byte)EyesComboBox.SelectedIndex;
            updatecanvas();

        }

        private void NoseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {           
            nose[current_denpa] = (byte)NoseComboBox.SelectedIndex;
            updatecanvas();

        }

        private void MouthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            mouth[current_denpa] = (byte)MouthComboBox.SelectedIndex;
            updatecanvas();
        }

        private void CheeksComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cheeks[current_denpa] = (byte)CheeksComboBox.SelectedIndex;
            updatecanvas();
        }

        private void AntennaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            antenna[current_denpa] = (byte)AntennaComboBox.SelectedIndex;
            updatecanvas();
        }

        private void BodyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            body[current_denpa] = (byte)BodyComboBox.SelectedIndex;
            updatecanvas();
        }

        private void GlassesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            glasses[current_denpa] = (byte)GlassesComboBox.SelectedIndex;
            updatecanvas();
        }

        private void ColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            color[current_denpa] = (byte)ColorComboBox.SelectedIndex;
            updatecanvas();
        }

        private void SkinComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            skin[current_denpa] = (byte)SkinComboBox.SelectedIndex;
            updatecanvas();
        }

        private void HairColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            haircolor[current_denpa] = (byte)HairColorComboBox.SelectedIndex;
            updatecanvas();
        }

        private void NextDenpaButton_Click(object sender, EventArgs e)
        {
            current_denpa++;
            updateforms();
        }

        private void PreviousDenpaButton_Click(object sender, EventArgs e)
        {
            current_denpa--;
            updateforms();
        }

        private void DenpaName_TextChanged(object sender, EventArgs e)
        {
            names[current_denpa] = Encoding.ASCII.GetBytes(DenpaName.Text);
        }

        private void AntennaAppearanceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            antenna_appearances[current_denpa] = (byte)AntennaAppearanceComboBox.SelectedIndex;
            antenna[current_denpa] = (byte)antenna_values[antenna_appearance_values[AntennaAppearanceComboBox.Text].Item2];
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            levels[current_denpa] = (ushort)LevelNumericUpDown.Value;
        }

        private void HPNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ap[current_denpa] = (ushort)HPNumericUpDown.Value;
        }

        private void APNumberUpDown_ValueChanged(object sender, EventArgs e)
        {
            hp[current_denpa] = (ushort)APNumberUpDown.Value;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            // Create a new denpa with new_denpa values

            writearray(new_denpa, sf_buffer, (int)Offsets.new_denpa + (current_denpa * offset_distance));
            names[current_denpa] = new byte[15];
            buildname((int)Offsets.name + (current_denpa * offset_distance), 0, sf_buffer, names[current_denpa], 2, 1, 12);
            antenna[current_denpa] = sf_buffer[(int)Offsets.antenna + (current_denpa * offset_distance)];
            headshape[current_denpa] = sf_buffer[(int)Offsets.headshape + (current_denpa * offset_distance)];
            faceshape[current_denpa] = sf_buffer[(int)Offsets.faceshape + (current_denpa * offset_distance)];
            hair[current_denpa] = sf_buffer[(int)Offsets.hair + (current_denpa * offset_distance)];
            eyebrows[current_denpa] = sf_buffer[(int)Offsets.eyebrows + (current_denpa * offset_distance)];
            eyes[current_denpa] = sf_buffer[(int)Offsets.eyes + (current_denpa * offset_distance)];
            nose[current_denpa] = sf_buffer[(int)Offsets.nose + (current_denpa * offset_distance)];
            mouth[current_denpa] = sf_buffer[(int)Offsets.mouth + (current_denpa * offset_distance)];
            cheeks[current_denpa] = sf_buffer[(int)Offsets.cheeks + (current_denpa * offset_distance)];
            glasses[current_denpa] = sf_buffer[(int)Offsets.glasses + (current_denpa * offset_distance)];
            body[current_denpa] = sf_buffer[(int)Offsets.body + (current_denpa * offset_distance)];
            color[current_denpa] = sf_buffer[(int)Offsets.color + (current_denpa * offset_distance)];
            skin[current_denpa] = sf_buffer[(int)Offsets.skin + (current_denpa * offset_distance)];
            haircolor[current_denpa] = sf_buffer[(int)Offsets.haircolor + (current_denpa * offset_distance)];
            antenna_appearances[current_denpa] = sf_buffer[(int)Offsets.antenna_appearances + (current_denpa * offset_distance)];
            levels[current_denpa] = sf_buffer[(int)Offsets.level + (current_denpa * offset_distance)];
            ap[current_denpa] = sf_buffer[(int)Offsets.ap + (current_denpa * offset_distance)];
            hp[current_denpa] = sf_buffer[(int)Offsets.hp + (current_denpa * offset_distance)];
            denpas[current_denpa] = true;

            openforms();
            updateforms();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/RKABRENajK");
        }

        private void MaxGoldAndJewels(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                sf_buffer[(int)Offsets.goldandjewels + i] = 0xFF;
            }

            MessageBox.Show("Maximum Gold and Jewels were added to the buffer. \nSelect Save to save them to the file.");
        }
    }
}



