using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GXPEngine;

//=======================================================================
//                                       UpAndDownButton Class
//=======================================================================
public class UpAndDownButton : Sprite
{
    Boolean _add;
    Boolean _Detract;
    int _value = 100;

    public Boolean _active;

    //=======================================================================
    //                                              UpAndDownButton();
    //=======================================================================
    public UpAndDownButton( ): base("ButtonUpDown.png")
    {

    }

    //=======================================================================
    //                                              Update();
    //=======================================================================
    void Update()
    {
        if (_active)
        {

        
            _add = pointRect(Input.mouseX, Input.mouseY, x, y, this.width, this.height / 2);
            _Detract = pointRect(Input.mouseX, Input.mouseY, x, y + this.height / 2, this.width, this.height / 2);
            if (_add && Input.GetMouseButtonDown(0) && _value < 100  )
            {
                _value += 1;
                //Console.WriteLine(_value);
            }
            if (_Detract && Input.GetMouseButtonDown(0) && _value > 0)
            {
                _value -= 1;
                //Console.WriteLine(_value);
            }
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
    //                                              ReturnValueString();
    //=======================================================================
    public string ReturnValueString()
    {
        return _value.ToString();
    }

    //=======================================================================
    //                                              ReturnValueInt();
    //=======================================================================
    public int ReturnValueInt()
    {
        return _value;
    }
}