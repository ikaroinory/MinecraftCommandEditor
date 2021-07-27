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
            this.Text = StrManipulation.Replace(lang.GetValue("Form", "Loading", "Title").Value.ToString(), CollectionItems.DefaultEscapeList);
            label_LoadingInfo.Text = lang.GetValue("Info", "Loading", "CreateInitProcess").Value.ToString();
        }

        private void Loading_Shown(object sender, EventArgs e)
        {
            Process.ThreadDelay(256);
            this.label_LoadingInfo.Text = lang.GetValue("Info", "Loading", "LoadingLangFile").Value.ToString();
            Process.ThreadDelay(512);
            this.label_LoadingInfo.Text = lang.GetValue("Info", "Loading", "LoadingGiveItems_accdb").Value.ToString();
            Process.ThreadDelay(512);
            this.Hide();
            new Homepage().Show();
        }
    }
}
