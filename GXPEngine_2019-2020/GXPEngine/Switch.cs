using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GXPEngine;

//=======================================================================
//                                              Swtch Class
//=======================================================================
class Switch : AnimationSprite
{
    int _switchPosition = 0;

    //=======================================================================
    //                                              Switch();
    //=======================================================================
    public Switch(float _x, float _y) : base("borders.png", 2, 1)
    {
        x = _x;
        y = _y;
    }

    //=======================================================================
    //                                              Update();
    //=======================================================================
    void Update()
    {
        SetFrame(_switchPosition);
        CollisionDetection();
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
    //                                              CollisionDetection();
    //=======================================================================
    void CollisionDetection()
    {
        if (Input.GetMouseButtonDown(0) && pointRect(Input.mouseX, Input.mouseY, x, y, this.width, this.height) && _switchPosition == 0)
        {
            _switchPosition = 1;
        }
        else if (Input.GetMouseButtonDown(0) && pointRect(Input.mouseX, Input.mouseY, x, y, this.width, this.height) && _switchPosition == 1)
        {
            _switchPosition = 0;
        }
    }

    //=======================================================================
    //                                              GetSwitchSetting();
    //=======================================================================
    public int GetSwitchSetting()
    {
        if (_switchPosition == 0)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
}

