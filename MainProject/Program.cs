using System;
using System.IO;

namespace MainProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Settings.loadSettings();

            Person test = Person.loadFromFile("TestCharacter.txt");
            Person ts = Person.loadFromFile("TommyShelby.txt");

            test.printInfo();
            ts.printInfo();
        }
    }
}
