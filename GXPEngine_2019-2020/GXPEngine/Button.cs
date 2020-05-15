using GXPEngine;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using TiledMapParser;

public class Button : Sprite
{
    Canvas canvas;
    Font font = new Font(FontFamily.GenericSerif.Name, 19, FontStyle.Regular);

    string _buttonContent;

    public Button(int x1, int y1, string buttonText) : base("button.png")
    {
        x = x1;
        y = y1;
        width = 600;
        height = 130;
        _buttonContent = buttonText;

        canvas = new Canvas(1400, 200);
        canvas.graphics.DrawString(_buttonContent, font, Brushes.Black, 25, 85);
        AddChild(canvas);
    }

    public void UpdateText(string newText)
    {
        _buttonContent = newText;
        canvas.graphics.Clear(Color.Transparent);
        canvas.graphics.DrawString(_buttonContent, font, Brushes.Black, 25, 85);
    }
}