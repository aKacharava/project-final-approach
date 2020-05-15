using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using GXPEngine;

public class Background : Sprite
{
    public Background(int width1, int height1) : base("background.png")
    {
        width = width1;
        height = height1;

        x = 0;
        y = 0;
    }
}