using ExMessageBox;
using Functions.System;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JsonParser;

namespace Minecraft_Command_Editor
{
    public partial class Settings : Form
    {
        private readonly Json lang = new JsonFile(FilePath.lang);

        public Settings()
        {
            InitializeComponent();

            LoadLang();
            Initialize();
        }

        private void Initialize()
        {
            this.Icon = new Icon(FilePath.icoIcon1);

            #region comboBox_DisplayLang
            JsonIterator langlistJson = new JsonIterator(JsonFile.Parse(FilePath.langlist));
            List<JsonValue> langlist = langlistJson.TraversalArray("display", "List");
            ComboBox_DisplayLang.Items.Add(lang.GetValue("Form", "Settings", "General", "DisplayLang.Indexes").Value);
            foreach (var p in langlist)
            {
                ComboBox_DisplayLang.Items.Add(p.Value);
            }
            ComboBox_DisplayLang.SelectedIndex = langlistJson.QueryItemInArray(SettingItems.lang, "code", "List") + 1;
            #endregion
        }

        private void LoadLang()
        {
            this.Text = StrManipulation.Replace(lang.GetValue("Form", "Settings", "Title").Value.ToString(), CollectionItems.DefaultEscapeList);
            
            tabPage_General.Text = lang.GetValue("Form", "Settings", "General", "Text").Value.ToString();
            tabPage_SupportLib.Text = lang.GetValue("Form", "Settings", "SupportLib", "Text").Value.ToString();
            label_DisplayLang.Text = lang.GetValue("Form", "Settings", "General", "DisplayLang").Value.ToString();
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Homepage().Show();
        }

        private void comboBox_DisplayLang_DropDownClosed(object sender, EventArgs e)
        {
            JsonIterator langlistJson = new JsonIterator(JsonFile.Parse(FilePath.langlist));
            if (ComboBox_DisplayLang.SelectedIndex != 0 && ComboBox_DisplayLang.SelectedIndex != langlistJson.QueryItemInArray(SettingItems.lang, "code", "List") + 1)
            {
                string newLang = new Json(langlistJson).GetValue("List", ComboBox_DisplayLang.SelectedIndex - 1, "code").Value.ToString();
                string[] btnT =
                {
                    lang.GetValue("MessageBox", "Button", "OK").Value.ToString(),
                    lang.GetValue("MessageBox", "Button", "Cancel").Value.ToString()
                };
                Json tmp = new Json(JsonFile.Parse(FilePath.config));
                tmp.SetValue(JsonValue.Parse(newLang), "Language");
                JsonFile.Save(FilePath.config, tmp.GetJsonObject());
                if (MsgBox.Show(lang.GetValue("Info", "Information", "SuccessfullyChangedLanguage").Value.ToString(), lang.GetValue("MessageBox", "Title", "Tip").Value.ToString(), MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, btnT) == DialogResult.OK)
                {
                    Application.Restart();
                }
            }
        }
    }
}
