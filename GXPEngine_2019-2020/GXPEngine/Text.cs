using System;
using System.Drawing;
using GXPEngine;


public class Text : Canvas
{
    private InterestList _dummyBox;
    string _textDisplayed;

    public Text(InterestList boxNumber, string TextDisplayed) : base(1920, 1080)
    {
        _textDisplayed = TextDisplayed;
        _dummyBox = boxNumber;

        //graphics.ScaleTransform(2, 2);
        graphics.DrawString(_textDisplayed, SystemFonts.DefaultFont, Brushes.White, 0 + _dummyBox.width / 5, _dummyBox.y + _dummyBox.height / 3);
    }

    void Update()
    {
        x = _dummyBox.x;
    }
}