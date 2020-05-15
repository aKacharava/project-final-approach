using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GXPEngine;

public class Clock : AnimationSprite
{
    public Clock(int x1, int y1) : base("spritesheet_clock.png", 9, 1)
    {
        x = x1;
        y = y1;
        width = 200;
        height = 200;
    }
}