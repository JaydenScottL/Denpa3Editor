
namespace Denpa3Editor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CFButton = new System.Windows.Forms.Button();
            this.SaveASButton = new System.Windows.Forms.Button();
            this.HeadShapeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.FileName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AntennaComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FaceShapeComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.HairComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EyebrowsComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EyesComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.NoseComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MouthComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CheeksComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.GlassesComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.BodyComboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ColorComboBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SkinComboBox = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.HairColorComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NextDenpaButton = new System.Windows.Forms.Button();
            this.PreviousDenpaButton = new System.Windows.Forms.Button();
            this.DenpaName = new System.Windows.Forms.TextBox();
            this.AntennaAppearanceComboBox = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.LevelNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.CurrentDenpaLabel = new System.Windows.Forms.Label();
            this.NewDenpaButton = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.HPNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.APNumberUpDown = new System.Windows.Forms.NumericUpDown();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HPNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.APNumberUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // CFButton
            // 
            this.CFButton.Location = new System.Drawing.Point(643, 247);
            this.CFButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CFButton.Name = "CFButton";
            this.CFButton.Size = new System.Drawing.Size(145, 36);
            this.CFButton.TabIndex = 0;
            this.CFButton.Text = "Choose File";
            this.CFButton.UseVisualStyleBackColor = true;
            this.CFButton.Click += new System.EventHandler(this.CFButton_Click);
            // 
            // SaveASButton
            // 
            this.SaveASButton.Enabled = false;
            this.SaveASButton.Location = new System.Drawing.Point(643, 337);
            this.SaveASButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveASButton.Name = "SaveASButton";
            this.SaveASButton.Size = new System.Drawing.Size(145, 36);
            this.SaveASButton.TabIndex = 1;
            this.SaveASButton.Text = "Save As...";
            this.SaveASButton.UseVisualStyleBackColor = true;
            this.SaveASButton.Click += new System.EventHandler(this.SaveAsButton_Click);
            // 
            // HeadShapeComboBox
            // 
            this.HeadShapeComboBox.AllowDrop = true;
            this.HeadShapeComboBox.Enabled = false;
            this.HeadShapeComboBox.FormattingEnabled = true;
            this.HeadShapeComboBox.Items.AddRange(new object[] {
            "Circle ",
            "Oval ",
            "2nd Oval  (Vertical)",
            "Triangle ",
            "Onigiri ",
            "Square ",
            "Square  2",
            "Teardrop ",
            "Diamond ring ",
            "Bear ",
            "Speech Bubble ",
            "Footprint ",
            "Headphones ",
            "Squid ",
            "1700 Curls ",
            "Star ",
            "Mouse ",
            "Heart Shape",
            "Cat ",
            "Devil Horns ",
            "Crescent Moon ",
            "Raindrop ",
            "Headphones 2 ",
            "Thorn ",
            "Egg ",
            "Tower ",
            "Doggo ",
            "Fire ",
            "Fangs ",
            "Ninja Star ",
            "Hexagon ",
            "Flower/Sun ",
            "Bunny ",
            "Poo ",
            "Castle ",
            "Block ",
            "Bomb ",
            "Saturn ",
            "Tower 2 ",
            "Fish "});
            this.HeadShapeComboBox.Location = new System.Drawing.Point(440, 55);
            this.HeadShapeComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeadShapeComboBox.Name = "HeadShapeComboBox";
            this.HeadShapeComboBox.Size = new System.Drawing.Size(121, 24);
            this.HeadShapeComboBox.TabIndex = 2;
            this.HeadShapeComboBox.SelectedIndexChanged += new System.EventHandler(this.HeadShapeComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(353, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Antenna";
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(643, 289);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(145, 36);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // FileName
            // 
            this.FileName.AutoSize = true;
            this.FileName.BackColor = System.Drawing.Color.Transparent;
            this.FileName.Location = new System.Drawing.Point(664, 226);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(101, 17);
            this.FileName.TabIndex = 5;
            this.FileName.Text = "None Selected";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(353, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Head Shape";
            // 
            // AntennaComboBox
            // 
            this.AntennaComboBox.FormattingEnabled = true;
            this.AntennaComboBox.Items.AddRange(new object[] {
            "None",
            "Treasure",
            "Rare Treasure",
            "Gold",
            "Stealthy",
            "Heal",
            "Heal (All)",
            "Revive",
            "Revive(All)",
            "Antidote",
            "Cure Burn",
            "Dry",
            "Cure Sniffles",
            "Mud Off",
            "Purify",
            "Cure Shock",
            "Hot Blanket",
            "Mobilize",
            "Awaken",
            "Eye drops",
            "Invincible",
            "Excite",
            "Steroids",
            "Reflect",
            "Rage",
            "Rage (All)",
            "Wall",
            "Wall(All)",
            "Haste",
            "Haste(All)",
            "Dodge",
            "Dodge(All)",
            "Poison Signal",
            "Fatal",
            "Lullaby",
            "Paralyze",
            "Blindfold",
            "Breath plug",
            "Weaken",
            "Weaken (All)",
            "Insult",
            "Insult(All)",
            "Chain",
            "Chain(All)",
            "Fireball",
            "Fire Cracker",
            "Forest Fire",
            "Icicle",
            "On the Rocks",
            "Hailstorm",
            "Whirlwind",
            "Breeze",
            "Twister",
            "Falling Rock",
            "Pebbles",
            "Magnitude 3",
            "Static",
            "Lightning",
            "100 Volts",
            "Water Gun",
            "Bucket of Water",
            "High Wave",
            "Weak Flash",
            "Spotlight",
            "Winter Sunlight",
            "Scare",
            "Dark Ball",
            "Dark Mist",
            "Catch"});
            this.AntennaComboBox.Location = new System.Drawing.Point(440, 25);
            this.AntennaComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AntennaComboBox.Name = "AntennaComboBox";
            this.AntennaComboBox.Size = new System.Drawing.Size(121, 24);
            this.AntennaComboBox.TabIndex = 6;
            this.AntennaComboBox.Visible = false;
            this.AntennaComboBox.SelectedIndexChanged += new System.EventHandler(this.AntennaComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(353, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Face Shape";
            // 
            // FaceShapeComboBox
            // 
            this.FaceShapeComboBox.AllowDrop = true;
            this.FaceShapeComboBox.Enabled = false;
            this.FaceShapeComboBox.FormattingEnabled = true;
            this.FaceShapeComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.FaceShapeComboBox.Location = new System.Drawing.Point(440, 85);
            this.FaceShapeComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FaceShapeComboBox.Name = "FaceShapeComboBox";
            this.FaceShapeComboBox.Size = new System.Drawing.Size(121, 24);
            this.FaceShapeComboBox.TabIndex = 8;
            this.FaceShapeComboBox.SelectedIndexChanged += new System.EventHandler(this.FaceShapeComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(353, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Hair";
            // 
            // HairComboBox
            // 
            this.HairComboBox.AllowDrop = true;
            this.HairComboBox.Enabled = false;
            this.HairComboBox.FormattingEnabled = true;
            this.HairComboBox.Items.AddRange(new object[] {
            "None",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36"});
            this.HairComboBox.Location = new System.Drawing.Point(440, 114);
            this.HairComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HairComboBox.Name = "HairComboBox";
            this.HairComboBox.Size = new System.Drawing.Size(121, 24);
            this.HairComboBox.TabIndex = 10;
            this.HairComboBox.SelectedIndexChanged += new System.EventHandler(this.HairComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(353, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Eyebrows";
            // 
            // EyebrowsComboBox
            // 
            this.EyebrowsComboBox.AllowDrop = true;
            this.EyebrowsComboBox.Enabled = false;
            this.EyebrowsComboBox.FormattingEnabled = true;
            this.EyebrowsComboBox.Items.AddRange(new object[] {
            "None",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19"});
            this.EyebrowsComboBox.Location = new System.Drawing.Point(440, 145);
            this.EyebrowsComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EyebrowsComboBox.Name = "EyebrowsComboBox";
            this.EyebrowsComboBox.Size = new System.Drawing.Size(121, 24);
            this.EyebrowsComboBox.TabIndex = 12;
            this.EyebrowsComboBox.SelectedIndexChanged += new System.EventHandler(this.EyebrowsComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(353, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Eyes";
            // 
            // EyesComboBox
            // 
            this.EyesComboBox.AllowDrop = true;
            this.EyesComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48"});
            this.EyesComboBox.Enabled = false;
            this.EyesComboBox.FormattingEnabled = true;
            this.EyesComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48"});
            this.EyesComboBox.Location = new System.Drawing.Point(440, 175);
            this.EyesComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EyesComboBox.Name = "EyesComboBox";
            this.EyesComboBox.Size = new System.Drawing.Size(121, 24);
            this.EyesComboBox.TabIndex = 14;
            this.EyesComboBox.SelectedIndexChanged += new System.EventHandler(this.EyesComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(353, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Nose";
            // 
            // NoseComboBox
            // 
            this.NoseComboBox.AllowDrop = true;
            this.NoseComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32"});
            this.NoseComboBox.Enabled = false;
            this.NoseComboBox.FormattingEnabled = true;
            this.NoseComboBox.Items.AddRange(new object[] {
            "None",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.NoseComboBox.Location = new System.Drawing.Point(440, 206);
            this.NoseComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NoseComboBox.Name = "NoseComboBox";
            this.NoseComboBox.Size = new System.Drawing.Size(121, 24);
            this.NoseComboBox.TabIndex = 18;
            this.NoseComboBox.SelectedIndexChanged += new System.EventHandler(this.NoseComboBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(353, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Mouth";
            // 
            // MouthComboBox
            // 
            this.MouthComboBox.AllowDrop = true;
            this.MouthComboBox.Enabled = false;
            this.MouthComboBox.FormattingEnabled = true;
            this.MouthComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40"});
            this.MouthComboBox.Location = new System.Drawing.Point(440, 236);
            this.MouthComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MouthComboBox.Name = "MouthComboBox";
            this.MouthComboBox.Size = new System.Drawing.Size(121, 24);
            this.MouthComboBox.TabIndex = 20;
            this.MouthComboBox.SelectedIndexChanged += new System.EventHandler(this.MouthComboBox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(353, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Cheeks";
            // 
            // CheeksComboBox
            // 
            this.CheeksComboBox.AllowDrop = true;
            this.CheeksComboBox.Enabled = false;
            this.CheeksComboBox.FormattingEnabled = true;
            this.CheeksComboBox.Items.AddRange(new object[] {
            "None",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.CheeksComboBox.Location = new System.Drawing.Point(440, 266);
            this.CheeksComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheeksComboBox.Name = "CheeksComboBox";
            this.CheeksComboBox.Size = new System.Drawing.Size(121, 24);
            this.CheeksComboBox.TabIndex = 22;
            this.CheeksComboBox.SelectedIndexChanged += new System.EventHandler(this.CheeksComboBox_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(353, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "Glasses";
            // 
            // GlassesComboBox
            // 
            this.GlassesComboBox.AllowDrop = true;
            this.GlassesComboBox.Enabled = false;
            this.GlassesComboBox.FormattingEnabled = true;
            this.GlassesComboBox.Items.AddRange(new object[] {
            "No glasses",
            "Green glasses",
            "Pink glasses",
            "Sunglasses",
            "Gold Glasses",
            "Orange Glasses",
            "Hero Mask 1",
            "Brown glasses",
            "Blue glasses",
            "Hero Mask 2 (Masquerade)",
            "Black Glasses",
            "Hero Mask 3",
            "Goggles",
            "Bug eyes",
            "Alien eyes",
            "Heart Glasses",
            "Star glasses",
            "Red glasses",
            "Visor?",
            "Goggles",
            "Laser Visor",
            "Small glasses",
            "Insomnia glasses",
            "Big Glasses"});
            this.GlassesComboBox.Location = new System.Drawing.Point(440, 295);
            this.GlassesComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GlassesComboBox.Name = "GlassesComboBox";
            this.GlassesComboBox.Size = new System.Drawing.Size(121, 24);
            this.GlassesComboBox.TabIndex = 24;
            this.GlassesComboBox.SelectedIndexChanged += new System.EventHandler(this.GlassesComboBox_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(353, 326);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 17);
            this.label11.TabIndex = 27;
            this.label11.Text = "Body";
            // 
            // BodyComboBox
            // 
            this.BodyComboBox.AllowDrop = true;
            this.BodyComboBox.Enabled = false;
            this.BodyComboBox.FormattingEnabled = true;
            this.BodyComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.BodyComboBox.Location = new System.Drawing.Point(440, 326);
            this.BodyComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BodyComboBox.Name = "BodyComboBox";
            this.BodyComboBox.Size = new System.Drawing.Size(121, 24);
            this.BodyComboBox.TabIndex = 26;
            this.BodyComboBox.SelectedIndexChanged += new System.EventHandler(this.BodyComboBox_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(353, 356);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 17);
            this.label12.TabIndex = 29;
            this.label12.Text = "Color";
            // 
            // ColorComboBox
            // 
            this.ColorComboBox.AllowDrop = true;
            this.ColorComboBox.Enabled = false;
            this.ColorComboBox.FormattingEnabled = true;
            this.ColorComboBox.Items.AddRange(new object[] {
            "Black",
            "Red",
            "Light Blue",
            "Green",
            "Orange",
            "Yellow",
            "Blue",
            "White",
            "Red/Light Blue",
            "Red/Green",
            "Red/Orange",
            "Red/Yellow",
            "Red/Blue",
            "Red/White",
            "Light Blue/Green",
            "Light Blue/Orange",
            "Light Blue/Yellow",
            "Light Blue/Blue",
            "Light Blue/White",
            "Orange/Green",
            "Yellow/Green",
            "Blue/Green",
            "White/Green",
            "Orange/Yellow",
            "Orange/Blue",
            "Orange/White",
            "Yellow/Blue",
            "Yellow/White",
            "White/Blue",
            "Purple",
            "Gray",
            "Gold",
            "Pink"});
            this.ColorComboBox.Location = new System.Drawing.Point(440, 356);
            this.ColorComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ColorComboBox.Name = "ColorComboBox";
            this.ColorComboBox.Size = new System.Drawing.Size(121, 24);
            this.ColorComboBox.TabIndex = 28;
            this.ColorComboBox.SelectedIndexChanged += new System.EventHandler(this.ColorComboBox_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(580, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 17);
            this.label13.TabIndex = 31;
            this.label13.Text = "Skin";
            // 
            // SkinComboBox
            // 
            this.SkinComboBox.AllowDrop = true;
            this.SkinComboBox.Enabled = false;
            this.SkinComboBox.FormattingEnabled = true;
            this.SkinComboBox.Items.AddRange(new object[] {
            "Lightest",
            "Light",
            "Pale",
            "Half-Pale",
            "Dark",
            "Darkest"});
            this.SkinComboBox.Location = new System.Drawing.Point(667, 25);
            this.SkinComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SkinComboBox.Name = "SkinComboBox";
            this.SkinComboBox.Size = new System.Drawing.Size(121, 24);
            this.SkinComboBox.TabIndex = 30;
            this.SkinComboBox.SelectedIndexChanged += new System.EventHandler(this.SkinComboBox_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(580, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 17);
            this.label14.TabIndex = 33;
            this.label14.Text = "Hair Color";
            // 
            // HairColorComboBox
            // 
            this.HairColorComboBox.AllowDrop = true;
            this.HairColorComboBox.Enabled = false;
            this.HairColorComboBox.FormattingEnabled = true;
            this.HairColorComboBox.Items.AddRange(new object[] {
            "Black",
            "White",
            "Brown",
            "Light-Brown",
            "Red-Brown",
            "Yellow",
            "Blue",
            "Green",
            "Purple",
            "Light-Brown",
            "Orange",
            "Red",
            "Silver",
            "Gray",
            "Other"});
            this.HairColorComboBox.Location = new System.Drawing.Point(667, 55);
            this.HairColorComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HairColorComboBox.Name = "HairColorComboBox";
            this.HairColorComboBox.Size = new System.Drawing.Size(121, 24);
            this.HairColorComboBox.TabIndex = 32;
            this.HairColorComboBox.SelectedIndexChanged += new System.EventHandler(this.HairColorComboBox_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 114);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 257);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // NextDenpaButton
            // 
            this.NextDenpaButton.Enabled = false;
            this.NextDenpaButton.Location = new System.Drawing.Point(234, 22);
            this.NextDenpaButton.Margin = new System.Windows.Forms.Padding(4);
            this.NextDenpaButton.Name = "NextDenpaButton";
            this.NextDenpaButton.Size = new System.Drawing.Size(83, 28);
            this.NextDenpaButton.TabIndex = 35;
            this.NextDenpaButton.Text = "Next";
            this.NextDenpaButton.UseVisualStyleBackColor = true;
            this.NextDenpaButton.Click += new System.EventHandler(this.NextDenpaButton_Click);
            // 
            // PreviousDenpaButton
            // 
            this.PreviousDenpaButton.Enabled = false;
            this.PreviousDenpaButton.Location = new System.Drawing.Point(16, 22);
            this.PreviousDenpaButton.Margin = new System.Windows.Forms.Padding(4);
            this.PreviousDenpaButton.Name = "PreviousDenpaButton";
            this.PreviousDenpaButton.Size = new System.Drawing.Size(83, 28);
            this.PreviousDenpaButton.TabIndex = 36;
            this.PreviousDenpaButton.Text = "Previous";
            this.PreviousDenpaButton.UseVisualStyleBackColor = true;
            this.PreviousDenpaButton.Click += new System.EventHandler(this.PreviousDenpaButton_Click);
            // 
            // DenpaName
            // 
            this.DenpaName.Enabled = false;
            this.DenpaName.Location = new System.Drawing.Point(16, 76);
            this.DenpaName.Margin = new System.Windows.Forms.Padding(4);
            this.DenpaName.MaxLength = 12;
            this.DenpaName.Name = "DenpaName";
            this.DenpaName.Size = new System.Drawing.Size(229, 22);
            this.DenpaName.TabIndex = 37;
            this.DenpaName.TextChanged += new System.EventHandler(this.DenpaName_TextChanged);
            // 
            // AntennaAppearanceComboBox
            // 
            this.AntennaAppearanceComboBox.AllowDrop = true;
            this.AntennaAppearanceComboBox.Enabled = false;
            this.AntennaAppearanceComboBox.FormattingEnabled = true;
            this.AntennaAppearanceComboBox.Items.AddRange(new object[] {
            "None",
            "Antenna Root",
            "Treasure x2",
            "Treasure x3",
            "Treasure x5",
            "Rare Treasure x2",
            "Rare Treasure x3",
            "Rare Treasure x5",
            "Gold x2",
            "Gold x3",
            "Gold x5",
            "Stealthy",
            "Stealthier",
            "Stealhiest",
            "Tiny Heal",
            "Medium Heal",
            "Full Heal",
            "Tiny Heal (All)",
            "Medium Heal (All)",
            "Full Heal (All)",
            "Small Revive",
            "Revive",
            "Full Revive",
            "Small Revive (All)",
            "Revive  (All)",
            "Full Revive (All)",
            "Antidote",
            "Antidote (All)",
            "Cure Burn",
            "Cure Burn (All)",
            "Dry",
            "Dry (All)",
            "Cure Sniffles",
            "Cure Sniffles (All)",
            "Mud Off",
            "Mud Off (All)",
            "Purify",
            "Purify (All)",
            "Cure Shock",
            "Cure Shock (All)",
            "Hot Blanket",
            "Hot Blanket (All)",
            "Mobilize",
            "Mobilize (All)",
            "Awaken",
            "Awaken (All)",
            "Eye Drops",
            "Eye Drops (All)",
            "Invincible",
            "Invincible (All)",
            "Excite (All)",
            "Steroids",
            "Steroids (All)",
            "Reflect",
            "Reflect (All)",
            "Tiny Rage",
            "Rage",
            "Great Rage",
            "Tiny Rage (All)",
            "Rage (All)",
            "Great Rage (All)",
            "Tiny Wall",
            "Wall",
            "Great Wall",
            "Tiny Wall (All)",
            "Wall (All)",
            "Great Wall (All)",
            "Tiny Haste",
            "Haste",
            "Great Haste",
            "Tiny Haste (All)",
            "Haste (All)",
            "Great Haste (All)",
            "Tiny Dodge",
            "Dodge",
            "Great Dodge",
            "Tiny Dodge (All)",
            "Dodge (All)",
            "Great Dodge (All)",
            "Poison Signal",
            "Poison Wave",
            "Fatal",
            "Fatal (All)",
            "Lullably",
            "Lullably (All)",
            "Paralyze",
            "Paralyze (All)",
            "Blindfold ",
            "Blindfold (All)",
            "Breath Plug",
            "Breath Plug (All)",
            "Tiny Weaken",
            "Weaken",
            "Great Weaken",
            "Tiny Weaken (All)",
            "Weaken (All)",
            "Great Weaken (All)",
            "Tiny Insult",
            "Insult",
            "Great Insult",
            "Tiny Insult (All)",
            "Insult (All)",
            "Great Insult (All)",
            "Tiny Chain",
            "Chain",
            "Great Chain",
            "Tiny Chain (All)",
            "Chain (All)",
            "Great Chain (All)",
            "Fireball",
            "Flame Thrower",
            "Rising Flames",
            "Fire Cracker",
            "Explosion",
            "Big Bang",
            "Forest Fire",
            "Magma Wave",
            "Fire Wall",
            "Icicle",
            "Ice Blade",
            "Ice Missle",
            "On The Rocks",
            "Eternal Ice",
            "Diamond Dust",
            "Hailstorm",
            "Snowstorm",
            "Blizzard",
            "Whirlwind",
            "Sandstorm",
            "Cyclone",
            "Breeze",
            "Storm",
            "Hurricane",
            "Twister",
            "Jet Current",
            "Downburst",
            "Failling Rock",
            "Landslide",
            "Avalanche",
            "Pebbles",
            "Rock Crush",
            "Comet Crash",
            "Magnitude 3",
            "Magnitude 6",
            "Magnitude 12",
            "Static",
            "Shock",
            "Spark",
            "Lightning",
            "Thunder",
            "Bolt from the Blue",
            "100 Volts",
            "10000 Volts",
            "1 Billion Volts",
            "Water Gun",
            "Water Cannon",
            "Mud Stream",
            "Bucket of Water",
            "Waterfall",
            "Jet Splash",
            "High Wave",
            "Tidal Wave",
            "Island Destroyer",
            "Weak Flash",
            "Bright Flash",
            "Laser Beam",
            "Spotlight",
            "Light Burst",
            "Flare",
            "Winter Sunlight",
            "Summer Sun",
            "Supernova",
            "Scare",
            "Surprise",
            "Dark Messenger",
            "Dark Ball",
            "Black Whirl",
            "Black Hole",
            "Dark Mist",
            "Deep Shadow",
            "Abyss",
            "Ferocious Flames",
            "Iceberg",
            "Vengeful Wind",
            "Cave-In",
            "Lightning Ball",
            "Fierce Rapids",
            "Blinding Flash",
            "Servant of Darkness",
            "Scorched Ice",
            "Flame Ice",
            "Burning Wind",
            "Firestorm",
            "Eruption",
            "Meteor",
            "Lightning Scorch",
            "Thundering Fire",
            "Sea of Fire",
            "Hydro Fire",
            "Ice Storm",
            "Jet Blizzard",
            "Frozen Fossil",
            "Ice Meteor",
            "Shocking Snow",
            "Thunder Blizzard",
            "Hail",
            "Ice Squall",
            "Dust Storm",
            "Mud Hurricane ",
            "Lightning Storm",
            "Thunder Hurricane",
            "Horizontal Rain",
            "Hydro Storm",
            "Shock Rock",
            "Thundering Ground",
            "Streaming Stones",
            "Muddy Flood",
            "Thunderstorm",
            "Thunder Squall",
            "Black Sun",
            "Dark Shine",
            "Catch",
            "Catch x2",
            "Catch x3"});
            this.AntennaAppearanceComboBox.Location = new System.Drawing.Point(440, 25);
            this.AntennaAppearanceComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AntennaAppearanceComboBox.Name = "AntennaAppearanceComboBox";
            this.AntennaAppearanceComboBox.Size = new System.Drawing.Size(121, 24);
            this.AntennaAppearanceComboBox.TabIndex = 39;
            this.AntennaAppearanceComboBox.SelectedIndexChanged += new System.EventHandler(this.AntennaAppearanceComboBox_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(251, 57);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 17);
            this.label16.TabIndex = 41;
            this.label16.Text = "Level";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(16, 54);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 17);
            this.label17.TabIndex = 42;
            this.label17.Text = "Name";
            // 
            // LevelNumericUpDown
            // 
            this.LevelNumericUpDown.Enabled = false;
            this.LevelNumericUpDown.Location = new System.Drawing.Point(255, 78);
            this.LevelNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.LevelNumericUpDown.Maximum = new decimal(new int[] {
            199,
            0,
            0,
            0});
            this.LevelNumericUpDown.Name = "LevelNumericUpDown";
            this.LevelNumericUpDown.Size = new System.Drawing.Size(63, 22);
            this.LevelNumericUpDown.TabIndex = 43;
            this.LevelNumericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(351, 407);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 28);
            this.button1.TabIndex = 44;
            this.button1.Text = "Max Jewels and Gold";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.MaxGoldAndJewels);
            // 
            // CurrentDenpaLabel
            // 
            this.CurrentDenpaLabel.Location = new System.Drawing.Point(107, 28);
            this.CurrentDenpaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentDenpaLabel.Name = "CurrentDenpaLabel";
            this.CurrentDenpaLabel.Size = new System.Drawing.Size(119, 17);
            this.CurrentDenpaLabel.TabIndex = 46;
            this.CurrentDenpaLabel.Text = "(None)";
            this.CurrentDenpaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewDenpaButton
            // 
            this.NewDenpaButton.Enabled = false;
            this.NewDenpaButton.Location = new System.Drawing.Point(667, 175);
            this.NewDenpaButton.Margin = new System.Windows.Forms.Padding(4);
            this.NewDenpaButton.Name = "NewDenpaButton";
            this.NewDenpaButton.Size = new System.Drawing.Size(100, 28);
            this.NewDenpaButton.TabIndex = 47;
            this.NewDenpaButton.Text = "New Denpa";
            this.NewDenpaButton.UseVisualStyleBackColor = true;
            this.NewDenpaButton.Click += new System.EventHandler(this.NewDenpaButton_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(580, 85);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 17);
            this.label19.TabIndex = 51;
            this.label19.Text = "HP Bonus";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Location = new System.Drawing.Point(580, 114);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(70, 17);
            this.label20.TabIndex = 52;
            this.label20.Text = "AP Bonus";
            // 
            // HPNumericUpDown
            // 
            this.HPNumericUpDown.Enabled = false;
            this.HPNumericUpDown.Location = new System.Drawing.Point(667, 87);
            this.HPNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.HPNumericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.HPNumericUpDown.Name = "HPNumericUpDown";
            this.HPNumericUpDown.Size = new System.Drawing.Size(121, 22);
            this.HPNumericUpDown.TabIndex = 53;
            this.HPNumericUpDown.ValueChanged += new System.EventHandler(this.HPNumericUpDown_ValueChanged);
            // 
            // APNumberUpDown
            // 
            this.APNumberUpDown.Enabled = false;
            this.APNumberUpDown.Location = new System.Drawing.Point(667, 112);
            this.APNumberUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.APNumberUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.APNumberUpDown.Name = "APNumberUpDown";
            this.APNumberUpDown.Size = new System.Drawing.Size(121, 22);
            this.APNumberUpDown.TabIndex = 54;
            this.APNumberUpDown.ValueChanged += new System.EventHandler(this.APNumberUpDown_ValueChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Location = new System.Drawing.Point(662, 418);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(133, 17);
            this.linkLabel1.TabIndex = 55;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Denpa Men Discord";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(807, 453);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.APNumberUpDown);
            this.Controls.Add(this.HPNumericUpDown);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.NewDenpaButton);
            this.Controls.Add(this.CurrentDenpaLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LevelNumericUpDown);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.AntennaAppearanceComboBox);
            this.Controls.Add(this.DenpaName);
            this.Controls.Add(this.PreviousDenpaButton);
            this.Controls.Add(this.NextDenpaButton);
            this.Controls.Add(this.HeadShapeComboBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.HairColorComboBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.SkinComboBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ColorComboBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BodyComboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.GlassesComboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CheeksComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MouthComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NoseComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EyesComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EyebrowsComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HairComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FaceShapeComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AntennaComboBox);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveASButton);
            this.Controls.Add(this.CFButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Denpa Men 3 Save Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HPNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.APNumberUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CFButton;
        private System.Windows.Forms.Button SaveASButton;
        private System.Windows.Forms.ComboBox HeadShapeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label FileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox AntennaComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox FaceShapeComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox HairComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox EyebrowsComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox EyesComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox NoseComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox MouthComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CheeksComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox GlassesComboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox BodyComboBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox ColorComboBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox SkinComboBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox HairColorComboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button NextDenpaButton;
        private System.Windows.Forms.Button PreviousDenpaButton;
        private System.Windows.Forms.TextBox DenpaName;
        private System.Windows.Forms.ComboBox AntennaAppearanceComboBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown LevelNumericUpDown;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label CurrentDenpaLabel;
        private System.Windows.Forms.Button NewDenpaButton;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown HPNumericUpDown;
        private System.Windows.Forms.NumericUpDown APNumberUpDown;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

