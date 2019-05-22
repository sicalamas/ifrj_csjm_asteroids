using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroids
{
    class GameData
    {
        // atributo temporário para testes
        public static Texture2D gameTexture;

        public static readonly int WIDTH = 640;
        public static readonly int HEIGHT = 480;
        public static int LIFES = 3;
        public static float SCALE = 2.0f;
        public static bool FULLSCREEN = false;

        public GameData(ContentManager cM)
        {
            gameTexture = cM.Load<Texture2D>("SpriteSheet");
        }

        public void drawLifes(SpriteBatch sB)
        {
            for( int i = 0; i < LIFES; i++)
            {
                sB.Draw(gameTexture, new Rectangle(8 * (int)SCALE * i, 0, 16 * (int)SCALE, 16 * (int)SCALE), new Rectangle(0, 32, 16, 16), Color.White);
            }
        }
    }
}
