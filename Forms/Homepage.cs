using Functions.System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Functions.System;
using JsonParser;

namespace Minecraft_Command_Editor
{
    public partial class Homepage : Form
    {
        private readonly Json lang = new JsonFile(FilePath.lang);
        private bool isExitThread;

        public Homepage()
        {
            InitializeComponent();
            isExitThread = true;

            this.Icon = new Icon(FilePath.icoIcon1);

            pictureBox_GiveItems.Image = Image.FromFile(FilePath.pngGiveItems);
            pictureBox_Settings.Image = Image.FromFile(FilePath.pngSettings);

            LoadLang();
        }

        private void LoadLang()
        {
            /*
             * 未处理异常
             * System.ArgumentNullException:“Value cannot be null. Arg_ParamName_Name”
             */
            this.Text = StrManipulation.Replace(lang.GetValue("Form", "Homepage", "Title").Value.ToString(), CollectionItems.DefaultEscapeList);
            label_GiveItems.Text = lang.GetValue("Form", "Homepage", "GUI", "GiveItems").Value.ToString();
            label_Settings.Text = lang.GetValue("Form", "Homepage", "GUI", "Settings").Value.ToString();
        }

        private void Homepage_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExitThread)
            {
                Application.Exit();
            }
        }

        private void LoadGiveItems(object sender, EventArgs e)
        {
            isExitThread = false;
            new GiveItems().Show();
            this.Hide();
        }

        private void LoadSettings(object sender, EventArgs e)
        {
            isExitThread = false;
            new Settings().Show();
            this.Close();
        }
    }
}
