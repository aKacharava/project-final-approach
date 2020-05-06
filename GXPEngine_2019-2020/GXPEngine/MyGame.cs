using System;									// System contains a lot of default C# libraries 
using System.Drawing;                           // System.Drawing contains a library used for canvas drawing below
using GXPEngine;								// GXPEngine contains the engine

public class MyGame : Game
{


    InterestList box1;
    InterestList box2;
    Text textBox1;

    public MyGame() : base(1920,1080, false)		// Create a window that's 800x600 and NOT fullscreen
	{
        //----------------------------------------------------example-code----------------------------
        //create a canvas
        Canvas canvas = new Canvas(1920, 1080);

        //add some content
        canvas.graphics.FillRectangle(new SolidBrush(Color.Red), new Rectangle(0, 0, 400, 300));
        canvas.graphics.FillRectangle(new SolidBrush(Color.Blue), new Rectangle(400, 0, 400, 300));
        canvas.graphics.FillRectangle(new SolidBrush(Color.Yellow), new Rectangle(0, 300, 400, 300));
        canvas.graphics.FillRectangle(new SolidBrush(Color.Gray), new Rectangle(400, 300, 400, 300));

        //add canvas to display list
        AddChild(canvas);
        //------------------------------------------------end-of-example-code-------------------------



        box1 = new InterestList(500, 500, 1);
        AddChild(box1);
        textBox1 = new Text(box1);
        AddChild(textBox1);


        box2 = new InterestList(500, 800, 2);
        AddChild(box2);



    }

    void Update()
	{
		// Empty
	}

	static void Main()							// Main() is the first method that's called when the program is run
	{
		new MyGame().Start();					// Create a "MyGame" and start it
	}
}