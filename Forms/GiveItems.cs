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
    public partial class GiveItems : Form
    {
        readonly Json lang = new JsonFile(FilePath.lang);


        public GiveItems()
        {
            InitializeComponent();

            LoadLang();
        }

        private void LoadLang()
        {
            this.Text = lang.GetValue("Form", "GiveItems", "Title").Value.ToString();
            List<JsonProperty> list = JsonIterator.TraversalObject(lang.GetValue("Form", "GiveItems", "Category"));
            foreach(var p in list)
            {
                comboBox_Category.Items.Add(p.Value.Value.ToString());
            }
        }

        private void GiveItems_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Homepage().Show();
        }
    }
}
