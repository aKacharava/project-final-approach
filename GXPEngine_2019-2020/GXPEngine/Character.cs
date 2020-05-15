using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GXPEngine;

public class Character : AnimationSprite
{
    public Character(int x1, int y1) : base("character_spritesheet.png", 5, 2)
    {
        x = x1;
        y = y1;
        width = 350;
        height = 700;
    }
}