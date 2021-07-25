
namespace Minecraft_Command_Editor
{
    partial class Homepage
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
            this.panel_Settings = new System.Windows.Forms.Panel();
            this.label_Settings = new System.Windows.Forms.Label();
            this.pictureBox_Settings = new System.Windows.Forms.PictureBox();
            this.panel_GiveItems = new System.Windows.Forms.Panel();
            this.label_GiveItems = new System.Windows.Forms.Label();
            this.pictureBox_GiveItems = new System.Windows.Forms.PictureBox();
            this.panel_Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Settings)).BeginInit();
            this.panel_GiveItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_GiveItems)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Settings
            // 
            this.panel_Settings.BackColor = System.Drawing.Color.White;
            this.panel_Settings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Settings.Controls.Add(this.label_Settings);
            this.panel_Settings.Controls.Add(this.pictureBox_Settings);
            this.panel_Settings.Location = new System.Drawing.Point(13, 80);
            this.panel_Settings.Name = "panel_Settings";
            this.panel_Settings.Size = new System.Drawing.Size(152, 62);
            this.panel_Settings.TabIndex = 0;
            // 
            // label_Settings
            // 
            this.label_Settings.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Settings.Location = new System.Drawing.Point(58, 30);
            this.label_Settings.Name = "label_Settings";
            this.label_Settings.Size = new System.Drawing.Size(94, 21);
            this.label_Settings.TabIndex = 1;
            this.label_Settings.Text = "Settings";
            this.label_Settings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Settings.Click += new System.EventHandler(this.LoadSettings);
            // 
            // pictureBox_Settings
            // 
            this.pictureBox_Settings.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Settings.Name = "pictureBox_Settings";
            this.pictureBox_Settings.Size = new System.Drawing.Size(150, 60);
            this.pictureBox_Settings.TabIndex = 0;
            this.pictureBox_Settings.TabStop = false;
            this.pictureBox_Settings.Click += new System.EventHandler(this.LoadSettings);
            // 
            // panel_GiveItems
            // 
            this.panel_GiveItems.BackColor = System.Drawing.Color.White;
            this.panel_GiveItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_GiveItems.Controls.Add(this.label_GiveItems);
            this.panel_GiveItems.Controls.Add(this.pictureBox_GiveItems);
            this.panel_GiveItems.Location = new System.Drawing.Point(12, 12);
            this.panel_GiveItems.Name = "panel_GiveItems";
            this.panel_GiveItems.Size = new System.Drawing.Size(152, 62);
            this.panel_GiveItems.TabIndex = 1;
            // 
            // label_GiveItems
            // 
            this.label_GiveItems.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_GiveItems.Location = new System.Drawing.Point(58, 30);
            this.label_GiveItems.Name = "label_GiveItems";
            this.label_GiveItems.Size = new System.Drawing.Size(94, 21);
            this.label_GiveItems.TabIndex = 1;
            this.label_GiveItems.Text = "GiveItems";
            this.label_GiveItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_GiveItems.Click += new System.EventHandler(this.LoadGiveItems);
            // 
            // pictureBox_GiveItems
            // 
            this.pictureBox_GiveItems.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_GiveItems.Name = "pictureBox_GiveItems";
            this.pictureBox_GiveItems.Size = new System.Drawing.Size(150, 60);
            this.pictureBox_GiveItems.TabIndex = 0;
            this.pictureBox_GiveItems.TabStop = false;
            this.pictureBox_GiveItems.Click += new System.EventHandler(this.LoadGiveItems);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(526, 179);
            this.Controls.Add(this.panel_GiveItems);
            this.Controls.Add(this.panel_Settings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minecraft Command Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Homepage_FormClosed);
            this.panel_Settings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Settings)).EndInit();
            this.panel_GiveItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_GiveItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Settings;
        private System.Windows.Forms.PictureBox pictureBox_Settings;
        private System.Windows.Forms.Label label_Settings;
        private System.Windows.Forms.Panel panel_GiveItems;
        private System.Windows.Forms.Label label_GiveItems;
        private System.Windows.Forms.PictureBox pictureBox_GiveItems;
    }
}