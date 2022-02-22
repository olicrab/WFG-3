
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
            this.mppotion_counter = new System.Windows.Forms.Label();
            this.hppotion_counter = new System.Windows.Forms.Label();
            this.mppotion_Panel = new System.Windows.Forms.Panel();
            this.mppotion_Button = new System.Windows.Forms.Button();
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
            this.enemymp_Bar = new System.Windows.Forms.ProgressBar();
            this.enemyhp_Bar = new System.Windows.Forms.ProgressBar();
            this.enemylvl_label = new System.Windows.Forms.Label();
            this.enemyname_label = new System.Windows.Forms.Label();
            this.enemyicon_pictureBox = new System.Windows.Forms.PictureBox();
            this.enemyinfo_groupBox = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.nameChoice.SuspendLayout();
            this.raceChoice.SuspendLayout();
            this.classChoice.SuspendLayout();
            this.mppotion_Panel.SuspendLayout();
            this.hppotion_Panel.SuspendLayout();
            this.skill2_Panel.SuspendLayout();
            this.skill1_Panel.SuspendLayout();
            this.skill3_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heroicon_pictureBox)).BeginInit();
            this.heroinfo_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enemyicon_pictureBox)).BeginInit();
            this.enemyinfo_groupBox.SuspendLayout();
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
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
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
            this.nameChoice.ForeColor = System.Drawing.Color.Maroon;
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
            this.raceChoice.ForeColor = System.Drawing.Color.Maroon;
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
            this.elf.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elf.ForeColor = System.Drawing.Color.Black;
            this.elf.Location = new System.Drawing.Point(6, 164);
            this.elf.Name = "elf";
            this.elf.Size = new System.Drawing.Size(95, 35);
            this.elf.TabIndex = 5;
            this.elf.Text = "Elf";
            this.elf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.elf.UseVisualStyleBackColor = true;
            this.elf.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.elf.MouseEnter += new System.EventHandler(this.radiobutton_MouseEnter);
            this.elf.MouseLeave += new System.EventHandler(this.radiobutton_MouseLeave);
            // 
            // human
            // 
            this.human.Appearance = System.Windows.Forms.Appearance.Button;
            this.human.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.human.ForeColor = System.Drawing.Color.Black;
            this.human.Location = new System.Drawing.Point(6, 96);
            this.human.Name = "human";
            this.human.Size = new System.Drawing.Size(95, 35);
            this.human.TabIndex = 4;
            this.human.Text = "Human";
            this.human.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.human.UseVisualStyleBackColor = true;
            this.human.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.human.MouseEnter += new System.EventHandler(this.radiobutton_MouseEnter);
            this.human.MouseLeave += new System.EventHandler(this.radiobutton_MouseLeave);
            // 
            // ogre
            // 
            this.ogre.Appearance = System.Windows.Forms.Appearance.Button;
            this.ogre.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ogre.ForeColor = System.Drawing.Color.Black;
            this.ogre.Location = new System.Drawing.Point(6, 24);
            this.ogre.Name = "ogre";
            this.ogre.Size = new System.Drawing.Size(95, 35);
            this.ogre.TabIndex = 3;
            this.ogre.Text = "Ogre";
            this.ogre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ogre.UseVisualStyleBackColor = true;
            this.ogre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.ogre.MouseEnter += new System.EventHandler(this.radiobutton_MouseEnter);
            this.ogre.MouseLeave += new System.EventHandler(this.radiobutton_MouseLeave);
            // 
            // classChoice
            // 
            this.classChoice.Controls.Add(this.mage);
            this.classChoice.Controls.Add(this.ranger);
            this.classChoice.Controls.Add(this.warrior);
            this.classChoice.ForeColor = System.Drawing.Color.Maroon;
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
            this.mage.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mage.ForeColor = System.Drawing.Color.Black;
            this.mage.Location = new System.Drawing.Point(6, 164);
            this.mage.Name = "mage";
            this.mage.Size = new System.Drawing.Size(95, 35);
            this.mage.TabIndex = 2;
            this.mage.Text = "Mage";
            this.mage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mage.UseVisualStyleBackColor = true;
            this.mage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.mage.MouseEnter += new System.EventHandler(this.radiobutton_MouseEnter);
            this.mage.MouseLeave += new System.EventHandler(this.radiobutton_MouseLeave);
            // 
            // ranger
            // 
            this.ranger.Appearance = System.Windows.Forms.Appearance.Button;
            this.ranger.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ranger.ForeColor = System.Drawing.Color.Black;
            this.ranger.Location = new System.Drawing.Point(6, 96);
            this.ranger.Name = "ranger";
            this.ranger.Size = new System.Drawing.Size(95, 35);
            this.ranger.TabIndex = 1;
            this.ranger.Text = "Ranger";
            this.ranger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ranger.UseVisualStyleBackColor = true;
            this.ranger.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.ranger.MouseEnter += new System.EventHandler(this.radiobutton_MouseEnter);
            this.ranger.MouseLeave += new System.EventHandler(this.radiobutton_MouseLeave);
            // 
            // warrior
            // 
            this.warrior.Appearance = System.Windows.Forms.Appearance.Button;
            this.warrior.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warrior.ForeColor = System.Drawing.Color.Black;
            this.warrior.Location = new System.Drawing.Point(6, 24);
            this.warrior.Name = "warrior";
            this.warrior.Size = new System.Drawing.Size(95, 35);
            this.warrior.TabIndex = 0;
            this.warrior.Text = "Warrior";
            this.warrior.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.warrior.UseVisualStyleBackColor = true;
            this.warrior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.warrior.MouseEnter += new System.EventHandler(this.radiobutton_MouseEnter);
            this.warrior.MouseLeave += new System.EventHandler(this.radiobutton_MouseLeave);
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
            // mppotion_counter
            // 
            this.mppotion_counter.AutoSize = true;
            this.mppotion_counter.BackColor = System.Drawing.Color.Transparent;
            this.mppotion_counter.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mppotion_counter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mppotion_counter.Location = new System.Drawing.Point(143, 448);
            this.mppotion_counter.Name = "mppotion_counter";
            this.mppotion_counter.Size = new System.Drawing.Size(16, 16);
            this.mppotion_counter.TabIndex = 34;
            this.mppotion_counter.Text = "0";
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
            // mppotion_Panel
            // 
            this.mppotion_Panel.BackColor = System.Drawing.Color.Transparent;
            this.mppotion_Panel.Controls.Add(this.mppotion_Button);
            this.mppotion_Panel.Location = new System.Drawing.Point(95, 381);
            this.mppotion_Panel.Name = "mppotion_Panel";
            this.mppotion_Panel.Size = new System.Drawing.Size(64, 64);
            this.mppotion_Panel.TabIndex = 31;
            // 
            // mppotion_Button
            // 
            this.mppotion_Button.Location = new System.Drawing.Point(0, 0);
            this.mppotion_Button.Name = "mppotion_Button";
            this.mppotion_Button.Size = new System.Drawing.Size(64, 64);
            this.mppotion_Button.TabIndex = 10;
            this.mppotion_Button.UseVisualStyleBackColor = true;
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
            // 
            // skill2_Panel
            // 
            this.skill2_Panel.BackColor = System.Drawing.Color.Transparent;
            this.skill2_Panel.Controls.Add(this.skill2_Button);
            this.skill2_Panel.Location = new System.Drawing.Point(617, 381);
            this.skill2_Panel.Name = "skill2_Panel";
            this.skill2_Panel.Size = new System.Drawing.Size(64, 64);
            this.skill2_Panel.TabIndex = 29;
            // 
            // skill2_Button
            // 
            this.skill2_Button.Location = new System.Drawing.Point(3, 0);
            this.skill2_Button.Name = "skill2_Button";
            this.skill2_Button.Size = new System.Drawing.Size(64, 64);
            this.skill2_Button.TabIndex = 7;
            this.skill2_Button.UseVisualStyleBackColor = true;
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
            this.skill3_Button.Location = new System.Drawing.Point(-1, 0);
            this.skill3_Button.Name = "skill3_Button";
            this.skill3_Button.Size = new System.Drawing.Size(64, 64);
            this.skill3_Button.TabIndex = 8;
            this.skill3_Button.UseVisualStyleBackColor = true;
            // 
            // event_label
            // 
            this.event_label.AutoSize = true;
            this.event_label.Location = new System.Drawing.Point(340, 406);
            this.event_label.Name = "event_label";
            this.event_label.Size = new System.Drawing.Size(55, 15);
            this.event_label.TabIndex = 27;
            this.event_label.Text = "label6";
            // 
            // roomfloor_label
            // 
            this.roomfloor_label.BackColor = System.Drawing.Color.Transparent;
            this.roomfloor_label.Font = new System.Drawing.Font("NSimSun", 20.25F);
            this.roomfloor_label.ForeColor = System.Drawing.Color.Maroon;
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
            this.skill2_CD.Location = new System.Drawing.Point(614, 362);
            this.skill2_CD.Name = "skill2_CD";
            this.skill2_CD.Size = new System.Drawing.Size(16, 16);
            this.skill2_CD.TabIndex = 36;
            this.skill2_CD.Text = "0";
            // 
            // heromp_Bar
            // 
            this.heromp_Bar.BackColor = System.Drawing.Color.Cyan;
            this.heromp_Bar.Location = new System.Drawing.Point(12, 517);
            this.heromp_Bar.Name = "heromp_Bar";
            this.heromp_Bar.Size = new System.Drawing.Size(518, 23);
            this.heromp_Bar.TabIndex = 25;
            // 
            // herohp_Bar
            // 
            this.herohp_Bar.BackColor = System.Drawing.Color.LimeGreen;
            this.herohp_Bar.Location = new System.Drawing.Point(12, 488);
            this.herohp_Bar.Name = "herohp_Bar";
            this.herohp_Bar.Size = new System.Drawing.Size(518, 23);
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
            // enemymp_Bar
            // 
            this.enemymp_Bar.BackColor = System.Drawing.Color.Blue;
            this.enemymp_Bar.Location = new System.Drawing.Point(253, 68);
            this.enemymp_Bar.Name = "enemymp_Bar";
            this.enemymp_Bar.Size = new System.Drawing.Size(518, 23);
            this.enemymp_Bar.TabIndex = 22;
            // 
            // enemyhp_Bar
            // 
            this.enemyhp_Bar.BackColor = System.Drawing.Color.LimeGreen;
            this.enemyhp_Bar.Location = new System.Drawing.Point(254, 40);
            this.enemyhp_Bar.Name = "enemyhp_Bar";
            this.enemyhp_Bar.Size = new System.Drawing.Size(518, 23);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.skill3_CD);
            this.Controls.Add(this.skill1_CD);
            this.Controls.Add(this.mppotion_counter);
            this.Controls.Add(this.hppotion_counter);
            this.Controls.Add(this.mppotion_Panel);
            this.Controls.Add(this.hppotion_Panel);
            this.Controls.Add(this.skill2_Panel);
            this.Controls.Add(this.skill1_Panel);
            this.Controls.Add(this.skill3_Panel);
            this.Controls.Add(this.event_label);
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
            this.mppotion_Panel.ResumeLayout(false);
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
        private System.Windows.Forms.Label mppotion_counter;
        private System.Windows.Forms.Label hppotion_counter;
        private System.Windows.Forms.Panel mppotion_Panel;
        private System.Windows.Forms.Button mppotion_Button;
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
    }
}

