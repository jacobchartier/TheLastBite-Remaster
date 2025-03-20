using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    internal class Player : Entity
    {
        // Proprietes
        private byte _collectible;

        //Constructeur
        public Player(int hp, string name) : base(hp, name)
        {
        }

        // Methodes
        protected override void MoveX(float movement)
        {
            throw new NotImplementedException();
        }

        protected override void MoveY(float movement)
        {
            throw new NotImplementedException();
        }

        public void Update() { }

        public bool CheckCollision()
        {
            return false;
        }

        public void HandleInputs() { }
        public void CollectCollectible() { }
    }
}
