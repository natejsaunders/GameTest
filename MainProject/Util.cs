using System.Collections.Generic;
using System.IO;

namespace MainProject
{
    public static class Util
    {
        public const string DATA_FILE_PATH = "C:\\Users\\nate\\source\\repos\\PeakyBlindersGame\\MainProject\\";
    }

    public class FileDataStructure
    {
        public FileDataStructure(string path)
        {
            string filePath = Path.Combine(Util.DATA_FILE_PATH, path);


        }
    }
}
