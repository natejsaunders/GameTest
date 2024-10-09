using System;
using System.Collections.Generic;
using System.IO;

namespace MainProject
{
    public static class Util
    {
        public const string DATA_FILE_PATH = "C:\\Users\\nate\\source\\repos\\PeakyBlindersGame\\MainProject\\";

        // Basic method for reading variables from a file
        // No hirearchical design
        // TODO Add compatitbility for other types
        public static FileData readVariablesFile(string path)
        {
            string fileLocation = Path.Combine(Util.DATA_FILE_PATH, path);
            string[] fileLines = File.ReadAllLines(fileLocation);
            List<List<string>> vars = new List<List<string>>();

            foreach (string line in fileLines)
            {
                try
                {
                    string[] var = line.Split(':');
                    string name = var[0];
                    string value = var[1];
                    vars.Add(new List<string>() { name, value });
                }
                catch
                {
                    Console.WriteLine($"Error parsing file: {fileLocation}");
                    Console.WriteLine($"Line contents: '{line}'");
                }
            }

            return new FileData(vars);
        }
    }

    // Used to store and access a vareity of Types that have been loaded from a file
    public class FileData
    {
        private Dictionary<string, bool> storedBools;
        private Dictionary<string, int> storedInts;
        private Dictionary<string, string> storedStrings;

        public FileData(List<List<string>> fileVars)
        {
            storedBools = new Dictionary<string, bool>();
            storedInts = new Dictionary<string, int>();
            storedStrings = new Dictionary<string, string>();
            foreach (List<string> var in fileVars)
            {
                if (var[0] == "" || var[1] == "") { continue; }
                string key = String.Join("", var[0].Split('"'));
                if ( var[1] == "True" )
                {
                    storedBools.Add(key, true);
                }
                else if ( var[1] == "False" )
                {
                    storedBools.Add(key, false);
                }
                else if (int.TryParse(var[1], out int tempInt))
                {
                    storedInts.Add(key, tempInt);
                }
                else
                {
                    storedStrings.Add(key, String.Join("", var[1].Split('"')));
                }
            }
        }

        public bool getBool(string name) 
        {
            return storedBools[name];
        }
        public int getInt(string name)
        {
            return storedInts[name];
        }
        public string getString(string name)
        {
            return storedStrings[name];
        }

        // Test methods
        public void print()
        {
            foreach(string key in storedBools.Keys)
            {
                Console.WriteLine($"{key}: {storedBools[key]}");
            }
            foreach (string key in storedInts.Keys)
            {
                Console.WriteLine($"{key}: {storedInts[key]}");
            }
            foreach (string key in storedStrings.Keys)
            {
                Console.WriteLine($"{key}: \"{storedStrings[key]}\"");
            }
        }
    }
}
