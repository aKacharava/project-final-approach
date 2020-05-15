using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using GXPEngine;

public class TextBox : Sprite
{
    Canvas canvas;
    Font font = new Font(FontFamily.GenericSerif.Name, 23, FontStyle.Regular);

    string _textContent;
    public TextBox(int x1, int y1, string textBoxText) : base("textbox.png")
    {
        x = x1;
        y = y1;
        width = 700;
        height = 200;

        _textContent = textBoxText;

        canvas = new Canvas(1400, 200);
        canvas.graphics.DrawString(_textContent, font, Brushes.Black, 50, 85);
        AddChild(canvas);
    }

    public void UpdateText(string newText)
    {
        _textContent = newText;
        canvas.graphics.Clear(Color.Transparent);
        canvas.graphics.DrawString(_textContent, font, Brushes.Black, 50, 85);
    }
}