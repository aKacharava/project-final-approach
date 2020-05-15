using System;
using System.Drawing;
using GXPEngine;
using System.Collections;
using System.Collections.Generic;

//=======================================================================
//                                              Text Class
//=======================================================================
public class Text : Canvas
{
    private InterestList _dummyBox;
    string _textDisplayed;
    public string _textInput;
    List<Text> _dummyList;
    int _amountOfTimesAdded = 0;

    //=======================================================================
    //                                              Text();
    //=======================================================================
    public Text(InterestList boxNumber, string TextDisplayed, List<Text> TextList) : base(1920, 1080)
    {
        _textDisplayed = TextDisplayed;
        _dummyBox = boxNumber;
        _dummyList = TextList;
        graphics.DrawString(_textDisplayed, SystemFonts.CaptionFont, Brushes.Black, 0 + _dummyBox.width / 5, _dummyBox.y + _dummyBox.height / 3);
    }

    //=======================================================================
    //                                              Update();
    //=======================================================================
    void Update()
    {
        x = _dummyBox.x;
        GetDisplayedText();
    }


    //=======================================================================
    //                                         GetDisplayedText();
    //=======================================================================
    public string GetDisplayedText()
    {
        if (_dummyBox.ReturnSelected() == 1)
        {
            return _textDisplayed;
        }
        else
        {
            return "-";
        }
    }

    //=======================================================================
    //                                              CheckForlist();
    //=======================================================================
    public void CheckForList(List<Text> List)
    {
        if (_dummyBox.ReturnSelected() == 1 && _amountOfTimesAdded == 0)
        {
            List.Add(this);
            //Console.WriteLine("works");
            _amountOfTimesAdded = 1;
        }
        else if (_dummyBox.ReturnSelected() == 0 && _amountOfTimesAdded > 0)
        {
            List.Remove(this);
            _amountOfTimesAdded = 0;
        }
    }
}
