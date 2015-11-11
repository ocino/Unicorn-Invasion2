using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
using SFML.Audio;
using SFML.Window;

namespace ConsoleApplication3
{
    class Enemy
    {
        Sprite spr;
        Texture tex;
        public Enemy()
        {
            tex = new Texture("Pictures/world.png");
            spr = new Sprite(tex);
            spr.Scale = new Vector2f(1f,1f);

        }
        public void Draw(RenderWindow win)
        {
           // spr.Position = new Vector2f(400, 300);
            win.Draw(spr);
        }
        public void move(float x,float y)
        {
         //   spr.Position += new Vector2f(x,y);
        }

    }
}
