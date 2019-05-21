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
    class GameObjects
    {
        // Atributos
        private List<Entity> objectsList;

        // Métodos básicos
        public GameObjects()
        {
            objectsList = new List<Entity>();
        }
        
        public void init()
        {
            // Loop para inicializar objetos de objectsList
            for (int i = 0; i < objectsList.Count();i++)
            {
                objectsList[i].init(); // Chamada à init() nos objetos listados
            }
        }

        public void load(ContentManager cM)
        {
            // Loop para carregar objetos de objectsList
            for (int i = 0; i < objectsList.Count(); i++)
            {
                objectsList[i].load(cM); // Chamada à load() nos objetos listados
            }
        }

        public void unload()
        {
            // Loop para descarrega objetos de objectsList
            for (int i = 0; i < objectsList.Count(); i++)
            {
                objectsList[i].unload(); // Chamada à unload() nos objetos listados
            }
        }
    
        public void update(GameTime gT)
        {
            // Loop para atualiza objetos de objectsList
            for (int i = 0; i < objectsList.Count(); i++)
            {
                objectsList[i].update(gT); // Chamada à update() nos objetos listados
            }
        }

        public void draw(SpriteBatch sB)
        {
            // Loop para desenhar objetos de objectsList
            for (int i = 0; i < objectsList.Count(); i++)
            {
                objectsList[i].draw(sB); // Chamada à draw() nos objetos listados
            }
        }

        // Métodos especiais
        public void createPlayer(float x, float y)
        {
            objectsList.Add(new Spaceship(x,y));
        }

        public void createPlayersOnDrugs(int n)
        {
            Random rand;
            
            for (int i = 0; i < n; i++)
            {
                    rand = new Random(i);
                    objectsList.Add(new Spaceship(rand.Next(GameData.WIDTH), rand.Next(GameData.HEIGHT)));
            }
        }

        public void createAsteroids(int n)
        {
            Random rand;

            for (int i = 0; i < n; i++)
            {
                rand = new Random(i);
                objectsList.Add(new Asteroid(rand.Next(GameData.WIDTH), rand.Next(GameData.HEIGHT),i));
            }
        }


    }
}
