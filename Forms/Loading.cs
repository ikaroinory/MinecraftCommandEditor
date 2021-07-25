using System;
using System.Drawing;
using System.Windows.Forms;

using Functions.System;
using JsonParser;

namespace Minecraft_Command_Editor
{
    public partial class Loading : Form
    {
        readonly Json lang = new JsonFile(FilePath.lang);


        public Loading()
        {
            InitializeComponent();

            this.Cursor = Cursors.AppStarting;                                      // 设置光标类型
            this.pictureBox_MCE.Image = Image.FromFile(FilePath.gifMCE);                // 插入图片

            LoadLang();
        }

        private void LoadLang()
        {
            this.Text= lang.GetValue("Form", "Loading", "Title").Value.ToString();
            label_LoadingInfo.Text = lang.GetValue("Info", "Loading", "CreateInitProcess").Value.ToString();
        }

        private void Loading_Shown(object sender, EventArgs e)
        {
            Process.ThreadDelay(256);
            this.label_LoadingInfo.Text = lang.GetValue("Info", "Loading", "LoadingLangFile").Value.ToString();
            Process.ThreadDelay(512);
            this.label_LoadingInfo.Text = lang.GetValue("Info", "Loading", "LoadingGiveItems_accdb").Value.ToString();
            Process.ThreadDelay(512);
            this.Close();
            /*
            if (File.Exists(FilePath.Config) == false)
            {
                string text
                    = "Code：System1001\r\n\r\n"
                    + "Description: \r\n"
                    + "The exception that is thrown when an attempt to access a file that does not exist on disk fails.\r\n\r\n"
                    + "Target: " + FilePath.Config;
                string caption = "Error";
                string[] btnT = { "OK" };
                Json info = new Json();
                info.InitializeFromText(Resource.zh_cn.ToString());
                info.GetValue(new string[] { "Info", "Error", "FileNotFoundException" });


                MsgBox.Show(text, caption, MessageBoxButtons.OK, btnT);
                */
        }
    }
}
