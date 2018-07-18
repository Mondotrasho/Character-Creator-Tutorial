using System;
using System.IO;
using System.Collections.Generic;
namespace CharacterCreator
{
 

    using static Console;

    class Program
    {
        static Spritesheet spritesheet = null;
        static Character character = null;
        static List<Character> characters = new List<Character>();

        static void Main(string[] args)
        {
            WriteLine("Working directory is " + Directory.GetCurrentDirectory());

            WriteLine("Enter the relative path of the sprite sheet texture: ");
            var path = ReadLine();
            Console.WriteLine("Make a new character (y/n): ");
            while (Console.ReadLine().ToLower().StartsWith("y") == true)
            {
                WriteLine("Enter the name of the character to create: ");
                var name = ReadLine();

                spritesheet = new Spritesheet(Directory.GetCurrentDirectory() + "\\" + path);
                if (spritesheet == null)
                {
                    WriteLine("Error loading sprite sheet. Exiting program.");
                    return;
                }

                character = new Character(name, spritesheet);

                WriteLine("Enter the x tile index: ");
                var x = int.Parse(ReadLine());
                Console.WriteLine("Enter the y tile index: ");
                var y = int.Parse(ReadLine());

                character.tileCoordinates = new System.Drawing.Point(x, y);
                characters.Add(character);
                Console.WriteLine("Make a new character (y/n): ");
            }

            Console.Clear();
            foreach (Character character in characters)
            {
                Console.WriteLine(character.ToString());
            }
            ReadKey();
        }
    }
}