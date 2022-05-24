
namespace WFG_3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nameChoice = new System.Windows.Forms.GroupBox();
            this.namebox = new System.Windows.Forms.TextBox();
            this.raceChoice = new System.Windows.Forms.GroupBox();
            this.elf = new System.Windows.Forms.RadioButton();
            this.human = new System.Windows.Forms.RadioButton();
            this.ogre = new System.Windows.Forms.RadioButton();
            this.classChoice = new System.Windows.Forms.GroupBox();
            this.mage = new System.Windows.Forms.RadioButton();
            this.ranger = new System.Windows.Forms.RadioButton();
            this.warrior = new System.Windows.Forms.RadioButton();
            this.enter = new System.Windows.Forms.Button();
            this.skill3_CD = new System.Windows.Forms.Label();
            this.skill1_CD = new System.Windows.Forms.Label();
            this.hppotion_counter = new System.Windows.Forms.Label();
            this.hppotion_Panel = new System.Windows.Forms.Panel();
            this.hppotion_Button = new System.Windows.Forms.Button();
            this.skill2_Panel = new System.Windows.Forms.Panel();
            this.skill2_Button = new System.Windows.Forms.Button();
            this.skill1_Panel = new System.Windows.Forms.Panel();
            this.skill1_Button = new System.Windows.Forms.Button();
            this.skill3_Panel = new System.Windows.Forms.Panel();
            this.skill3_Button = new System.Windows.Forms.Button();
            this.event_label = new System.Windows.Forms.Label();
            this.roomfloor_label = new System.Windows.Forms.Label();
            this.skill2_CD = new System.Windows.Forms.Label();
            this.heromp_Bar = new System.Windows.Forms.ProgressBar();
            this.herohp_Bar = new System.Windows.Forms.ProgressBar();
            this.herolvl_label = new System.Windows.Forms.Label();
            this.heroname_label = new System.Windows.Forms.Label();
            this.heroicon_pictureBox = new System.Windows.Forms.PictureBox();
            this.heroinfo_groupBox = new System.Windows.Forms.GroupBox();
            this.hero_xp_bar = new System.Windows.Forms.ProgressBar();
            this.enemymp_Bar = new System.Windows.Forms.ProgressBar();
            this.enemyhp_Bar = new System.Windows.Forms.ProgressBar();
            this.enemylvl_label = new System.Windows.Forms.Label();
            this.enemyname_label = new System.Windows.Forms.Label();
            this.enemyicon_pictureBox = new System.Windows.Forms.PictureBox();
            this.enemyinfo_groupBox = new System.Windows.Forms.GroupBox();
            this.enemy_xp_bar = new System.Windows.Forms.ProgressBar();
            this.herohp_label = new System.Windows.Forms.Label();
            this.heromp_label = new System.Windows.Forms.Label();
            this.enemyhp_label = new System.Windows.Forms.Label();
            this.enemymp_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.enemy_turn_timer = new System.Windows.Forms.Timer(this.components);
            this.skip_button = new System.Windows.Forms.Button();
            this.turn_indicator = new System.Windows.Forms.Label();
            this.scnd_event_label = new System.Windows.Forms.Label();
            this.thrd_event_label = new System.Windows.Forms.Label();
            this.enemy_skill1_panel = new System.Windows.Forms.Panel();
            this.enemy_skill1 = new System.Windows.Forms.PictureBox();
            this.enemy_skill1_CD = new System.Windows.Forms.Label();
            this.enemy_skill2_CD = new System.Windows.Forms.Label();
            this.enemy_skill2_panel = new System.Windows.Forms.Panel();
            this.enemy_skill2 = new System.Windows.Forms.PictureBox();
            this.enemy_skill3_CD = new System.Windows.Forms.Label();
            this.enemy_skill3_panel = new System.Windows.Forms.Panel();
            this.enemy_skill3 = new System.Windows.Forms.PictureBox();
            this.enemy_hppotion_counter = new System.Windows.Forms.Label();
            this.enemy_hppotion_panel = new System.Windows.Forms.Panel();
            this.enemy_hppotion = new System.Windows.Forms.PictureBox();
            this.hero_win_timer = new System.Windows.Forms.Timer(this.components);
            this.afterbattle_interval_timer = new System.Windows.Forms.Timer(this.components);
            this.reward_panel = new System.Windows.Forms.Panel();
            this.hero_changed_xp_bar = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.cur_item_image = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.reward_potion_image = new System.Windows.Forms.PictureBox();
            this.equip_button = new System.Windows.Forms.Button();
            this.cancel_equip_button = new System.Windows.Forms.Button();
            this.reward_image = new System.Windows.Forms.PictureBox();
            this.exp_changes = new System.Windows.Forms.Label();
            this.earned_exp = new System.Windows.Forms.Label();
            this.afterbattle_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.nameChoice.SuspendLayout();
            this.raceChoice.SuspendLayout();
            this.classChoice.SuspendLayout();
            this.hppotion_Panel.SuspendLayout();
            this.skill2_Panel.SuspendLayout();
            this.skill1_Panel.SuspendLayout();
            this.skill3_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heroicon_pictureBox)).BeginInit();
            this.heroinfo_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enemyicon_pictureBox)).BeginInit();
            this.enemyinfo_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.enemy_skill1_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_skill1)).BeginInit();
            this.enemy_skill2_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_skill2)).BeginInit();
            this.enemy_skill3_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_skill3)).BeginInit();
            this.enemy_hppotion_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_hppotion)).BeginInit();
            this.reward_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cur_item_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reward_potion_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reward_image)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("NSimSun", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(160, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "DUNGEON MASTER";
            this.label1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.start);
            this.panel1.Location = new System.Drawing.Point(256, 238);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 127);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(5, 85);
            this.exit.Margin = new System.Windows.Forms.Padding(4);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(257, 31);
            this.exit.TabIndex = 2;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            this.exit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.exit.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.exit.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(5, 45);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(257, 31);
            this.button2.TabIndex = 1;
            this.button2.Text = "Load";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.button2.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Transparent;
            this.start.Location = new System.Drawing.Point(5, 5);
            this.start.Margin = new System.Windows.Forms.Padding(4);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(257, 31);
            this.start.TabIndex = 0;
            this.start.Text = "New game";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            this.start.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.start.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.start.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.nameChoice);
            this.groupBox1.Controls.Add(this.raceChoice);
            this.groupBox1.Controls.Add(this.classChoice);
            this.groupBox1.ForeColor = System.Drawing.Color.Brown;
            this.groupBox1.Location = new System.Drawing.Point(171, 300);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(446, 237);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Creating new character";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(233, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.createhero_Click);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.button1.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // nameChoice
            // 
            this.nameChoice.Controls.Add(this.namebox);
            this.nameChoice.ForeColor = System.Drawing.Color.Brown;
            this.nameChoice.Location = new System.Drawing.Point(232, 25);
            this.nameChoice.Name = "nameChoice";
            this.nameChoice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nameChoice.Size = new System.Drawing.Size(202, 120);
            this.nameChoice.TabIndex = 4;
            this.nameChoice.TabStop = false;
            this.nameChoice.Text = "Name";
            // 
            // namebox
            // 
            this.namebox.BackColor = System.Drawing.Color.Linen;
            this.namebox.Location = new System.Drawing.Point(7, 47);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(189, 25);
            this.namebox.TabIndex = 0;
            this.namebox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.namebox_KeyPress);
            // 
            // raceChoice
            // 
            this.raceChoice.Controls.Add(this.elf);
            this.raceChoice.Controls.Add(this.human);
            this.raceChoice.Controls.Add(this.ogre);
            this.raceChoice.ForeColor = System.Drawing.Color.Brown;
            this.raceChoice.Location = new System.Drawing.Point(119, 25);
            this.raceChoice.Name = "raceChoice";
            this.raceChoice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.raceChoice.Size = new System.Drawing.Size(107, 205);
            this.raceChoice.TabIndex = 3;
            this.raceChoice.TabStop = false;
            this.raceChoice.Text = "Race";
            // 
            // elf
            // 
            this.elf.Appearance = System.Windows.Forms.Appearance.Button;
            this.elf.BackColor = System.Drawing.Color.WhiteSmoke;
            this.elf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.elf.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elf.ForeColor = System.Drawing.Color.Black;
            this.elf.Location = new System.Drawing.Point(6, 164);
            this.elf.Name = "elf";
            this.elf.Size = new System.Drawing.Size(95, 35);
            this.elf.TabIndex = 5;
            this.elf.Text = "Elf";
            this.elf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.elf.UseVisualStyleBackColor = false;
            this.elf.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            // 
            // human
            // 
            this.human.Appearance = System.Windows.Forms.Appearance.Button;
            this.human.BackColor = System.Drawing.Color.WhiteSmoke;
            this.human.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.human.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.human.ForeColor = System.Drawing.Color.Black;
            this.human.Location = new System.Drawing.Point(6, 96);
            this.human.Name = "human";
            this.human.Size = new System.Drawing.Size(95, 35);
            this.human.TabIndex = 4;
            this.human.Text = "Human";
            this.human.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.human.UseVisualStyleBackColor = false;
            this.human.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            // 
            // ogre
            // 
            this.ogre.Appearance = System.Windows.Forms.Appearance.Button;
            this.ogre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ogre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ogre.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ogre.ForeColor = System.Drawing.Color.Black;
            this.ogre.Location = new System.Drawing.Point(6, 24);
            this.ogre.Name = "ogre";
            this.ogre.Size = new System.Drawing.Size(95, 35);
            this.ogre.TabIndex = 3;
            this.ogre.Text = "Ogre";
            this.ogre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ogre.UseVisualStyleBackColor = false;
            this.ogre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            // 
            // classChoice
            // 
            this.classChoice.Controls.Add(this.mage);
            this.classChoice.Controls.Add(this.ranger);
            this.classChoice.Controls.Add(this.warrior);
            this.classChoice.ForeColor = System.Drawing.Color.Brown;
            this.classChoice.Location = new System.Drawing.Point(6, 25);
            this.classChoice.Name = "classChoice";
            this.classChoice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.classChoice.Size = new System.Drawing.Size(107, 205);
            this.classChoice.TabIndex = 0;
            this.classChoice.TabStop = false;
            this.classChoice.Text = "Class";
            // 
            // mage
            // 
            this.mage.Appearance = System.Windows.Forms.Appearance.Button;
            this.mage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mage.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mage.ForeColor = System.Drawing.Color.Black;
            this.mage.Location = new System.Drawing.Point(6, 164);
            this.mage.Name = "mage";
            this.mage.Size = new System.Drawing.Size(95, 35);
            this.mage.TabIndex = 2;
            this.mage.Text = "Mage";
            this.mage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mage.UseVisualStyleBackColor = false;
            this.mage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            // 
            // ranger
            // 
            this.ranger.Appearance = System.Windows.Forms.Appearance.Button;
            this.ranger.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ranger.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ranger.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ranger.ForeColor = System.Drawing.Color.Black;
            this.ranger.Location = new System.Drawing.Point(6, 96);
            this.ranger.Name = "ranger";
            this.ranger.Size = new System.Drawing.Size(95, 35);
            this.ranger.TabIndex = 1;
            this.ranger.Text = "Ranger";
            this.ranger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ranger.UseVisualStyleBackColor = false;
            this.ranger.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            // 
            // warrior
            // 
            this.warrior.Appearance = System.Windows.Forms.Appearance.Button;
            this.warrior.BackColor = System.Drawing.Color.WhiteSmoke;
            this.warrior.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.warrior.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warrior.ForeColor = System.Drawing.Color.Black;
            this.warrior.Location = new System.Drawing.Point(6, 24);
            this.warrior.Name = "warrior";
            this.warrior.Size = new System.Drawing.Size(95, 35);
            this.warrior.TabIndex = 0;
            this.warrior.Text = "Warrior";
            this.warrior.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.warrior.UseVisualStyleBackColor = false;
            this.warrior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(250, 265);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(284, 31);
            this.enter.TabIndex = 6;
            this.enter.Text = "ENTER";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            this.enter.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.enter.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // skill3_CD
            // 
            this.skill3_CD.AutoSize = true;
            this.skill3_CD.BackColor = System.Drawing.Color.Transparent;
            this.skill3_CD.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skill3_CD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.skill3_CD.Location = new System.Drawing.Point(704, 362);
            this.skill3_CD.Name = "skill3_CD";
            this.skill3_CD.Size = new System.Drawing.Size(16, 16);
            this.skill3_CD.TabIndex = 37;
            this.skill3_CD.Text = "0";
            // 
            // skill1_CD
            // 
            this.skill1_CD.AutoSize = true;
            this.skill1_CD.BackColor = System.Drawing.Color.Transparent;
            this.skill1_CD.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skill1_CD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.skill1_CD.Location = new System.Drawing.Point(535, 362);
            this.skill1_CD.Name = "skill1_CD";
            this.skill1_CD.Size = new System.Drawing.Size(16, 16);
            this.skill1_CD.TabIndex = 35;
            this.skill1_CD.Text = "0";
            // 
            // hppotion_counter
            // 
            this.hppotion_counter.AutoSize = true;
            this.hppotion_counter.BackColor = System.Drawing.Color.Transparent;
            this.hppotion_counter.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hppotion_counter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hppotion_counter.Location = new System.Drawing.Point(60, 448);
            this.hppotion_counter.Name = "hppotion_counter";
            this.hppotion_counter.Size = new System.Drawing.Size(16, 16);
            this.hppotion_counter.TabIndex = 33;
            this.hppotion_counter.Text = "0";
            // 
            // hppotion_Panel
            // 
            this.hppotion_Panel.BackColor = System.Drawing.Color.Transparent;
            this.hppotion_Panel.Controls.Add(this.hppotion_Button);
            this.hppotion_Panel.Location = new System.Drawing.Point(12, 381);
            this.hppotion_Panel.Name = "hppotion_Panel";
            this.hppotion_Panel.Size = new System.Drawing.Size(64, 64);
            this.hppotion_Panel.TabIndex = 30;
            // 
            // hppotion_Button
            // 
            this.hppotion_Button.Location = new System.Drawing.Point(0, 0);
            this.hppotion_Button.Name = "hppotion_Button";
            this.hppotion_Button.Size = new System.Drawing.Size(64, 64);
            this.hppotion_Button.TabIndex = 9;
            this.hppotion_Button.UseVisualStyleBackColor = true;
            this.hppotion_Button.Click += new System.EventHandler(this.hppotion_Button_Click);
            // 
            // skill2_Panel
            // 
            this.skill2_Panel.BackColor = System.Drawing.Color.Transparent;
            this.skill2_Panel.Controls.Add(this.skill2_Button);
            this.skill2_Panel.Location = new System.Drawing.Point(623, 381);
            this.skill2_Panel.Name = "skill2_Panel";
            this.skill2_Panel.Size = new System.Drawing.Size(64, 64);
            this.skill2_Panel.TabIndex = 29;
            // 
            // skill2_Button
            // 
            this.skill2_Button.Location = new System.Drawing.Point(0, 0);
            this.skill2_Button.Name = "skill2_Button";
            this.skill2_Button.Size = new System.Drawing.Size(64, 64);
            this.skill2_Button.TabIndex = 7;
            this.skill2_Button.UseVisualStyleBackColor = true;
            this.skill2_Button.Click += new System.EventHandler(this.skill2_Button_Click);
            // 
            // skill1_Panel
            // 
            this.skill1_Panel.BackColor = System.Drawing.Color.Transparent;
            this.skill1_Panel.Controls.Add(this.skill1_Button);
            this.skill1_Panel.Location = new System.Drawing.Point(538, 381);
            this.skill1_Panel.Name = "skill1_Panel";
            this.skill1_Panel.Size = new System.Drawing.Size(64, 64);
            this.skill1_Panel.TabIndex = 32;
            // 
            // skill1_Button
            // 
            this.skill1_Button.Location = new System.Drawing.Point(0, 0);
            this.skill1_Button.Name = "skill1_Button";
            this.skill1_Button.Size = new System.Drawing.Size(64, 64);
            this.skill1_Button.TabIndex = 6;
            this.skill1_Button.UseVisualStyleBackColor = true;
            this.skill1_Button.Click += new System.EventHandler(this.skill1_Button_Click);
            // 
            // skill3_Panel
            // 
            this.skill3_Panel.BackColor = System.Drawing.Color.Transparent;
            this.skill3_Panel.Controls.Add(this.skill3_Button);
            this.skill3_Panel.Location = new System.Drawing.Point(708, 381);
            this.skill3_Panel.Name = "skill3_Panel";
            this.skill3_Panel.Size = new System.Drawing.Size(64, 64);
            this.skill3_Panel.TabIndex = 28;
            // 
            // skill3_Button
            // 
            this.skill3_Button.Location = new System.Drawing.Point(0, 0);
            this.skill3_Button.Name = "skill3_Button";
            this.skill3_Button.Size = new System.Drawing.Size(64, 64);
            this.skill3_Button.TabIndex = 8;
            this.skill3_Button.UseVisualStyleBackColor = true;
            this.skill3_Button.Click += new System.EventHandler(this.skill3_Button_Click);
            // 
            // event_label
            // 
            this.event_label.BackColor = System.Drawing.Color.Transparent;
            this.event_label.Font = new System.Drawing.Font("NSimSun", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.event_label.ForeColor = System.Drawing.Color.Yellow;
            this.event_label.Location = new System.Drawing.Point(209, 288);
            this.event_label.Name = "event_label";
            this.event_label.Size = new System.Drawing.Size(369, 64);
            this.event_label.TabIndex = 27;
            this.event_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roomfloor_label
            // 
            this.roomfloor_label.BackColor = System.Drawing.Color.Transparent;
            this.roomfloor_label.Font = new System.Drawing.Font("NSimSun", 20.25F);
            this.roomfloor_label.ForeColor = System.Drawing.Color.Brown;
            this.roomfloor_label.Location = new System.Drawing.Point(483, 10);
            this.roomfloor_label.Name = "roomfloor_label";
            this.roomfloor_label.Size = new System.Drawing.Size(289, 27);
            this.roomfloor_label.TabIndex = 26;
            this.roomfloor_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skill2_CD
            // 
            this.skill2_CD.AutoSize = true;
            this.skill2_CD.BackColor = System.Drawing.Color.Transparent;
            this.skill2_CD.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skill2_CD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.skill2_CD.Location = new System.Drawing.Point(620, 362);
            this.skill2_CD.Name = "skill2_CD";
            this.skill2_CD.Size = new System.Drawing.Size(16, 16);
            this.skill2_CD.TabIndex = 36;
            this.skill2_CD.Text = "0";
            // 
            // heromp_Bar
            // 
            this.heromp_Bar.BackColor = System.Drawing.Color.PeachPuff;
            this.heromp_Bar.ForeColor = System.Drawing.Color.MediumBlue;
            this.heromp_Bar.Location = new System.Drawing.Point(12, 517);
            this.heromp_Bar.Name = "heromp_Bar";
            this.heromp_Bar.Size = new System.Drawing.Size(518, 23);
            this.heromp_Bar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.heromp_Bar.TabIndex = 25;
            // 
            // herohp_Bar
            // 
            this.herohp_Bar.BackColor = System.Drawing.Color.PeachPuff;
            this.herohp_Bar.ForeColor = System.Drawing.Color.Green;
            this.herohp_Bar.Location = new System.Drawing.Point(12, 488);
            this.herohp_Bar.Name = "herohp_Bar";
            this.herohp_Bar.Size = new System.Drawing.Size(518, 23);
            this.herohp_Bar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.herohp_Bar.TabIndex = 24;
            // 
            // herolvl_label
            // 
            this.herolvl_label.AutoSize = true;
            this.herolvl_label.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.herolvl_label.Location = new System.Drawing.Point(79, 61);
            this.herolvl_label.Name = "herolvl_label";
            this.herolvl_label.Size = new System.Drawing.Size(55, 15);
            this.herolvl_label.TabIndex = 2;
            this.herolvl_label.Text = "label3";
            // 
            // heroname_label
            // 
            this.heroname_label.AutoSize = true;
            this.heroname_label.Font = new System.Drawing.Font("NSimSun", 20.25F);
            this.heroname_label.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.heroname_label.Location = new System.Drawing.Point(77, 25);
            this.heroname_label.Name = "heroname_label";
            this.heroname_label.Size = new System.Drawing.Size(96, 27);
            this.heroname_label.TabIndex = 1;
            this.heroname_label.Text = "label4";
            // 
            // heroicon_pictureBox
            // 
            this.heroicon_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.heroicon_pictureBox.Location = new System.Drawing.Point(7, 25);
            this.heroicon_pictureBox.Name = "heroicon_pictureBox";
            this.heroicon_pictureBox.Size = new System.Drawing.Size(64, 64);
            this.heroicon_pictureBox.TabIndex = 0;
            this.heroicon_pictureBox.TabStop = false;
            // 
            // heroinfo_groupBox
            // 
            this.heroinfo_groupBox.BackColor = System.Drawing.Color.Transparent;
            this.heroinfo_groupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.heroinfo_groupBox.Controls.Add(this.hero_xp_bar);
            this.heroinfo_groupBox.Controls.Add(this.herolvl_label);
            this.heroinfo_groupBox.Controls.Add(this.heroname_label);
            this.heroinfo_groupBox.Controls.Add(this.heroicon_pictureBox);
            this.heroinfo_groupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.heroinfo_groupBox.ForeColor = System.Drawing.Color.Maroon;
            this.heroinfo_groupBox.Location = new System.Drawing.Point(538, 451);
            this.heroinfo_groupBox.Name = "heroinfo_groupBox";
            this.heroinfo_groupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.heroinfo_groupBox.Size = new System.Drawing.Size(234, 100);
            this.heroinfo_groupBox.TabIndex = 23;
            this.heroinfo_groupBox.TabStop = false;
            this.heroinfo_groupBox.Text = "Hero";
            // 
            // hero_xp_bar
            // 
            this.hero_xp_bar.BackColor = System.Drawing.Color.Moccasin;
            this.hero_xp_bar.ForeColor = System.Drawing.Color.Green;
            this.hero_xp_bar.Location = new System.Drawing.Point(77, 79);
            this.hero_xp_bar.Name = "hero_xp_bar";
            this.hero_xp_bar.Size = new System.Drawing.Size(72, 10);
            this.hero_xp_bar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.hero_xp_bar.TabIndex = 56;
            // 
            // enemymp_Bar
            // 
            this.enemymp_Bar.BackColor = System.Drawing.Color.PeachPuff;
            this.enemymp_Bar.ForeColor = System.Drawing.Color.MediumBlue;
            this.enemymp_Bar.Location = new System.Drawing.Point(253, 68);
            this.enemymp_Bar.Name = "enemymp_Bar";
            this.enemymp_Bar.Size = new System.Drawing.Size(518, 23);
            this.enemymp_Bar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.enemymp_Bar.TabIndex = 22;
            // 
            // enemyhp_Bar
            // 
            this.enemyhp_Bar.BackColor = System.Drawing.Color.Moccasin;
            this.enemyhp_Bar.ForeColor = System.Drawing.Color.Green;
            this.enemyhp_Bar.Location = new System.Drawing.Point(254, 40);
            this.enemyhp_Bar.Name = "enemyhp_Bar";
            this.enemyhp_Bar.Size = new System.Drawing.Size(518, 23);
            this.enemyhp_Bar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.enemyhp_Bar.TabIndex = 21;
            // 
            // enemylvl_label
            // 
            this.enemylvl_label.AutoSize = true;
            this.enemylvl_label.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.enemylvl_label.Location = new System.Drawing.Point(79, 61);
            this.enemylvl_label.Name = "enemylvl_label";
            this.enemylvl_label.Size = new System.Drawing.Size(55, 15);
            this.enemylvl_label.TabIndex = 2;
            this.enemylvl_label.Text = "label2";
            // 
            // enemyname_label
            // 
            this.enemyname_label.AutoSize = true;
            this.enemyname_label.Font = new System.Drawing.Font("NSimSun", 20.25F);
            this.enemyname_label.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.enemyname_label.Location = new System.Drawing.Point(77, 25);
            this.enemyname_label.Name = "enemyname_label";
            this.enemyname_label.Size = new System.Drawing.Size(96, 27);
            this.enemyname_label.TabIndex = 1;
            this.enemyname_label.Text = "label1";
            // 
            // enemyicon_pictureBox
            // 
            this.enemyicon_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.enemyicon_pictureBox.Location = new System.Drawing.Point(7, 25);
            this.enemyicon_pictureBox.Name = "enemyicon_pictureBox";
            this.enemyicon_pictureBox.Size = new System.Drawing.Size(64, 64);
            this.enemyicon_pictureBox.TabIndex = 0;
            this.enemyicon_pictureBox.TabStop = false;
            // 
            // enemyinfo_groupBox
            // 
            this.enemyinfo_groupBox.BackColor = System.Drawing.Color.Transparent;
            this.enemyinfo_groupBox.Controls.Add(this.enemy_xp_bar);
            this.enemyinfo_groupBox.Controls.Add(this.enemylvl_label);
            this.enemyinfo_groupBox.Controls.Add(this.enemyname_label);
            this.enemyinfo_groupBox.Controls.Add(this.enemyicon_pictureBox);
            this.enemyinfo_groupBox.ForeColor = System.Drawing.Color.Maroon;
            this.enemyinfo_groupBox.Location = new System.Drawing.Point(13, 15);
            this.enemyinfo_groupBox.Name = "enemyinfo_groupBox";
            this.enemyinfo_groupBox.Size = new System.Drawing.Size(234, 100);
            this.enemyinfo_groupBox.TabIndex = 20;
            this.enemyinfo_groupBox.TabStop = false;
            this.enemyinfo_groupBox.Text = "Enemy";
            // 
            // enemy_xp_bar
            // 
            this.enemy_xp_bar.BackColor = System.Drawing.Color.Moccasin;
            this.enemy_xp_bar.ForeColor = System.Drawing.Color.Green;
            this.enemy_xp_bar.Location = new System.Drawing.Point(82, 79);
            this.enemy_xp_bar.Name = "enemy_xp_bar";
            this.enemy_xp_bar.Size = new System.Drawing.Size(72, 10);
            this.enemy_xp_bar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.enemy_xp_bar.TabIndex = 55;
            // 
            // herohp_label
            // 
            this.herohp_label.AutoSize = true;
            this.herohp_label.BackColor = System.Drawing.Color.Transparent;
            this.herohp_label.ForeColor = System.Drawing.Color.LimeGreen;
            this.herohp_label.Location = new System.Drawing.Point(9, 470);
            this.herohp_label.Name = "herohp_label";
            this.herohp_label.Size = new System.Drawing.Size(55, 15);
            this.herohp_label.TabIndex = 38;
            this.herohp_label.Text = "Health";
            // 
            // heromp_label
            // 
            this.heromp_label.AutoSize = true;
            this.heromp_label.BackColor = System.Drawing.Color.Transparent;
            this.heromp_label.ForeColor = System.Drawing.Color.Blue;
            this.heromp_label.Location = new System.Drawing.Point(9, 543);
            this.heromp_label.Name = "heromp_label";
            this.heromp_label.Size = new System.Drawing.Size(39, 15);
            this.heromp_label.TabIndex = 39;
            this.heromp_label.Text = "Mana";
            // 
            // enemyhp_label
            // 
            this.enemyhp_label.AutoSize = true;
            this.enemyhp_label.BackColor = System.Drawing.Color.Transparent;
            this.enemyhp_label.ForeColor = System.Drawing.Color.LimeGreen;
            this.enemyhp_label.Location = new System.Drawing.Point(253, 22);
            this.enemyhp_label.Name = "enemyhp_label";
            this.enemyhp_label.Size = new System.Drawing.Size(55, 15);
            this.enemyhp_label.TabIndex = 40;
            this.enemyhp_label.Text = "Health";
            // 
            // enemymp_label
            // 
            this.enemymp_label.AutoSize = true;
            this.enemymp_label.BackColor = System.Drawing.Color.Transparent;
            this.enemymp_label.ForeColor = System.Drawing.Color.Blue;
            this.enemymp_label.Location = new System.Drawing.Point(253, 95);
            this.enemymp_label.Name = "enemymp_label";
            this.enemymp_label.Size = new System.Drawing.Size(39, 15);
            this.enemymp_label.TabIndex = 41;
            this.enemymp_label.Text = "Mana";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WFG_3.Properties.Resources.Dungeon_Background_OCWIP_PixelArt;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(783, 566);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // enemy_turn_timer
            // 
            this.enemy_turn_timer.Tick += new System.EventHandler(this.enemy_turn_timer_tick);
            // 
            // skip_button
            // 
            this.skip_button.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.skip_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.skip_button.ForeColor = System.Drawing.Color.Maroon;
            this.skip_button.Location = new System.Drawing.Point(708, 334);
            this.skip_button.Name = "skip_button";
            this.skip_button.Size = new System.Drawing.Size(65, 25);
            this.skip_button.TabIndex = 43;
            this.skip_button.Text = "Skip";
            this.skip_button.UseVisualStyleBackColor = false;
            this.skip_button.Click += new System.EventHandler(this.skip_button_Click);
            // 
            // turn_indicator
            // 
            this.turn_indicator.AutoSize = true;
            this.turn_indicator.BackColor = System.Drawing.Color.Transparent;
            this.turn_indicator.Font = new System.Drawing.Font("NSimSun", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turn_indicator.ForeColor = System.Drawing.Color.Red;
            this.turn_indicator.Location = new System.Drawing.Point(8, 253);
            this.turn_indicator.Name = "turn_indicator";
            this.turn_indicator.Size = new System.Drawing.Size(120, 21);
            this.turn_indicator.TabIndex = 45;
            this.turn_indicator.Text = "Your turn!";
            // 
            // scnd_event_label
            // 
            this.scnd_event_label.BackColor = System.Drawing.Color.Transparent;
            this.scnd_event_label.Font = new System.Drawing.Font("NSimSun", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scnd_event_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.scnd_event_label.Location = new System.Drawing.Point(206, 239);
            this.scnd_event_label.Name = "scnd_event_label";
            this.scnd_event_label.Size = new System.Drawing.Size(372, 49);
            this.scnd_event_label.TabIndex = 46;
            this.scnd_event_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // thrd_event_label
            // 
            this.thrd_event_label.BackColor = System.Drawing.Color.Transparent;
            this.thrd_event_label.Font = new System.Drawing.Font("NSimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thrd_event_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.thrd_event_label.Location = new System.Drawing.Point(212, 201);
            this.thrd_event_label.Name = "thrd_event_label";
            this.thrd_event_label.Size = new System.Drawing.Size(366, 38);
            this.thrd_event_label.TabIndex = 47;
            this.thrd_event_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // enemy_skill1_panel
            // 
            this.enemy_skill1_panel.BackColor = System.Drawing.Color.Transparent;
            this.enemy_skill1_panel.Controls.Add(this.enemy_skill1);
            this.enemy_skill1_panel.Location = new System.Drawing.Point(12, 121);
            this.enemy_skill1_panel.Name = "enemy_skill1_panel";
            this.enemy_skill1_panel.Size = new System.Drawing.Size(32, 32);
            this.enemy_skill1_panel.TabIndex = 48;
            // 
            // enemy_skill1
            // 
            this.enemy_skill1.Location = new System.Drawing.Point(0, 0);
            this.enemy_skill1.Name = "enemy_skill1";
            this.enemy_skill1.Size = new System.Drawing.Size(32, 32);
            this.enemy_skill1.TabIndex = 54;
            this.enemy_skill1.TabStop = false;
            // 
            // enemy_skill1_CD
            // 
            this.enemy_skill1_CD.AutoSize = true;
            this.enemy_skill1_CD.BackColor = System.Drawing.Color.Transparent;
            this.enemy_skill1_CD.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemy_skill1_CD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.enemy_skill1_CD.Location = new System.Drawing.Point(9, 158);
            this.enemy_skill1_CD.Name = "enemy_skill1_CD";
            this.enemy_skill1_CD.Size = new System.Drawing.Size(16, 16);
            this.enemy_skill1_CD.TabIndex = 49;
            this.enemy_skill1_CD.Text = "0";
            // 
            // enemy_skill2_CD
            // 
            this.enemy_skill2_CD.AutoSize = true;
            this.enemy_skill2_CD.BackColor = System.Drawing.Color.Transparent;
            this.enemy_skill2_CD.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemy_skill2_CD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.enemy_skill2_CD.Location = new System.Drawing.Point(47, 158);
            this.enemy_skill2_CD.Name = "enemy_skill2_CD";
            this.enemy_skill2_CD.Size = new System.Drawing.Size(16, 16);
            this.enemy_skill2_CD.TabIndex = 51;
            this.enemy_skill2_CD.Text = "0";
            // 
            // enemy_skill2_panel
            // 
            this.enemy_skill2_panel.BackColor = System.Drawing.Color.Transparent;
            this.enemy_skill2_panel.Controls.Add(this.enemy_skill2);
            this.enemy_skill2_panel.Location = new System.Drawing.Point(50, 121);
            this.enemy_skill2_panel.Name = "enemy_skill2_panel";
            this.enemy_skill2_panel.Size = new System.Drawing.Size(32, 32);
            this.enemy_skill2_panel.TabIndex = 50;
            // 
            // enemy_skill2
            // 
            this.enemy_skill2.Location = new System.Drawing.Point(0, 0);
            this.enemy_skill2.Name = "enemy_skill2";
            this.enemy_skill2.Size = new System.Drawing.Size(32, 32);
            this.enemy_skill2.TabIndex = 55;
            this.enemy_skill2.TabStop = false;
            // 
            // enemy_skill3_CD
            // 
            this.enemy_skill3_CD.AutoSize = true;
            this.enemy_skill3_CD.BackColor = System.Drawing.Color.Transparent;
            this.enemy_skill3_CD.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemy_skill3_CD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.enemy_skill3_CD.Location = new System.Drawing.Point(85, 158);
            this.enemy_skill3_CD.Name = "enemy_skill3_CD";
            this.enemy_skill3_CD.Size = new System.Drawing.Size(16, 16);
            this.enemy_skill3_CD.TabIndex = 51;
            this.enemy_skill3_CD.Text = "0";
            // 
            // enemy_skill3_panel
            // 
            this.enemy_skill3_panel.BackColor = System.Drawing.Color.Transparent;
            this.enemy_skill3_panel.Controls.Add(this.enemy_skill3);
            this.enemy_skill3_panel.Location = new System.Drawing.Point(88, 121);
            this.enemy_skill3_panel.Name = "enemy_skill3_panel";
            this.enemy_skill3_panel.Size = new System.Drawing.Size(32, 32);
            this.enemy_skill3_panel.TabIndex = 50;
            // 
            // enemy_skill3
            // 
            this.enemy_skill3.Location = new System.Drawing.Point(0, 0);
            this.enemy_skill3.Name = "enemy_skill3";
            this.enemy_skill3.Size = new System.Drawing.Size(32, 32);
            this.enemy_skill3.TabIndex = 55;
            this.enemy_skill3.TabStop = false;
            // 
            // enemy_hppotion_counter
            // 
            this.enemy_hppotion_counter.AutoSize = true;
            this.enemy_hppotion_counter.BackColor = System.Drawing.Color.Transparent;
            this.enemy_hppotion_counter.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemy_hppotion_counter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.enemy_hppotion_counter.Location = new System.Drawing.Point(123, 158);
            this.enemy_hppotion_counter.Name = "enemy_hppotion_counter";
            this.enemy_hppotion_counter.Size = new System.Drawing.Size(16, 16);
            this.enemy_hppotion_counter.TabIndex = 53;
            this.enemy_hppotion_counter.Text = "0";
            // 
            // enemy_hppotion_panel
            // 
            this.enemy_hppotion_panel.BackColor = System.Drawing.Color.Transparent;
            this.enemy_hppotion_panel.Controls.Add(this.enemy_hppotion);
            this.enemy_hppotion_panel.Location = new System.Drawing.Point(126, 121);
            this.enemy_hppotion_panel.Name = "enemy_hppotion_panel";
            this.enemy_hppotion_panel.Size = new System.Drawing.Size(32, 32);
            this.enemy_hppotion_panel.TabIndex = 52;
            // 
            // enemy_hppotion
            // 
            this.enemy_hppotion.Location = new System.Drawing.Point(0, 0);
            this.enemy_hppotion.Name = "enemy_hppotion";
            this.enemy_hppotion.Size = new System.Drawing.Size(32, 32);
            this.enemy_hppotion.TabIndex = 56;
            this.enemy_hppotion.TabStop = false;
            // 
            // hero_win_timer
            // 
            this.hero_win_timer.Tick += new System.EventHandler(this.hero_win_timer_Tick);
            // 
            // afterbattle_interval_timer
            // 
            this.afterbattle_interval_timer.Tick += new System.EventHandler(this.afterbattle_interval_timer_Tick);
            // 
            // reward_panel
            // 
            this.reward_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.reward_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reward_panel.Controls.Add(this.hero_changed_xp_bar);
            this.reward_panel.Controls.Add(this.label3);
            this.reward_panel.Controls.Add(this.cur_item_image);
            this.reward_panel.Controls.Add(this.label2);
            this.reward_panel.Controls.Add(this.reward_potion_image);
            this.reward_panel.Controls.Add(this.equip_button);
            this.reward_panel.Controls.Add(this.cancel_equip_button);
            this.reward_panel.Controls.Add(this.reward_image);
            this.reward_panel.Controls.Add(this.exp_changes);
            this.reward_panel.Controls.Add(this.earned_exp);
            this.reward_panel.Location = new System.Drawing.Point(800, 800);
            this.reward_panel.Name = "reward_panel";
            this.reward_panel.Size = new System.Drawing.Size(562, 496);
            this.reward_panel.TabIndex = 54;
            // 
            // hero_changed_xp_bar
            // 
            this.hero_changed_xp_bar.BackColor = System.Drawing.Color.Moccasin;
            this.hero_changed_xp_bar.ForeColor = System.Drawing.Color.Green;
            this.hero_changed_xp_bar.Location = new System.Drawing.Point(19, 141);
            this.hero_changed_xp_bar.Name = "hero_changed_xp_bar";
            this.hero_changed_xp_bar.Size = new System.Drawing.Size(518, 13);
            this.hero_changed_xp_bar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.hero_changed_xp_bar.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("NSimSun", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(262, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 27);
            this.label3.TabIndex = 69;
            this.label3.Text = "→";
            // 
            // cur_item_image
            // 
            this.cur_item_image.Location = new System.Drawing.Point(362, 214);
            this.cur_item_image.Name = "cur_item_image";
            this.cur_item_image.Size = new System.Drawing.Size(128, 128);
            this.cur_item_image.TabIndex = 68;
            this.cur_item_image.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(218, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 15);
            this.label2.TabIndex = 67;
            this.label2.Text = "+1";
            // 
            // reward_potion_image
            // 
            this.reward_potion_image.Image = global::WFG_3.Properties.Resources.A_HPP_LVL1_HealPotion;
            this.reward_potion_image.Location = new System.Drawing.Point(247, 407);
            this.reward_potion_image.Name = "reward_potion_image";
            this.reward_potion_image.Size = new System.Drawing.Size(64, 64);
            this.reward_potion_image.TabIndex = 66;
            this.reward_potion_image.TabStop = false;
            // 
            // equip_button
            // 
            this.equip_button.BackColor = System.Drawing.Color.Linen;
            this.equip_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.equip_button.Font = new System.Drawing.Font("NSimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equip_button.ForeColor = System.Drawing.Color.Brown;
            this.equip_button.Location = new System.Drawing.Point(44, 417);
            this.equip_button.Name = "equip_button";
            this.equip_button.Size = new System.Drawing.Size(150, 50);
            this.equip_button.TabIndex = 64;
            this.equip_button.Text = "Equip";
            this.equip_button.UseVisualStyleBackColor = false;
            this.equip_button.Click += new System.EventHandler(this.equip_button_Click);
            // 
            // cancel_equip_button
            // 
            this.cancel_equip_button.BackColor = System.Drawing.Color.Linen;
            this.cancel_equip_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancel_equip_button.Font = new System.Drawing.Font("NSimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_equip_button.ForeColor = System.Drawing.Color.Brown;
            this.cancel_equip_button.Location = new System.Drawing.Point(362, 419);
            this.cancel_equip_button.Name = "cancel_equip_button";
            this.cancel_equip_button.Size = new System.Drawing.Size(150, 50);
            this.cancel_equip_button.TabIndex = 63;
            this.cancel_equip_button.Text = "Cancel";
            this.cancel_equip_button.UseVisualStyleBackColor = false;
            this.cancel_equip_button.Click += new System.EventHandler(this.cancel_equip_button_Click);
            // 
            // reward_image
            // 
            this.reward_image.Location = new System.Drawing.Point(66, 214);
            this.reward_image.Name = "reward_image";
            this.reward_image.Size = new System.Drawing.Size(128, 128);
            this.reward_image.TabIndex = 62;
            this.reward_image.TabStop = false;
            // 
            // exp_changes
            // 
            this.exp_changes.BackColor = System.Drawing.Color.Transparent;
            this.exp_changes.Font = new System.Drawing.Font("NSimSun", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exp_changes.ForeColor = System.Drawing.Color.Yellow;
            this.exp_changes.Location = new System.Drawing.Point(-1, 39);
            this.exp_changes.Name = "exp_changes";
            this.exp_changes.Size = new System.Drawing.Size(562, 95);
            this.exp_changes.TabIndex = 61;
            this.exp_changes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // earned_exp
            // 
            this.earned_exp.BackColor = System.Drawing.Color.Transparent;
            this.earned_exp.Font = new System.Drawing.Font("NSimSun", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.earned_exp.ForeColor = System.Drawing.Color.Yellow;
            this.earned_exp.Location = new System.Drawing.Point(0, 1);
            this.earned_exp.Name = "earned_exp";
            this.earned_exp.Size = new System.Drawing.Size(562, 38);
            this.earned_exp.TabIndex = 60;
            this.earned_exp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // afterbattle_label
            // 
            this.afterbattle_label.BackColor = System.Drawing.Color.Transparent;
            this.afterbattle_label.Font = new System.Drawing.Font("NSimSun", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afterbattle_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.afterbattle_label.Location = new System.Drawing.Point(207, 252);
            this.afterbattle_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.afterbattle_label.Name = "afterbattle_label";
            this.afterbattle_label.Size = new System.Drawing.Size(366, 48);
            this.afterbattle_label.TabIndex = 55;
            this.afterbattle_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.afterbattle_label.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.afterbattle_label);
            this.Controls.Add(this.reward_panel);
            this.Controls.Add(this.enemy_hppotion_counter);
            this.Controls.Add(this.enemy_skill3_CD);
            this.Controls.Add(this.enemy_hppotion_panel);
            this.Controls.Add(this.enemy_skill2_CD);
            this.Controls.Add(this.enemy_skill3_panel);
            this.Controls.Add(this.enemy_skill1_CD);
            this.Controls.Add(this.enemy_skill2_panel);
            this.Controls.Add(this.enemy_skill1_panel);
            this.Controls.Add(this.thrd_event_label);
            this.Controls.Add(this.scnd_event_label);
            this.Controls.Add(this.turn_indicator);
            this.Controls.Add(this.skip_button);
            this.Controls.Add(this.enemymp_label);
            this.Controls.Add(this.enemyhp_label);
            this.Controls.Add(this.event_label);
            this.Controls.Add(this.heromp_label);
            this.Controls.Add(this.herohp_label);
            this.Controls.Add(this.skill3_CD);
            this.Controls.Add(this.skill1_CD);
            this.Controls.Add(this.hppotion_counter);
            this.Controls.Add(this.hppotion_Panel);
            this.Controls.Add(this.skill2_Panel);
            this.Controls.Add(this.skill1_Panel);
            this.Controls.Add(this.skill3_Panel);
            this.Controls.Add(this.roomfloor_label);
            this.Controls.Add(this.skill2_CD);
            this.Controls.Add(this.heromp_Bar);
            this.Controls.Add(this.herohp_Bar);
            this.Controls.Add(this.heroinfo_groupBox);
            this.Controls.Add(this.enemymp_Bar);
            this.Controls.Add(this.enemyhp_Bar);
            this.Controls.Add(this.enemyinfo_groupBox);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("NSimSun", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.nameChoice.ResumeLayout(false);
            this.nameChoice.PerformLayout();
            this.raceChoice.ResumeLayout(false);
            this.classChoice.ResumeLayout(false);
            this.hppotion_Panel.ResumeLayout(false);
            this.skill2_Panel.ResumeLayout(false);
            this.skill1_Panel.ResumeLayout(false);
            this.skill3_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.heroicon_pictureBox)).EndInit();
            this.heroinfo_groupBox.ResumeLayout(false);
            this.heroinfo_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enemyicon_pictureBox)).EndInit();
            this.enemyinfo_groupBox.ResumeLayout(false);
            this.enemyinfo_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.enemy_skill1_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.enemy_skill1)).EndInit();
            this.enemy_skill2_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.enemy_skill2)).EndInit();
            this.enemy_skill3_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.enemy_skill3)).EndInit();
            this.enemy_hppotion_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.enemy_hppotion)).EndInit();
            this.reward_panel.ResumeLayout(false);
            this.reward_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cur_item_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reward_potion_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reward_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox nameChoice;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.GroupBox raceChoice;
        private System.Windows.Forms.GroupBox classChoice;
        private System.Windows.Forms.RadioButton mage;
        private System.Windows.Forms.RadioButton ranger;
        private System.Windows.Forms.RadioButton warrior;
        private System.Windows.Forms.RadioButton elf;
        private System.Windows.Forms.RadioButton human;
        private System.Windows.Forms.RadioButton ogre;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Label skill3_CD;
        private System.Windows.Forms.Label skill1_CD;
        private System.Windows.Forms.Label hppotion_counter;
        private System.Windows.Forms.Panel hppotion_Panel;
        private System.Windows.Forms.Button hppotion_Button;
        private System.Windows.Forms.Panel skill2_Panel;
        private System.Windows.Forms.Button skill2_Button;
        private System.Windows.Forms.Panel skill1_Panel;
        private System.Windows.Forms.Button skill1_Button;
        private System.Windows.Forms.Panel skill3_Panel;
        private System.Windows.Forms.Button skill3_Button;
        private System.Windows.Forms.Label event_label;
        private System.Windows.Forms.Label roomfloor_label;
        private System.Windows.Forms.Label skill2_CD;
        private System.Windows.Forms.ProgressBar heromp_Bar;
        private System.Windows.Forms.ProgressBar herohp_Bar;
        private System.Windows.Forms.Label herolvl_label;
        private System.Windows.Forms.Label heroname_label;
        private System.Windows.Forms.PictureBox heroicon_pictureBox;
        private System.Windows.Forms.GroupBox heroinfo_groupBox;
        private System.Windows.Forms.ProgressBar enemymp_Bar;
        private System.Windows.Forms.ProgressBar enemyhp_Bar;
        private System.Windows.Forms.Label enemylvl_label;
        private System.Windows.Forms.Label enemyname_label;
        private System.Windows.Forms.PictureBox enemyicon_pictureBox;
        private System.Windows.Forms.GroupBox enemyinfo_groupBox;
        private System.Windows.Forms.Label herohp_label;
        private System.Windows.Forms.Label heromp_label;
        private System.Windows.Forms.Label enemyhp_label;
        private System.Windows.Forms.Label enemymp_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer enemy_turn_timer;
        private System.Windows.Forms.Button skip_button;
        private System.Windows.Forms.Label turn_indicator;
        private System.Windows.Forms.Label scnd_event_label;
        private System.Windows.Forms.Label thrd_event_label;
        private System.Windows.Forms.Panel enemy_skill1_panel;
        private System.Windows.Forms.Label enemy_skill1_CD;
        private System.Windows.Forms.Label enemy_skill2_CD;
        private System.Windows.Forms.Panel enemy_skill2_panel;
        private System.Windows.Forms.Label enemy_skill3_CD;
        private System.Windows.Forms.Panel enemy_skill3_panel;
        private System.Windows.Forms.Label enemy_hppotion_counter;
        private System.Windows.Forms.Panel enemy_hppotion_panel;
        private System.Windows.Forms.PictureBox enemy_skill1;
        private System.Windows.Forms.PictureBox enemy_skill2;
        private System.Windows.Forms.PictureBox enemy_skill3;
        private System.Windows.Forms.PictureBox enemy_hppotion;
        private System.Windows.Forms.Timer hero_win_timer;
        private System.Windows.Forms.Timer afterbattle_interval_timer;
        private System.Windows.Forms.Panel reward_panel;
        private System.Windows.Forms.Button equip_button;
        private System.Windows.Forms.Button cancel_equip_button;
        private System.Windows.Forms.PictureBox reward_image;
        private System.Windows.Forms.Label exp_changes;
        private System.Windows.Forms.Label earned_exp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox reward_potion_image;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox cur_item_image;
        private System.Windows.Forms.ProgressBar hero_xp_bar;
        private System.Windows.Forms.ProgressBar enemy_xp_bar;
        private System.Windows.Forms.ProgressBar hero_changed_xp_bar;
        private System.Windows.Forms.Label afterbattle_label;
    }
}

