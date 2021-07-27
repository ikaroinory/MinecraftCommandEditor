
namespace Minecraft_Command_Editor
{
    partial class Settings
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
            this.tabControl_Settings = new System.Windows.Forms.TabControl();
            this.tabPage_General = new System.Windows.Forms.TabPage();
            this.ComboBox_DisplayLang = new System.Windows.Forms.ComboBox();
            this.label_DisplayLang = new System.Windows.Forms.Label();
            this.tabPage_SupportLib = new System.Windows.Forms.TabPage();
            this.tabControl_Settings.SuspendLayout();
            this.tabPage_General.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_Settings
            // 
            this.tabControl_Settings.Controls.Add(this.tabPage_General);
            this.tabControl_Settings.Controls.Add(this.tabPage_SupportLib);
            this.tabControl_Settings.Location = new System.Drawing.Point(12, 12);
            this.tabControl_Settings.Multiline = true;
            this.tabControl_Settings.Name = "tabControl_Settings";
            this.tabControl_Settings.SelectedIndex = 0;
            this.tabControl_Settings.Size = new System.Drawing.Size(480, 324);
            this.tabControl_Settings.TabIndex = 0;
            // 
            // tabPage_General
            // 
            this.tabPage_General.Controls.Add(this.ComboBox_DisplayLang);
            this.tabPage_General.Controls.Add(this.label_DisplayLang);
            this.tabPage_General.Location = new System.Drawing.Point(4, 26);
            this.tabPage_General.Name = "tabPage_General";
            this.tabPage_General.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_General.Size = new System.Drawing.Size(472, 294);
            this.tabPage_General.TabIndex = 0;
            this.tabPage_General.Text = "General";
            this.tabPage_General.UseVisualStyleBackColor = true;
            // 
            // ComboBox_DisplayLang
            // 
            this.ComboBox_DisplayLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_DisplayLang.FormattingEnabled = true;
            this.ComboBox_DisplayLang.Location = new System.Drawing.Point(26, 54);
            this.ComboBox_DisplayLang.Name = "ComboBox_DisplayLang";
            this.ComboBox_DisplayLang.Size = new System.Drawing.Size(420, 25);
            this.ComboBox_DisplayLang.TabIndex = 3;
            this.ComboBox_DisplayLang.DropDownClosed += new System.EventHandler(this.comboBox_DisplayLang_DropDownClosed);
            // 
            // label_DisplayLang
            // 
            this.label_DisplayLang.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_DisplayLang.Location = new System.Drawing.Point(26, 26);
            this.label_DisplayLang.Name = "label_DisplayLang";
            this.label_DisplayLang.Size = new System.Drawing.Size(420, 25);
            this.label_DisplayLang.TabIndex = 2;
            this.label_DisplayLang.Text = "Display Language:";
            this.label_DisplayLang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage_SupportLib
            // 
            this.tabPage_SupportLib.Location = new System.Drawing.Point(4, 26);
            this.tabPage_SupportLib.Name = "tabPage_SupportLib";
            this.tabPage_SupportLib.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_SupportLib.Size = new System.Drawing.Size(472, 294);
            this.tabPage_SupportLib.TabIndex = 1;
            this.tabPage_SupportLib.Text = "Support Library";
            this.tabPage_SupportLib.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 348);
            this.Controls.Add(this.tabControl_Settings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings - Minecraft Command Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Settings_FormClosed);
            this.tabControl_Settings.ResumeLayout(false);
            this.tabPage_General.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Settings;
        private System.Windows.Forms.TabPage tabPage_General;
        private System.Windows.Forms.TabPage tabPage_SupportLib;
        private System.Windows.Forms.Label label_DisplayLang;
        private System.Windows.Forms.ComboBox ComboBox_DisplayLang;
    }
}