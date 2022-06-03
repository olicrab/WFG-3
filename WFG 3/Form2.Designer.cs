
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.hitten_picture = new System.Windows.Forms.PictureBox();
            this.hit_picture = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hitten_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hit_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.hitten_picture);
            this.panel3.Controls.Add(this.hit_picture);
            this.panel3.Location = new System.Drawing.Point(242, 130);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 300);
            this.panel3.TabIndex = 44;
            // 
            // hitten_picture
            // 
            this.hitten_picture.Location = new System.Drawing.Point(184, 134);
            this.hitten_picture.Name = "hitten_picture";
            this.hitten_picture.Size = new System.Drawing.Size(64, 64);
            this.hitten_picture.TabIndex = 45;
            this.hitten_picture.TabStop = false;
            // 
            // hit_picture
            // 
            this.hit_picture.Image = global::WFG_3.Properties.Resources.Z0Bl;
            this.hit_picture.Location = new System.Drawing.Point(64, 115);
            this.hit_picture.Name = "hit_picture";
            this.hit_picture.Size = new System.Drawing.Size(114, 98);
            this.hit_picture.TabIndex = 44;
            this.hit_picture.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WFG_3.Properties.Resources.Dungeon_Background_OCWIP_PixelArt;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel3);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("NSimSun", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hitten_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hit_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox hitten_picture;
        private System.Windows.Forms.PictureBox hit_picture;
    }
}