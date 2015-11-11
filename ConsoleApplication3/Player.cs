using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Audio;
using SFML.Graphics;
using SFML.Window;

namespace ConsoleApplication3
{
    class Player
    {
        Texture tex;
        Sprite spr;
        public Player()
        {
            tex = new Texture("Pictures/Enemy.png");
            spr = new Sprite(tex);
            spr.Scale = new Vector2f(0.8f, 0.8f);
        }
        public void Draw(RenderWindow win)
        {

            win.Draw(spr);
        }
        public float getpositionx()
        {
            float x = spr.Position.X;
            return x;
        }
        public float getpositiony()
        {
            float y = spr.Position.Y;
            return y;
        }
        public void move()
        {
            if (Keyboard.IsKeyPressed(Keyboard.Key.W)) { spr.Position += new Vector2f(0f, -0.5f); }
            if (Keyboard.IsKeyPressed(Keyboard.Key.S)) { spr.Position += new Vector2f(0f, 0.5f); }
            if (Keyboard.IsKeyPressed(Keyboard.Key.A)) { spr.Position += new Vector2f(-0.5f, 0f); }
            if (Keyboard.IsKeyPressed(Keyboard.Key.D)) { spr.Position += new Vector2f(0.5f, 0f); }
            if (Keyboard.IsKeyPressed(Keyboard.Key.P)) { Console.WriteLine(spr.Position.Y); }
            if (spr.Position.X > 810){spr.Position = new Vector2f(-100f, spr.Position.Y);}
            if (spr.Position.Y > 610) { spr.Position = new Vector2f(spr.Position.X, -100f); }
            if (spr.Position.X < -100) { spr.Position = new Vector2f(800f, spr.Position.Y); }
            if (spr.Position.Y <  -100) { spr.Position = new Vector2f(spr.Position.X, 600f); }
        }
    }
}
