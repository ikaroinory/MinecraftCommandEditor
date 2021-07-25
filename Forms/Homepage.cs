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
using JsonParser;

namespace Minecraft_Command_Editor
{
    public partial class Homepage : Form
    {
        readonly Json lang = new JsonFile(FilePath.lang);


        public Homepage()
        {
            InitializeComponent();

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
            this.Text = lang.GetValue("Form", "Homepage", "Title").Value.ToString();
            label_GiveItems.Text = lang.GetValue("Form", "Homepage", "GUI", "GiveItems").Value.ToString();
            label_Settings.Text = lang.GetValue("Form", "Homepage", "GUI", "Settings").Value.ToString();
        }

        private void LoadSettings(object sender, EventArgs e)
        {
            new Settings().Show();
            this.Hide();
        }

        private void LoadGiveItems(object sender, EventArgs e)
        {
            new GiveItems().Show();
            this.Hide();
        }

        private void Homepage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
