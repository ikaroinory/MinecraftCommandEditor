using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsonParser;

namespace Minecraft_Command_Editor
{
    public static class Path
    {
        public static readonly string config = @".\config\";
        public static readonly string dll = @".\dll\";
        public static readonly string lang = @".\lang\";
        public static readonly string resources = @".\resources\";
    }
    public static class SettingItems
    {
        public static readonly string lang = new JsonFile(@".\config\config.json").GetValue("Language").Value.ToString();
    }
    public class FilePath
    {
        public static readonly string config = Path.config + "config.json";
        public static readonly string langlist = Path.lang + "langlist.json";
        public static readonly string lang = Path.lang + SettingItems.lang + ".json";

        public static readonly string gifMCE = Path.resources + @"images\" + "MCE.gif";
        public static readonly string icoIcon1 = Path.resources + @"images\icon\MCE\" + "icon1 16x16.ico";
        public static readonly string pngGiveItems = Path.resources + @"images\icon\function\" + "golden_pickaxe 60x60.png";
        public static readonly string pngHistory = Path.resources + @"images\icon\function\" + "history 60x60.png";
        public static readonly string pngSettings = Path.resources + @"images\icon\function\" + "settings 60x60.png";
    }
    public class File
    {
        public static JsonObject config = JsonFile.Parse(FilePath.config);
    }

    public class CollectionItems
    {
        public static readonly SortedList DefaultEscapeList = new SortedList
        {
            { "{%prog}", "Minecraft Command Editor" },
            { "{%ver}", new Json(File.config).GetValue("Application", "Version").Value.ToString() },
            { "{%lang}", SettingItems.lang },
            { "%%" , "%" },
        };

        public static class MsgBoxButtonTitle
        {
            private static readonly Json lang = new Json(JsonFile.Parse(FilePath.lang));
            public static readonly string[] OK =
            {
                lang.GetValue("MessageBox","Button","OK").ToString(),
            };
            public static readonly string[] OKCancel =
            {
                lang.GetValue("MessageBox", "Button", "OK").ToString(),
                lang.GetValue("MessageBox", "Button", "Cancel").ToString(),
            };

        }
    }

    public class LangText
    {
        private static readonly Json lang = new Json(JsonFile.Parse(FilePath.lang));

        public static readonly string Encoding = lang.GetValue("Encoding").ToString();

        public static class Info
        {
            private static readonly Json jsonInfo = new Json(lang.GetValue("Info"));

            public static class Loading
            {
                private static readonly Json jsonLoading = new Json(jsonInfo.GetValue("Loading"));

                public static readonly string CreateInitProcess = jsonLoading.GetValue("CreateInitProcess").ToString();
            }
        }
    }
}
