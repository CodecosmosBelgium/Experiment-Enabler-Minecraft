using Experimenter.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimenter
{
    public static class WorldUtils
    {
        public static String GetWorldsFolder(bool isUWP)
        {
            if (isUWP) {
                return Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Packages\Microsoft.MinecraftEducationEdition_8wekyb3d8bbwe\LocalState\games\com.mojang\MinecraftWorlds";
            } else {
                return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Minecraft Education Edition\games\com.mojang\MinecraftWorlds";
            }
        }

        public static Image GetWorldIcon(string path)
        {
            if (path == null)
            {
                return Resources.No_Image;
            }
            string image = Path.GetDirectoryName(path) + @"\world_icon.jpeg";
            if (File.Exists(image))
            {
                return Image.FromFile(image);
            }
            else
            {
                return Resources.No_Image;
            }
        }

        public static string GetWorldName(string path)
        {
            if (path == null)
            {
                return "Unknown";
            }

            string levelName = Path.GetDirectoryName(path) + @"\levelname.txt";
            if (File.Exists(levelName))
            {
                return File.ReadAllText(levelName);
            }
            else
            {
                return "Unknown";
            }

        }
    }
}
