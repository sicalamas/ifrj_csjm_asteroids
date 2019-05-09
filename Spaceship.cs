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
    // Nave espacial controlada pelo jogador
    class Spaceship : Entity
    {
        // Atributos
        ///CircleF collider; // Area para teste de colisão
        bool isAccelerating; // Teste: Está acelerando?
        float accelIndex; // Índice de aceleração
        float dragIndex; // Índice de desaceleração

        // atributo temporário para testes
        Texture2D textura;

        // Métodos
        public override void init()
        {
            // Inicializa os atributos da superclasse
            position = new Vector2(100, 100);
            velocity = new Vector2(0, 0);
            angle = MathHelper.ToRadians(270); // = 270 graus convertido para radianos
            scale = 2.0f;
            // Inicializa atributos próprios
            isAccelerating = false;
            accelIndex = 1.0f;
            dragIndex = 0.99f;
            base.init();
        }

        public override void load(ContentManager cM)
        {
            // Carrega textura na memória do objeto
            textura = cM.Load<Texture2D>("SpriteSheet");
            base.load(cM);
        }

        public override void unload()
        {
            textura.Dispose();
            base.unload();
        }

        public override void update(GameTime gT)
        {
            base.update(gT);
        }

        public override void draw(SpriteBatch sB)
        {
            sB.Draw(textura,
                position,
                new Rectangle(0, 0, 16, 16),
                Color.White,
                angle,
                new Vector2(8, 8),
                scale,
                SpriteEffects.None,
                0);
            base.draw(sB);
        }
    }
}
