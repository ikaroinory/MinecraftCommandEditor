using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using Functions.System;
using JsonParser;

namespace Minecraft_Command_Editor
{
    public partial class GiveItems : Form
    {
        private readonly Json lang = new JsonFile(FilePath.lang);

        #region 开启界面双缓冲，解决窗体切换闪屏问题
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        #endregion

        public GiveItems()
        {
            InitializeComponent();

            LoadLang();
            Initialize();
        }

        private void Initialize()
        {
            this.Icon = new Icon(FilePath.icoIcon1);
            comboBox_Category.SelectedIndex = 0;
            comboBox_Items.SelectedIndex = 0;
            comboBox_Player.SelectedIndex = 0;
            comboBox_NameColorAndFont.SelectedIndex = 0;
            comboBox_LoreColorAndFont.SelectedIndex = 0;
            comboBox_HideFlags.SelectedIndex = 0;

            comboBox_NameColorAndFont.Enabled = false;
            comboBox_LoreColorAndFont.Enabled = false;
            comboBox_HideFlags.Enabled = false;
            // panel_Ench.Enabled = false;
            foreach (Control control in panel_Ench.Controls)
            {
                control.Enabled = false;
            }
            foreach (Control control in panel_Attributes.Controls)
            {
                control.Enabled = false;
            }
        }

        private void LoadLang()
        {
            this.Text = StrManipulation.Replace(lang.GetValue("Form", "GiveItems", "Title").Value.ToString(), CollectionItems.DefaultEscapeList);

            List<JsonProperty> list = null;
            #region Add Item to comboBox_Category
            list = JsonIterator.TraversalObject(lang.GetValue("Form", "GiveItems", "Category"));
            foreach (var p in list)
            {
                comboBox_Category.Items.Add(p.Value.Value);
            }
            #endregion

            #region Add Item to comboBox_HideFlags
            list = JsonIterator.TraversalObject(lang.GetValue("Form", "GiveItems", "HideFlags"));
            foreach (var p in list)
            {
                comboBox_HideFlags.Items.Add(p.Value.Value);
            }
            #endregion

            #region Add Item to comboBox_NameColorAndFont & comboBox_LoreColorAndFont
            comboBox_NameColorAndFont.Items.Add(lang.GetValue("Form", "GiveItems", "DisplayName", "ColorAndFont.Index").Value);
            comboBox_LoreColorAndFont.Items.Add(lang.GetValue("Form", "GiveItems", "Lore", "ColorAndFont.Index").Value);
            list = JsonIterator.TraversalObject(lang.GetValue("Minecraft", "Color"));
            foreach (var p in list)
            {
                comboBox_NameColorAndFont.Items.Add(p.Value.Value);
                comboBox_LoreColorAndFont.Items.Add(p.Value.Value);
            }
            list = JsonIterator.TraversalObject(lang.GetValue("Minecraft", "Font"));
            foreach (var p in list)
            {
                comboBox_NameColorAndFont.Items.Add(p.Value.Value);
                comboBox_LoreColorAndFont.Items.Add(p.Value.Value);
            }
            #endregion

            #region Add Item to comboBox_{comboBox_Attributes}
            list = JsonIterator.TraversalObject(lang.GetValue("Minecraft", "Part"));
            foreach(Control control in panel_Attributes.Controls)
            {
                if (Regex.IsMatch(control.Name, "comboBox_\\w+"))
                {
                    foreach (var p in list)
                    {
                        (control as ComboBox).Items.Add(p.Value.Value);
                    }
                }
            }
            #endregion

            comboBox_Items.Items.Add(lang.GetValue("Form", "GiveItems", "Items", "Index").Value);
            comboBox_Player.Items.Add(lang.GetValue("Form", "GiveItems", "Player", "Index").Value);
        }

        private void GiveItems_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Homepage().Show();
        }

        private void checkBox_Player_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Player.Enabled = !textBox_Player.Enabled;
        }

        private void checkBox_DisplayName_CheckedChanged(object sender, EventArgs e)
        {
            textBox_DisplayName.Enabled = !textBox_DisplayName.Enabled;
            comboBox_NameColorAndFont.Enabled = !comboBox_NameColorAndFont.Enabled;
        }

        private void checkBox_Lore_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Lore.Enabled = !textBox_Lore.Enabled;
            comboBox_LoreColorAndFont.Enabled = !comboBox_LoreColorAndFont.Enabled;
        }

        private void checkBox_HideFlags_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_HideFlags.Enabled = !comboBox_HideFlags.Enabled;
        }

        private void checkBox_Ench_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control control in panel_Ench.Controls)
            {
                if (control is CheckBox)
                {
                    control.Enabled = checkBox_Ench.Checked;
                }
            }
        }

        #region Attributes
        private void checkBox_Attributes_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control control in panel_Attributes.Controls)
            {
                if (Regex.IsMatch(control.Name, "(checkBox_)(?!per)\\w+"))
                {
                    control.Enabled = checkBox_Attributes.Checked;
                }
            }
        }

        private void checkBox_AttackDamage_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control control in panel_Attributes.Controls)
            {
                if (Regex.IsMatch(control.Name, "\\w+(AttackDamage)"))
                {
                    control.Enabled = checkBox_AttackDamage.Checked;
                }
            }
            checkBox_AttackDamage.Enabled = true;
        }

        private void checkBox_FollowRange_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control control in panel_Attributes.Controls)
            {
                if (Regex.IsMatch(control.Name, "\\w+(FollowRange)"))
                {
                    control.Enabled = checkBox_FollowRange.Checked;
                }
            }
            checkBox_FollowRange.Enabled = true;
        }
        #endregion
    }
}
