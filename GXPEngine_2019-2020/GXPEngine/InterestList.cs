using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GXPEngine;


//=======================================================================
//                                              Update();
//=======================================================================
public class InterestList : AnimationSprite
{
    float _OriginalX;
    float _OriginalY;
    int _positionOfBox;
    int _column;
    public Boolean _active;

    //=======================================================================
    //                                              InterestList();
    //=======================================================================
    public InterestList(float _x, float _y, int number, int WhatColumn) : base("blocks.png", 2, 1)
    {
        x = _x;
        y = _y;
        _OriginalX = _x;
        _OriginalY = _y;
        _column = WhatColumn;
    }

    //=======================================================================
    //                                              Update();
    //=======================================================================
    void Update()
    {
        if (_active)
        {
            SetFrame(_positionOfBox);
            CollisionDetection();
            PositionHandler();
            ReturnSelected();
        }
        }

    //=======================================================================
    //                                              pointRect();
    //=======================================================================

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

    //=======================================================================
    //                                              CollisionDetection();
    //=======================================================================
    void CollisionDetection()
    {
        if (Input.GetMouseButtonDown(0) && pointRect(Input.mouseX, Input.mouseY, x, y, this.width, this.height) && _positionOfBox == 0)
        {
            _positionOfBox = 1;
        }
        else if (Input.GetMouseButtonDown(0) && pointRect(Input.mouseX, Input.mouseY, x, y, this.width, this.height) && _positionOfBox == 1)
        {
            _positionOfBox = 0;
        }
    }

    //=======================================================================
    //                                              PositionHandler();
    //=======================================================================
    public void PositionHandler()
    {
        if (_positionOfBox == 0)
        {
            x = _OriginalX;
            y = _OriginalY;
        }
        else if (_positionOfBox == 1 && _column == 1)
        {
            x = _OriginalX + 720;
            y = _OriginalY;
        }
        else if (_positionOfBox == 1 && _column == 2)
        {
            x = _OriginalX + 320;
            y = _OriginalY;
        }
    }

    //=======================================================================
    //                                              ReturnSelected();
    //=======================================================================
    public int ReturnSelected()
    {
        return _positionOfBox;
    }
}