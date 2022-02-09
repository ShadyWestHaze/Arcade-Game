using System;
using GXPEngine;

public class Enemy : Sprite
{
    public Enemy() : base("circle.png")
    {

    }

    public void EnemyGone()
    {
        this.LateDestroy();
    }
}