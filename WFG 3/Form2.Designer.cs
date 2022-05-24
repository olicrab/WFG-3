
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
            this.reward_panel = new System.Windows.Forms.Panel();
            this.reward_description = new System.Windows.Forms.Label();
            this.equip_button = new System.Windows.Forms.Button();
            this.cancel_equip_button = new System.Windows.Forms.Button();
            this.reward_image = new System.Windows.Forms.PictureBox();
            this.exp_changes = new System.Windows.Forms.Label();
            this.earned_exp = new System.Windows.Forms.Label();
            this.reward_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reward_image)).BeginInit();
            this.SuspendLayout();
            // 
            // reward_panel
            // 
            this.reward_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.reward_panel.Controls.Add(this.reward_description);
            this.reward_panel.Controls.Add(this.equip_button);
            this.reward_panel.Controls.Add(this.cancel_equip_button);
            this.reward_panel.Controls.Add(this.reward_image);
            this.reward_panel.Controls.Add(this.exp_changes);
            this.reward_panel.Controls.Add(this.earned_exp);
            this.reward_panel.Location = new System.Drawing.Point(141, 37);
            this.reward_panel.Name = "reward_panel";
            this.reward_panel.Size = new System.Drawing.Size(499, 496);
            this.reward_panel.TabIndex = 0;
            // 
            // reward_description
            // 
            this.reward_description.AutoSize = true;
            this.reward_description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.reward_description.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reward_description.ForeColor = System.Drawing.Color.Firebrick;
            this.reward_description.Location = new System.Drawing.Point(222, 213);
            this.reward_description.Name = "reward_description";
            this.reward_description.Size = new System.Drawing.Size(0, 16);
            this.reward_description.TabIndex = 65;
            this.reward_description.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // 
            // cancel_equip_button
            // 
            this.cancel_equip_button.BackColor = System.Drawing.Color.Linen;
            this.cancel_equip_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancel_equip_button.Font = new System.Drawing.Font("NSimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_equip_button.ForeColor = System.Drawing.Color.Brown;
            this.cancel_equip_button.Location = new System.Drawing.Point(306, 417);
            this.cancel_equip_button.Name = "cancel_equip_button";
            this.cancel_equip_button.Size = new System.Drawing.Size(150, 50);
            this.cancel_equip_button.TabIndex = 63;
            this.cancel_equip_button.Text = "Cancel";
            this.cancel_equip_button.UseVisualStyleBackColor = false;
            // 
            // reward_image
            // 
            this.reward_image.Location = new System.Drawing.Point(44, 213);
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
            this.exp_changes.Location = new System.Drawing.Point(0, 53);
            this.exp_changes.Name = "exp_changes";
            this.exp_changes.Size = new System.Drawing.Size(499, 129);
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
            this.earned_exp.Size = new System.Drawing.Size(499, 52);
            this.earned_exp.TabIndex = 60;
            this.earned_exp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WFG_3.Properties.Resources.Dungeon_Background_OCWIP_PixelArt;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.reward_panel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("NSimSun", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.reward_panel.ResumeLayout(false);
            this.reward_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reward_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel reward_panel;
        private System.Windows.Forms.Label reward_description;
        private System.Windows.Forms.Button equip_button;
        private System.Windows.Forms.Button cancel_equip_button;
        private System.Windows.Forms.PictureBox reward_image;
        private System.Windows.Forms.Label exp_changes;
        private System.Windows.Forms.Label earned_exp;
    }
}