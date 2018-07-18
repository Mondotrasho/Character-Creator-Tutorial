using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace CharacterCreator
{
    using System.IO;

    class Spritesheet
    {
        private Image image = null;

        public string path;

        public int GetWidth()
        {
            return image.Width;

            // add your implementation here
        }

        public int GetHeight()
        {
            return image.Height;

            // add your implementation here
        }

        public Spritesheet(string path)
        {
            this.path = path;
            Load();
        }

        public void Load()
        {
            
            {
                this.image = Image.FromFile(path);
            }
        }
        public override string ToString()
        {
            return base.ToString() + ": " + path.ToString();
        }
    }
}

