using System;
using System.Drawing;

namespace CharacterCreator
{
    class Character
    {
        public string name;

        public Spritesheet spritesheet;

        public Point tileCoordinates = new Point(0, 0);

        public Character(string name, Spritesheet spritesheet)
        {
            this.name = name;
            this.spritesheet = spritesheet;
        }
        public override string ToString()
        {
            return base.ToString() + "\n\tpath: \t" + spritesheet.path +
                   "\n\ttile coordinates: \t" + tileCoordinates.ToString();
        }

    }
}
