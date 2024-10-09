using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace MainProject
{
    internal class Game
    {
        public Game(string saveName)
        {
            Directory.CreateDirectory(Path.Combine(Util.DATA_FILE_PATH, Settings.saveLocation));
            Console.WriteLine(Directory.Exists(Path.Combine(Util.DATA_FILE_PATH, Settings.saveLocation)));
        }
        public Game()
        {

        }
    }
}
