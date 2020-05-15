using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GXPEngine;


//=======================================================================
//                                             NextButton Class
//=======================================================================
class NextButton : Sprite
{
    Boolean NextScreen;

    //=======================================================================
    //                                              NextButton();
    //=======================================================================
    public NextButton() : base("Button next.png")
    {
    }

    //=======================================================================
    //                                                 Update();
    //=======================================================================
    void Update()
    {
        if (pointRect(Input.mouseX, Input.mouseY, x, y, this.width, this.height) && Input.GetMouseButtonDown(0))
        {
            NextScreen = true;
        }
    }

    //=======================================================================
    //                                              pointRect();
    //=======================================================================
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

    //=======================================================================
    //                                              ReturnNext();
    //=======================================================================
    public Boolean ReturnNext()
    {
        return NextScreen;
    }



}

