
namespace WFG_3
{
    partial class Form2
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
            this.enemyinfo_groupBox = new System.Windows.Forms.GroupBox();
            this.enemylvl_label = new System.Windows.Forms.Label();
            this.enemyname_label = new System.Windows.Forms.Label();
            this.enemyicon_pictureBox = new System.Windows.Forms.PictureBox();
            this.enemyhp_Bar = new System.Windows.Forms.ProgressBar();
            this.enemymp_Bar = new System.Windows.Forms.ProgressBar();
            this.heroinfo_groupBox = new System.Windows.Forms.GroupBox();
            this.herolvl_label = new System.Windows.Forms.Label();
            this.heroname_label = new System.Windows.Forms.Label();
            this.heroicon_pictureBox = new System.Windows.Forms.PictureBox();
            this.herohp_Bar = new System.Windows.Forms.ProgressBar();
            this.heromp_Bar = new System.Windows.Forms.ProgressBar();
            this.skill1_Button = new System.Windows.Forms.Button();
            this.skill2_Button = new System.Windows.Forms.Button();
            this.skill3_Button = new System.Windows.Forms.Button();
            this.hppotion_Button = new System.Windows.Forms.Button();
            this.mppotion_Button = new System.Windows.Forms.Button();
            this.roomfloor_label = new System.Windows.Forms.Label();
            this.event_label = new System.Windows.Forms.Label();
            this.skill3_Panel = new System.Windows.Forms.Panel();
            this.skill1_Panel = new System.Windows.Forms.Panel();
            this.skill2_Panel = new System.Windows.Forms.Panel();
            this.hppotion_Panel = new System.Windows.Forms.Panel();
            this.mppotion_Panel = new System.Windows.Forms.Panel();
            this.hppotion_counter = new System.Windows.Forms.Label();
            this.mppotion_counter = new System.Windows.Forms.Label();
            this.skill1_CD = new System.Windows.Forms.Label();
            this.skill2_CD = new System.Windows.Forms.Label();
            this.skill3_CD = new System.Windows.Forms.Label();
            this.enemyinfo_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enemyicon_pictureBox)).BeginInit();
            this.heroinfo_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heroicon_pictureBox)).BeginInit();
            this.skill3_Panel.SuspendLayout();
            this.skill1_Panel.SuspendLayout();
            this.skill2_Panel.SuspendLayout();
            this.hppotion_Panel.SuspendLayout();
            this.mppotion_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // enemyinfo_groupBox
            // 
            this.enemyinfo_groupBox.BackColor = System.Drawing.Color.Transparent;
            this.enemyinfo_groupBox.Controls.Add(this.enemylvl_label);
            this.enemyinfo_groupBox.Controls.Add(this.enemyname_label);
            this.enemyinfo_groupBox.Controls.Add(this.enemyicon_pictureBox);
            this.enemyinfo_groupBox.ForeColor = System.Drawing.Color.Maroon;
            this.enemyinfo_groupBox.Location = new System.Drawing.Point(13, 13);
            this.enemyinfo_groupBox.Name = "enemyinfo_groupBox";
            this.enemyinfo_groupBox.Size = new System.Drawing.Size(234, 100);
            this.enemyinfo_groupBox.TabIndex = 0;
            this.enemyinfo_groupBox.TabStop = false;
            this.enemyinfo_groupBox.Text = "Enemy";
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
            // enemyhp_Bar
            // 
            this.enemyhp_Bar.Location = new System.Drawing.Point(254, 38);
            this.enemyhp_Bar.Name = "enemyhp_Bar";
            this.enemyhp_Bar.Size = new System.Drawing.Size(518, 23);
            this.enemyhp_Bar.TabIndex = 1;
            // 
            // enemymp_Bar
            // 
            this.enemymp_Bar.Location = new System.Drawing.Point(253, 66);
            this.enemymp_Bar.Name = "enemymp_Bar";
            this.enemymp_Bar.Size = new System.Drawing.Size(518, 23);
            this.enemymp_Bar.TabIndex = 2;
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
            this.heroinfo_groupBox.Location = new System.Drawing.Point(538, 449);
            this.heroinfo_groupBox.Name = "heroinfo_groupBox";
            this.heroinfo_groupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.heroinfo_groupBox.Size = new System.Drawing.Size(234, 100);
            this.heroinfo_groupBox.TabIndex = 3;
            this.heroinfo_groupBox.TabStop = false;
            this.heroinfo_groupBox.Text = "Hero";
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
            // herohp_Bar
            // 
            this.herohp_Bar.Location = new System.Drawing.Point(12, 486);
            this.herohp_Bar.Name = "herohp_Bar";
            this.herohp_Bar.Size = new System.Drawing.Size(518, 23);
            this.herohp_Bar.TabIndex = 4;
            // 
            // heromp_Bar
            // 
            this.heromp_Bar.Location = new System.Drawing.Point(12, 515);
            this.heromp_Bar.Name = "heromp_Bar";
            this.heromp_Bar.Size = new System.Drawing.Size(518, 23);
            this.heromp_Bar.TabIndex = 5;
            // 
            // skill1_Button
            // 
            this.skill1_Button.Location = new System.Drawing.Point(0, 0);
            this.skill1_Button.Name = "skill1_Button";
            this.skill1_Button.Size = new System.Drawing.Size(64, 64);
            this.skill1_Button.TabIndex = 6;
            this.skill1_Button.Text = "button1";
            this.skill1_Button.UseVisualStyleBackColor = true;
            // 
            // skill2_Button
            // 
            this.skill2_Button.Location = new System.Drawing.Point(3, 0);
            this.skill2_Button.Name = "skill2_Button";
            this.skill2_Button.Size = new System.Drawing.Size(64, 64);
            this.skill2_Button.TabIndex = 7;
            this.skill2_Button.Text = "button2";
            this.skill2_Button.UseVisualStyleBackColor = true;
            // 
            // skill3_Button
            // 
            this.skill3_Button.Location = new System.Drawing.Point(-1, 0);
            this.skill3_Button.Name = "skill3_Button";
            this.skill3_Button.Size = new System.Drawing.Size(64, 64);
            this.skill3_Button.TabIndex = 8;
            this.skill3_Button.Text = "button3";
            this.skill3_Button.UseVisualStyleBackColor = true;
            // 
            // hppotion_Button
            // 
            this.hppotion_Button.Location = new System.Drawing.Point(0, 0);
            this.hppotion_Button.Name = "hppotion_Button";
            this.hppotion_Button.Size = new System.Drawing.Size(64, 64);
            this.hppotion_Button.TabIndex = 9;
            this.hppotion_Button.Text = "button4";
            this.hppotion_Button.UseVisualStyleBackColor = true;
            // 
            // mppotion_Button
            // 
            this.mppotion_Button.Location = new System.Drawing.Point(0, 0);
            this.mppotion_Button.Name = "mppotion_Button";
            this.mppotion_Button.Size = new System.Drawing.Size(64, 64);
            this.mppotion_Button.TabIndex = 10;
            this.mppotion_Button.Text = "button5";
            this.mppotion_Button.UseVisualStyleBackColor = true;
            // 
            // roomfloor_label
            // 
            this.roomfloor_label.AutoSize = true;
            this.roomfloor_label.BackColor = System.Drawing.Color.Transparent;
            this.roomfloor_label.Font = new System.Drawing.Font("NSimSun", 20.25F);
            this.roomfloor_label.ForeColor = System.Drawing.Color.Maroon;
            this.roomfloor_label.Location = new System.Drawing.Point(494, 8);
            this.roomfloor_label.Name = "roomfloor_label";
            this.roomfloor_label.Size = new System.Drawing.Size(278, 27);
            this.roomfloor_label.TabIndex = 11;
            this.roomfloor_label.Text = "FLOOR   5--1   ROOM";
            // 
            // event_label
            // 
            this.event_label.AutoSize = true;
            this.event_label.Location = new System.Drawing.Point(340, 404);
            this.event_label.Name = "event_label";
            this.event_label.Size = new System.Drawing.Size(55, 15);
            this.event_label.TabIndex = 12;
            this.event_label.Text = "label6";
            // 
            // skill3_Panel
            // 
            this.skill3_Panel.BackColor = System.Drawing.Color.Transparent;
            this.skill3_Panel.Controls.Add(this.skill3_Button);
            this.skill3_Panel.Location = new System.Drawing.Point(708, 379);
            this.skill3_Panel.Name = "skill3_Panel";
            this.skill3_Panel.Size = new System.Drawing.Size(64, 64);
            this.skill3_Panel.TabIndex = 13;
            // 
            // skill1_Panel
            // 
            this.skill1_Panel.BackColor = System.Drawing.Color.Transparent;
            this.skill1_Panel.Controls.Add(this.skill1_Button);
            this.skill1_Panel.Location = new System.Drawing.Point(538, 379);
            this.skill1_Panel.Name = "skill1_Panel";
            this.skill1_Panel.Size = new System.Drawing.Size(64, 64);
            this.skill1_Panel.TabIndex = 14;
            // 
            // skill2_Panel
            // 
            this.skill2_Panel.BackColor = System.Drawing.Color.Transparent;
            this.skill2_Panel.Controls.Add(this.skill2_Button);
            this.skill2_Panel.Location = new System.Drawing.Point(617, 379);
            this.skill2_Panel.Name = "skill2_Panel";
            this.skill2_Panel.Size = new System.Drawing.Size(64, 64);
            this.skill2_Panel.TabIndex = 14;
            // 
            // hppotion_Panel
            // 
            this.hppotion_Panel.BackColor = System.Drawing.Color.Transparent;
            this.hppotion_Panel.Controls.Add(this.hppotion_Button);
            this.hppotion_Panel.Location = new System.Drawing.Point(12, 379);
            this.hppotion_Panel.Name = "hppotion_Panel";
            this.hppotion_Panel.Size = new System.Drawing.Size(64, 64);
            this.hppotion_Panel.TabIndex = 14;
            // 
            // mppotion_Panel
            // 
            this.mppotion_Panel.BackColor = System.Drawing.Color.Transparent;
            this.mppotion_Panel.Controls.Add(this.mppotion_Button);
            this.mppotion_Panel.Location = new System.Drawing.Point(95, 379);
            this.mppotion_Panel.Name = "mppotion_Panel";
            this.mppotion_Panel.Size = new System.Drawing.Size(64, 64);
            this.mppotion_Panel.TabIndex = 14;
            // 
            // hppotion_counter
            // 
            this.hppotion_counter.AutoSize = true;
            this.hppotion_counter.BackColor = System.Drawing.Color.Transparent;
            this.hppotion_counter.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hppotion_counter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hppotion_counter.Location = new System.Drawing.Point(60, 446);
            this.hppotion_counter.Name = "hppotion_counter";
            this.hppotion_counter.Size = new System.Drawing.Size(16, 16);
            this.hppotion_counter.TabIndex = 15;
            this.hppotion_counter.Text = "0";
            // 
            // mppotion_counter
            // 
            this.mppotion_counter.AutoSize = true;
            this.mppotion_counter.BackColor = System.Drawing.Color.Transparent;
            this.mppotion_counter.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mppotion_counter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mppotion_counter.Location = new System.Drawing.Point(143, 446);
            this.mppotion_counter.Name = "mppotion_counter";
            this.mppotion_counter.Size = new System.Drawing.Size(16, 16);
            this.mppotion_counter.TabIndex = 16;
            this.mppotion_counter.Text = "0";
            // 
            // skill1_CD
            // 
            this.skill1_CD.AutoSize = true;
            this.skill1_CD.BackColor = System.Drawing.Color.Transparent;
            this.skill1_CD.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skill1_CD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.skill1_CD.Location = new System.Drawing.Point(535, 360);
            this.skill1_CD.Name = "skill1_CD";
            this.skill1_CD.Size = new System.Drawing.Size(16, 16);
            this.skill1_CD.TabIndex = 17;
            this.skill1_CD.Text = "0";
            // 
            // skill2_CD
            // 
            this.skill2_CD.AutoSize = true;
            this.skill2_CD.BackColor = System.Drawing.Color.Transparent;
            this.skill2_CD.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skill2_CD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.skill2_CD.Location = new System.Drawing.Point(614, 360);
            this.skill2_CD.Name = "skill2_CD";
            this.skill2_CD.Size = new System.Drawing.Size(16, 16);
            this.skill2_CD.TabIndex = 18;
            this.skill2_CD.Text = "0";
            // 
            // skill3_CD
            // 
            this.skill3_CD.AutoSize = true;
            this.skill3_CD.BackColor = System.Drawing.Color.Transparent;
            this.skill3_CD.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skill3_CD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.skill3_CD.Location = new System.Drawing.Point(704, 360);
            this.skill3_CD.Name = "skill3_CD";
            this.skill3_CD.Size = new System.Drawing.Size(16, 16);
            this.skill3_CD.TabIndex = 19;
            this.skill3_CD.Text = "0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WFG_3.Properties.Resources.Dungeon_Background_OCWIP_PixelArt;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.skill3_CD);
            this.Controls.Add(this.skill2_CD);
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
            this.Controls.Add(this.heromp_Bar);
            this.Controls.Add(this.herohp_Bar);
            this.Controls.Add(this.heroinfo_groupBox);
            this.Controls.Add(this.enemymp_Bar);
            this.Controls.Add(this.enemyhp_Bar);
            this.Controls.Add(this.enemyinfo_groupBox);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("NSimSun", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.enemyinfo_groupBox.ResumeLayout(false);
            this.enemyinfo_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enemyicon_pictureBox)).EndInit();
            this.heroinfo_groupBox.ResumeLayout(false);
            this.heroinfo_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heroicon_pictureBox)).EndInit();
            this.skill3_Panel.ResumeLayout(false);
            this.skill1_Panel.ResumeLayout(false);
            this.skill2_Panel.ResumeLayout(false);
            this.hppotion_Panel.ResumeLayout(false);
            this.mppotion_Panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox enemyinfo_groupBox;
        private System.Windows.Forms.PictureBox enemyicon_pictureBox;
        private System.Windows.Forms.Label enemylvl_label;
        private System.Windows.Forms.Label enemyname_label;
        private System.Windows.Forms.ProgressBar enemyhp_Bar;
        private System.Windows.Forms.ProgressBar enemymp_Bar;
        private System.Windows.Forms.GroupBox heroinfo_groupBox;
        private System.Windows.Forms.Label herolvl_label;
        private System.Windows.Forms.Label heroname_label;
        private System.Windows.Forms.PictureBox heroicon_pictureBox;
        private System.Windows.Forms.ProgressBar herohp_Bar;
        private System.Windows.Forms.ProgressBar heromp_Bar;
        private System.Windows.Forms.Button skill1_Button;
        private System.Windows.Forms.Button skill2_Button;
        private System.Windows.Forms.Button skill3_Button;
        private System.Windows.Forms.Button hppotion_Button;
        private System.Windows.Forms.Button mppotion_Button;
        private System.Windows.Forms.Label roomfloor_label;
        private System.Windows.Forms.Label event_label;
        private System.Windows.Forms.Panel skill3_Panel;
        private System.Windows.Forms.Panel skill1_Panel;
        private System.Windows.Forms.Panel skill2_Panel;
        private System.Windows.Forms.Panel hppotion_Panel;
        private System.Windows.Forms.Panel mppotion_Panel;
        private System.Windows.Forms.Label hppotion_counter;
        private System.Windows.Forms.Label mppotion_counter;
        private System.Windows.Forms.Label skill1_CD;
        private System.Windows.Forms.Label skill2_CD;
        private System.Windows.Forms.Label skill3_CD;
    }
}