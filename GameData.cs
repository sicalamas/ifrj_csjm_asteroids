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
        public static Texture2D gameTexture; // Sprite Sheet
        public static readonly int WIDTH = 640;
        public static readonly int HEIGHT = 480;
        public static int LIFES = 3; // nº de vidas
        public static readonly float GLOBAL_SCALE = 2.0f; // Escala global para os objetos

        public GameData(ContentManager cM)
        {
            gameTexture = cM.Load<Texture2D>("SpriteSheet");
        }

        public void drawLifes(SpriteBatch sB)
        {
            for( int i = 0; i < LIFES; i++)
            {
                //sB.Draw(gameTexture, new Rectangle(32 * ((int)i / 3), 32 * i - (32 * i), 48, 48), new Rectangle(0, 32, 16, 16), Color.White); // Draw multilinhas
                sB.Draw(gameTexture, new Rectangle((int)(8 * GLOBAL_SCALE) * i, 0, 16 * (int)GLOBAL_SCALE, 16 * (int)GLOBAL_SCALE), new Rectangle(0, 32, 16, 16), Color.White);
            }
        }
    }
}
