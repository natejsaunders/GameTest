using System;
using System.Collections.Generic;
using System.IO;

namespace MainProject
{
    internal class Person
    {
        public readonly bool isPlayer;

        public readonly int id;
        public readonly string name;

        //public Location location;

        public Person()
        {
            id = 0;
            name = "Default Person";
            isPlayer = false;
        }
        public Person(int id, string name, bool isPlayer)
        {
            this.id = id;
            this.name = name;
            this.isPlayer = isPlayer;
        }

        // Test methods
        public void printInfo()
        {
            Console.WriteLine($"Name: {this.name}");
            Console.WriteLine($"ID: {this.id}");
        }

        public static Person loadFromFile(string fileName)
        {
            FileData charInfo = Util.readVariablesFile(Path.Combine(Settings.personInfoLocation, fileName));

            return new Person(
                charInfo.getInt("id"),
                charInfo.getString("name"),
                false // To change as player char will need to be loaded from a file
                );
        }
    }
}
