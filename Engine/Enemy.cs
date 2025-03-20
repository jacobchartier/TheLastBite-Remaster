using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;
using System.Data;

namespace Engine
{
    internal class Enemy : Entity
    {
        public Enemy(int hp, string name) : base(hp, name)
        {
        }

        //Methode
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
    }
}
