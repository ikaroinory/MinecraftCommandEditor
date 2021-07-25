
namespace Minecraft_Command_Editor
{
    partial class Loading
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
            this.pictureBox_MCE = new System.Windows.Forms.PictureBox();
            this.label_Title = new System.Windows.Forms.Label();
            this.label_Ver = new System.Windows.Forms.Label();
            this.label_LoadingInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MCE)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_MCE
            // 
            this.pictureBox_MCE.Location = new System.Drawing.Point(50, 50);
            this.pictureBox_MCE.Name = "pictureBox_MCE";
            this.pictureBox_MCE.Size = new System.Drawing.Size(160, 160);
            this.pictureBox_MCE.TabIndex = 0;
            this.pictureBox_MCE.TabStop = false;
            // 
            // label_Title
            // 
            this.label_Title.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Title.Location = new System.Drawing.Point(260, 80);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(281, 50);
            this.label_Title.TabIndex = 1;
            this.label_Title.Text = "Minecraft Command Editor";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Ver
            // 
            this.label_Ver.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Ver.Location = new System.Drawing.Point(400, 185);
            this.label_Ver.Name = "label_Ver";
            this.label_Ver.Size = new System.Drawing.Size(160, 25);
            this.label_Ver.TabIndex = 2;
            this.label_Ver.Text = "2021";
            this.label_Ver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_LoadingInfo
            // 
            this.label_LoadingInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_LoadingInfo.Location = new System.Drawing.Point(0, 242);
            this.label_LoadingInfo.Name = "label_LoadingInfo";
            this.label_LoadingInfo.Size = new System.Drawing.Size(610, 18);
            this.label_LoadingInfo.TabIndex = 3;
            this.label_LoadingInfo.Text = "Creating initialization process......";
            this.label_LoadingInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(610, 260);
            this.Controls.Add(this.label_LoadingInfo);
            this.Controls.Add(this.label_Ver);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.pictureBox_MCE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Loading";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading - Minecraft Command Editor";
            this.Shown += new System.EventHandler(this.Loading_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MCE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_MCE;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_Ver;
        private System.Windows.Forms.Label label_LoadingInfo;
    }
}