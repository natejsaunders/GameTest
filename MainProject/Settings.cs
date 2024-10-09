using System;
using System.Collections.Generic;
using System.IO;

namespace MainProject
{
    // Used to store settings globally
    internal static class Settings
    {
        private const string SETTINGS_FILE_LOCATION = "settings.txt";

        public static string saveLocation { get; private set; }
        public static string personInfoLocation { get; private set; }

        public static void loadSettings() 
        {
            FileData settingsFileData = Util.readVariablesFile(SETTINGS_FILE_LOCATION);

            saveLocation = Path.Combine(Util.DATA_FILE_PATH, settingsFileData.getString("save_location"));
            personInfoLocation = Path.Combine(Util.DATA_FILE_PATH, settingsFileData.getString("char_info_location"));
        }
    }
}
