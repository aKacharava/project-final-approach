using System;
using System.Drawing;
using GXPEngine;
using System.Collections;
using System.Collections.Generic;



//=======================================================================
//                                       GeneralText Class
//=======================================================================
public class GeneralText : Canvas
{
    private UpAndDownButton _dummyButton;

    //=======================================================================
    //                                         GeneralText();
    //=======================================================================
    public GeneralText(UpAndDownButton DisplayOfWhatButton) : base(1920, 1080)
    {
        _dummyButton = DisplayOfWhatButton;
    }

    //=======================================================================
    //                                                 Update();
    //=======================================================================
    void Update()
    {
        UpdateText();
    }

    //=======================================================================
    //                                              UpdateText();
    //=======================================================================
    public void UpdateText()
    {
        graphics.Clear(Color.Empty);
        graphics.DrawString(_dummyButton.ReturnValueString(), SystemFonts.CaptionFont, Brushes.Black, 200, 200);
    }
}
