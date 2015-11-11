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
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Enemy enemy = new Enemy();
            RenderWindow window = new RenderWindow(new VideoMode(800,600),"Fenster");
            window.Closed += Close;
            while (window.IsOpen())
            {
                //Update(window);
                window.Clear(new Color(50,50,150));
                window.DispatchEvents();
                player.move();
               // enemy.move(player.getpositionx,player.getpositiony);
                enemy.Draw(window);
                player.Draw(window);
                window.Display();  

            }
        }
        static void Close(object sender, EventArgs e)
        {
            ((RenderWindow)sender).Close();
        }
        public static void Update(RenderWindow window)
        {
                
                
               
                
        }
    }
}
