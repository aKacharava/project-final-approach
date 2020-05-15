using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using GXPEngine;

public class Foreground : Sprite
{
    public Foreground(int width1, int height1) : base("foreground.png")
    {
        width = width1;
        height = height1;

        x = 0;
        y = 0;
    }
}
