
namespace Music_Player
{
    partial class Music_player_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Music_player_Form));
            this.Top_panel = new System.Windows.Forms.Panel();
            this.Icon_Picture = new System.Windows.Forms.PictureBox();
            this.Close_btn = new System.Windows.Forms.PictureBox();
            this.Top_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // Top_panel
            // 
            this.Top_panel.BackColor = System.Drawing.Color.Black;
            this.Top_panel.Controls.Add(this.Close_btn);
            this.Top_panel.Controls.Add(this.Icon_Picture);
            this.Top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_panel.Location = new System.Drawing.Point(0, 0);
            this.Top_panel.Name = "Top_panel";
            this.Top_panel.Size = new System.Drawing.Size(800, 29);
            this.Top_panel.TabIndex = 0;
            // 
            // Icon_Picture
            // 
            this.Icon_Picture.Image = ((System.Drawing.Image)(resources.GetObject("Icon_Picture.Image")));
            this.Icon_Picture.Location = new System.Drawing.Point(3, 0);
            this.Icon_Picture.Name = "Icon_Picture";
            this.Icon_Picture.Size = new System.Drawing.Size(36, 26);
            this.Icon_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Icon_Picture.TabIndex = 0;
            this.Icon_Picture.TabStop = false;
            // 
            // Close_btn
            // 
            this.Close_btn.Image = ((System.Drawing.Image)(resources.GetObject("Close_btn.Image")));
            this.Close_btn.Location = new System.Drawing.Point(759, 3);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(41, 22);
            this.Close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close_btn.TabIndex = 1;
            this.Close_btn.TabStop = false;
            this.Close_btn.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Music_player_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Top_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Music_player_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Player";
            this.Top_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_btn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Top_panel;
        private System.Windows.Forms.PictureBox Icon_Picture;
        private System.Windows.Forms.PictureBox Close_btn;
    }
}

