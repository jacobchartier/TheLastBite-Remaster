using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    internal abstract class Entity
    {
        //Proprietes
        protected int hp;
        protected Vector2 position;
        protected float velocity;
        protected string name;
        protected bool isOnGround;
        // protected Hitbox hitbox;

        protected Entity(int hp, string name) 
        {
            this.hp = hp;
            this.name = name;
            this.isOnGround = true;
        }

        //Methodes
        protected abstract void MoveX(float movement);
        protected abstract void MoveY(float movement);

    }
}
