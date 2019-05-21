using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroids 
{
    class Asteroid : Entity
    {
        // Atributos
        CircleF collider; // Colisor para testes de colisão
        //Strategy str; // Estratégia / comportamentos
        int seed; // para gerador aleatório

        // Construtor
        public Asteroid(float x, float y, int s)
        {
            position.X = x; // Configurei a posição do objeto
            position.Y = y;
            seed = s;
        }

        public override void init()
        {
            setVelocity(seed);
            scale = GameData.GLOBAL_SCALE;
            base.init();
        }

        public override void load(ContentManager cM)
        {
            base.load(cM);
        }

        public override void unload()
        {
            base.unload();
        }

        public override void update(GameTime gT)
        {
            updatePosition();
            angle += 0.01f;
            base.update(gT);
        }

        public override void draw(SpriteBatch sB)
        {
            // TEMPORÁRIO
            sB.Draw(GameData.gameTexture,
                position,
                new Rectangle(32, 0, 32, 32),
                Color.White,
                angle + MathHelper.ToRadians(90),
                new Vector2(16, 16),
                GameData.GLOBAL_SCALE,
                SpriteEffects.None,
                0);
            base.draw(sB);
        }

        private void setVelocity(int s)
        {
            Random rand = new Random(s); // Gerador aletório de números
            velocity.X = (float) rand.Next(-10, 10) / 10;
            velocity.Y = (float) rand.Next(-10, 10) / 10;
        }

        private void updatePosition()
        {
            position.X += velocity.X;
            position.Y += velocity.Y;
            // Screen Warp
            if (position.X >= GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width)
                position.X = 0;
            else if (position.X <= 0)
                position.X = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
            else if (position.Y >= GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height)
                position.Y = 0;
            else if (position.Y <= 0)
                position.Y = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;
        }
    }
}
