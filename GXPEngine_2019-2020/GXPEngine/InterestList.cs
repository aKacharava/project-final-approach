using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GXPEngine;



public class InterestList : Sprite
{
    float OriginalX;
    float OriginalY;
    int PositionOfButton;

    public InterestList(float _x, float _y, int number) : base("Button prototype" + number + ".png")
    {
        x = _x;
        y = _y;
        OriginalX = _x;
        OriginalY = _y;
    }

    void Update()
    {
        CollisionDetection();
        PositionHandler();
    }
    // POINT/RECTANGLE
    public Boolean pointRect(float px, float py, float rx, float ry, float rw, float rh)
    {
        // is the point inside the rectangle's bounds?
        if (px >= rx &&        // right of the left edge AND
           px <= rx + rw &&   // left of the right edge AND
           py >= ry &&        // below the top AND
            py <= ry + rh)
        {
            return true;
        }
        return false;
    }

    public void CollisionDetection()
    {
        if (Input.GetMouseButtonDown(0) && pointRect(Input.mouseX, Input.mouseY, x, y, this.width, this.height) && PositionOfButton == 0)
        {
            PositionOfButton = 1;
        }
        else if (Input.GetMouseButtonDown(0) && pointRect(Input.mouseX, Input.mouseY, x, y, this.width, this.height) && PositionOfButton == 1)
        {
            PositionOfButton = 0;
        }
    }

    public void PositionHandler()
    {
        if (PositionOfButton == 0)
        {
            x = OriginalX;
            y = OriginalY;
        }

        else if (PositionOfButton == 1)
        {
            x = OriginalX + 720;
            y = OriginalY;
        }
    }
}