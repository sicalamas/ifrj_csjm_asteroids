using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroids
{
    class Missile : Entity
    {
        // Atributo
        GameObjects entityRef;

        public Missile(Vector2 p, Vector2 v, float a, GameObjects e)
        {
            position = p;
            angle = a;
            velocity.X = (float)Math.Cos(angle);
            velocity.Y = (float)Math.Sin(angle);
            entityRef = e;
            scale = GameData.SCALE;
        }

        private void updatePosition()
        {
            velocity.Normalize();
            position.X += velocity.X * 10.0f;
            position.Y += velocity.Y * 10.0f;
            // Screen Warp
            if (position.X >= GameData.WIDTH || position.X <= 0 || position.Y >= GameData.HEIGHT || position.Y <= 0)
            {
                destroy();
            }
        }

        public override void destroy()
        {
            entityRef.destroy(this);

        }

        public override void update(GameTime gT)
        {
            updatePosition();
            base.update(gT);
        }

        public override void draw(SpriteBatch sB)
        {
                sB.Draw(GameData.gameTexture,
            position,
            new Rectangle(16,48,16,16),
            Color.White,
            angle + MathHelper.ToRadians(90),
            new Vector2(8, 8),
            scale,
            SpriteEffects.None,
            0);
            base.draw(sB);
        }
    }
}
