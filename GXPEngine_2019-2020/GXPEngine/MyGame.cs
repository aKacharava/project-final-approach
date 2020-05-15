using System;
using System.Drawing;
using GXPEngine;

public class MyGame : Game
{
    InterestList box1;
    InterestList box2;

    Text textBox1;
    Text textBox2;

    Button _button1;
    Button _button2;
    Button _button3;

    TextBox _textBox;

    Character _charater;

    Background _background;

    Foreground _foreground;

    Clock _clock;

    Sound _timeup;

    int _male = 0;
    int _female = 1;
    int _gender;

    string _text1;
    string _text2;
    string _text3;
    string _textboxText;

    string _question1;
    string _question2;
    string _question3;
    string _question4;
    string _question5;
    string _subQuestion1;
    string _subQuestion2;
    string _subQuestion3;
    string _subQuestion4;
    string _question6;
    string _subQuestion5;
    string _subQuestion6;
    string _subQuestion7;
    string _question7;
    string _question8;
    string _question9;
    string _subQuestion8;
    string _subQuestion9;
    string _subQuestion10;
    string _question10;
    string _subQuestion11;
    string _subQuestion12;
    string _subQuestion13;
    string _subQuestion14;

    string _answers1;
    string _answers2;
    string _answers3;
    string _answers4;
    string _answers5;
    string _subAnswer1;
    string _subAnswer2;
    string _subAnswer3;
    string _subAnswer4;
    string _answers6;
    string _subAnswer5;
    string _subAnswer6;
    string _subAnswer7;
    string _subAnswer8;
    string _answers7;
    string _answers8;
    string _answers9;
    string _subAnswer9;
    string _subAnswer10;
    string _subAnswer11;
    string _answers10;
    string _subAnswer12;
    string _subAnswer13;
    string _subAnswer14;

    int _neutralEmotionSam = 0;
    int _uninterestedEmotionSam = 1;
    int _insultedEmotionSam = 2;
    int _shyEmotionSam = 3;
    int _excitedEmotionSam = 4;

    int _neutralEmotionIsabella = 5;
    int _uninterestedEmotionIsabella = 6;
    int _insultedEmotionIsabella = 7;
    int _shyEmotionIsabella = 8;
    int _excitedEmotionIsabella = 9;

    int _dateSuccess;

    int _frametimer;

    bool _ending;

    public MyGame() : base(1920, 1080, false, false)
    {
        targetFps = 60;

        _timeup = new Sound("time-up.wav");

        _background = new Background(width, height);
        AddChild(_background);

        _charater = new Character(550, 300);
        AddChild(_charater);

        _clock = new Clock((width / 6) * 5, 0);
        AddChild(_clock);

        _foreground = new Foreground(width, height);
        AddChild(_foreground);

        _textBox = new TextBox(400, 800, _textboxText);
        AddChild(_textBox);

        _frametimer /= 60;

        //box1 = new InterestList(500, 500, 1);
        //AddChild(box1);
        //textBox1 = new Text(box1, "Dit is box 1 hai");
        //AddChild(textBox1);

        //box2 = new InterestList(500, 800, 2);
        //AddChild(box2);
        //textBox2 = new Text(box2, "Dit is box 2 bai");
        //AddChild(textBox2);

        _dateSuccess = 0;
        _gender = 0;

        if (_gender == _female)
        {
            // Questions Sam
            _question1 = "Nervous?";
            _question2 = "Don’t be shy, I don’t bite";
            _question3 = "… … …";
            _question4 = "How old are you?";
            _question5 = "What do you do for a living?";
            _subQuestion1 = "You must like animals?";
            _subQuestion2 = "Lizards are cool. Do you have any yourself?";
            _subQuestion3 = "I guess I’m neutral… Not like but not dislike.";
            _subQuestion4 = "Oh those things…";
            _question6 = "What do you like to do on the weekends?";
            _subQuestion5 = "What kind of books do you read?";
            _subQuestion6 = "Probably fantasy as well.";
            _subQuestion7 = "Romance for sure.";
            _subQuestion8 = "Non-fiction.";
            _question7 = "I like your shirt.";
            _question8 = "If you were a cat, what kind of cat would you be?";
            _question9 = "What size are you?";
            _subQuestion9 = "Yeah, clothing.";
            _subQuestion10 = "No, I mean how tall you are.";
            _subQuestion11 = "No, your ‘size’.";
            _question10 = "What is your favorite thing to do with friends?";
            _subQuestion12 = "DnD? What is that?";
            _subQuestion13 = "Oh nice, do you dm or just play?";
            _subQuestion14 = "DnD? You’re a nerd.";

            // Answers Sam
            _answers1 = "Yeah, first time speeddating haha… ";
            _answers2 = "Haha… I know…";
            _answers3 = "… … …";
            _answers4 = "I’m twentyone almost twentytwo.";
            _answers5 = "I’m a student, I’m studying to become a vet.";
            _subAnswer1 = "Yes all animals are great. The once I like the most are reptiles like \n lizards.";
            _subAnswer2 = "Yes I own two, also a snake.";
            _subAnswer3 = "That’s fine.";
            _subAnswer4 = "You don’t like them…";
            _answers6 = "I guess reading.";
            _subAnswer5 = "Mostly fantasy… a-and you?";
            _subAnswer6 = "Really, maybe you can recommend me some books.";
            _subAnswer7 = "Ah I know uhm.. a few book like that.";
            _subAnswer8 = "I see…";
            _answers7 = "Really, it is one of my favorites. Glad you like it.";
            _answers8 = "Like a… housecat. Just napping in the sun on a nice pillow sounds \n nice.";
            _answers9 = "Size, you mean clothing right?";
            _subAnswer9 = "Oh, just a M…";
            _subAnswer10 = "Uhm… 1.65 I think…";
            _subAnswer11 = "W-why would you want to know that!";
            _answers10 = "I like to play DnD with them.";
            _subAnswer12 = "Oh it is a kind of game.";
            _subAnswer13 = "I prefer just playing… I'm not really suited for dming… ";
            _subAnswer14 = "What? No…";

            _textboxText = "Hi, I'm Sam. So...";
            _text1 = _question1;
            _text2 = _question2;
            _text3 = _question3;
            _charater.currentFrame = _shyEmotionSam;
        }
        else if (_gender == _male)
        {
            // Questions Isabella
            _question1 = "Yeah.";
            _question2 = "No.";
            _question3 = "I talk to a few already.";
            _question4 = "Yeah I love alcohol!";
            _question5 = "Yeah, the opportunity to meet new people and talk \n to friends is great.";
            _question6 = "No, staying at home is better.";
            _subQuestion1 = "Netflix or other series.";
            _subQuestion2 = "Just a bit of reading.";
            _subQuestion3 = "Staring at the celling contemplating life and existence \n itself.";
            _subQuestion4 = "My best friend, I need someone to spend time with.";
            _subQuestion5 = "Phone, even if I can’t call for help I can keep myself \n entertained.";
            _subQuestion6 = "A gun, to kill myself and this stupid question.";
            _subQuestion7 = "So is your size?";
            _subQuestion8 = "What do you do for a living?";
            _question7 = "What do you like to do on the weekends?";
            _question8 = "Yes.";
            _question9 = "No, but I love to do other kinds of sports.";
            _subQuestion9 = "No, I prefer staying home.";

            // Answers Isabella
            _answers1 = "Aww don’t be nervous. It is fun. So anyway, you like going out? \n Like going for a drink?";
            _answers2 = "Well let’s hope today is the last time for both of us. So anyway, you \n like going out? Like going for a drink?";
            _answers3 = "So you’re getting the hang of it, that’s good. So anyway, you like \n going out? Like going for a drink?";
            _answers4 = "I didn’t mean the alcohol necessary…";
            _answers5 = "Me too, going out and socializing is amazing. I know this amazing \n bar, the atmosphere is so great. And there are so many nice people. \n Maybe we can go there after this.";
            _answers6 = "Staying at home? That’s too bad. I personally like going out a lot. \n But what do you do then when you stay home?";
            _subAnswer1 = "Watching stuff. I like to do that when I don’t have anything to do. \n There are so many interesting series to watch but so little time to watch them.";
            _subAnswer2 = "Reading huh. Sounds nice, sitting comfy at home getting sucked into \n a story. Maybe I should read more myself. Maybe you can recommend \n some titles later.";
            _subAnswer3 = "Are you okay? Maybe you should talk to someone about it.";
            _subAnswer4 = "So it may be a bit cliché but it is an interesting question. What would \n you take with you when going to a deserted island?";
            _subAnswer5 = "Sounds like a fun time. Mind if I you as well. A island is not really \n deserted when people are there. And together it will be easier to \n leave.";
            _subAnswer6 = "Guess that is important. But what if there is no internet, it can’t really \n do anything without it.";
            _subAnswer7 = "Well you didn’t have to say it like that…";
            _subAnswer8 = "Tell you mine if you tell me yours.";
            _answers7 = "I’m a biology teacher. It is both beautiful and sad when a year passes \n and you have to say goodbye to another group. But I love teaching \n the children and seeing them grow as humans.";
            _answers8 = "I like climbing. Usually indoors but I love to climb real mountains. \n I have done it a few times already. You feel so alive when you’re at \n the top. Do you like climbing?";
            _answers9 = "Let go climbing together after this. We can go to a hall close to here \n or maybe we can go to a real mountain. I’m planning to go to Nepal \n next to climb Mera Peak.";
            _subAnswer9 = "That’s nice. Moving around makes you feel good, right? I don’t mind \n other kinds of exercise but personally climbing is my favorite.";
            _subAnswer10 = "That’s too bad.";

            _textboxText = "Hello, I’m Isabella. Nice to meet you. So is this your first time speed \n dating?";
            _text1 = _question1;
            _text2 = _question2;
            _text3 = _question3;
            _charater.currentFrame = _neutralEmotionIsabella;
        }

        _button1 = new Button(1300, 500, _text1);
        AddChild(_button1);
        _button2 = new Button(1300, 650, _text2);
        AddChild(_button2);
        _button3 = new Button(1300, 800, _text3);
        AddChild(_button3);
    }

    void Update()
    {
        if (_gender == _female)
        {
            SelectAnswersSam();
        }
        else if (_gender == _male)
        {
            SelectAnswersIsabella();
        }

        CheckTimer();
        CheckEnding();
    }

    void CheckTimer()
    {
        _frametimer += 1;

        if (_frametimer == 750 || _frametimer == 1500 || _frametimer == 2250 || _frametimer == 3000 || _frametimer == 3750 || _frametimer == 4500 || _frametimer == 5250)
        {
            _clock.currentFrame += 1;
        }
        else if (_frametimer == 6000)
        {
            _frametimer = 6000;
            _clock.currentFrame = 8;
            _text1 = "*Well, damn...*";
            _text2 = " ";
            _text3 = " ";
            _timeup.Play();

            if (_text1 == "*Well, damn...*" && _gender == _male)
            {
                _textboxText = "Oh… Its time… um goodbye…";
            }
            else if (_text1 == "*Well, damn...*" && _gender == _female)
            {
                _textboxText = "What, time already. Well bye-bye.";
            }

            _textBox.UpdateText(_textboxText);
            _button1.UpdateText(_text1);
            _button2.UpdateText(_text2);
            _button3.UpdateText(_text3);
        }
    }

    /// <summary>
    /// Checks when the date ends
    /// </summary>
    void CheckEnding()
    {
        if (_ending == true)
        {
            if (_dateSuccess >= 0 && _dateSuccess < 10)
            {
                _textboxText = "NEUTRAL ENDING";
            }
            else if (_dateSuccess >= 10)
            {
                _textboxText = "GOOD ENDING";
            }
            else if (_dateSuccess < 0)
            {
                _textboxText = "BAD ENDING";
            }
        }
    }

    /// <summary>
    /// Dialogue tree Sam
    /// </summary>
    void SelectAnswersSam()
    {
        if (_text1 == "*Say goodbyes*")
        {
            if (_dateSuccess >= 0 && _dateSuccess < 8)
            {
                _textboxText = "NEUTRAL ENDING";
            }
            else if (_dateSuccess > 8)
            {
                _textboxText = "GOOD ENDING";
            }
            else if (_dateSuccess < 0)
            {
                _textboxText = "BAD ENDING";
            }
        }

        if (Input.GetMouseButtonDown(0) && Input.mouseX > _button1.x && Input.mouseX < _button1.x + _button1.width && Input.mouseY > _button1.y && Input.mouseY < _button1.y + _button1.height)
        {
            switch (_text1)
            {
                case "Nervous?":
                    _charater.currentFrame = _shyEmotionSam;
                    _text1 = _question4;
                    _text2 = _question5;
                    _text3 = _question6;
                    _textboxText = _answers1;
                    _dateSuccess += 1;
                    break;
                case "How old are you?":
                    _charater.currentFrame = _neutralEmotionSam;
                    _text1 = _question7;
                    _text2 = _question8;
                    _text3 = _question9;
                    _textboxText = _answers4;
                    break;
                case "I like your shirt.":
                    _charater.currentFrame = _excitedEmotionSam;
                    _text1 = _question10;
                    _text2 = " ";
                    _text3 = " ";
                    _textboxText = _answers7;
                    _dateSuccess += 2;
                    break;
                case "Lizards are cool. Do you have any yourself?":
                    _charater.currentFrame = _excitedEmotionSam;
                    _text1 = _question7;
                    _text2 = _question8;
                    _text3 = _question9;
                    _textboxText = _subAnswer2;
                    _dateSuccess += 2;
                    break;
                case "Probably fantasy as well.":
                    _charater.currentFrame = _excitedEmotionSam;
                    _text1 = _question7;
                    _text2 = _question8;
                    _text3 = _question9;
                    _textboxText = _subAnswer6;
                    _dateSuccess += 2;
                    break;
                case "Yeah, clothing.":
                    _charater.currentFrame = _neutralEmotionSam;
                    _text1 = _question10;
                    _text2 = " ";
                    _text3 = " ";
                    _textboxText = _subAnswer9;
                    break;
                case "What is your favorite thing to do with friends?":
                    _charater.currentFrame = _neutralEmotionSam;
                    _text1 = _subQuestion12;
                    _text2 = _subQuestion13;
                    _text3 = _subQuestion14;
                    _textboxText = _answers10;
                    break;
                case "DnD? What is that?":
                    _charater.currentFrame = _neutralEmotionSam;
                    _text1 = "*Say goodbyes*";
                    _text2 = " ";
                    _text3 = " ";
                    _textboxText = _subAnswer12;
                    break;
                case "*Say goodbyes*":
                    _ending = true;
                    break;
                case "*Well, damn...*":
                    _ending = true;
                    break;
                default:
                    break;
            }
        }
        else if (Input.GetMouseButtonDown(0) && Input.mouseX > _button2.x && Input.mouseX < _button2.x + _button2.width && Input.mouseY > _button2.y && Input.mouseY < _button2.y + _button2.height)
        {
            switch (_text2)
            {
                case "Don’t be shy, I don’t bite":
                    _charater.currentFrame = _shyEmotionSam;
                    _text1 = _question4;
                    _text2 = _question5;
                    _text3 = _question6;
                    _textboxText = _answers2;
                    _dateSuccess += 1;
                    break;
                case "What do you do for a living?":
                    _charater.currentFrame = _neutralEmotionSam;
                    _text1 = _question4;
                    _text2 = _subQuestion1;
                    _text3 = _question6;
                    _textboxText = _answers5;
                    break;
                case "You must like animals?":
                    _charater.currentFrame = _excitedEmotionSam;
                    _text1 = _subQuestion2;
                    _text2 = _subQuestion3;
                    _text3 = _subQuestion4;
                    _textboxText = _subAnswer1;
                    _dateSuccess += 2;
                    break;
                case "I guess I’m neutral… Not like but not dislike.":
                    _charater.currentFrame = _neutralEmotionSam;
                    _text1 = _question7;
                    _text2 = _question8;
                    _text3 = _question9;
                    _textboxText = _subAnswer3;
                    break;
                case "Romance for sure.":
                    _charater.currentFrame = _shyEmotionSam;
                    _text1 = _question7;
                    _text2 = _question8;
                    _text3 = _question9;
                    _textboxText = _subAnswer7;
                    _dateSuccess += 1;
                    break;
                case "If you were a cat, what kind of cat would you be?":
                    _charater.currentFrame = _neutralEmotionSam;
                    _text1 = _question10;
                    _text2 = " ";
                    _text3 = " ";
                    _textboxText = _answers8;
                    break;
                case "No, I mean how tall you are.":
                    _charater.currentFrame = _neutralEmotionSam;
                    _text1 = _question10;
                    _text2 = " ";
                    _text3 = " ";
                    _textboxText = _subAnswer10;
                    break;
                case "Oh nice, do you dm or just play?":
                    _charater.currentFrame = _excitedEmotionSam;
                    _text1 = "*Say goodbyes*";
                    _text2 = " ";
                    _text3 = " ";
                    _textboxText = _subAnswer13;
                    _dateSuccess += 2;
                    break;
                case "*Say goodbyes*":
                    _ending = true;
                    break;
                default:
                    break;
            }
        }
        else if (Input.GetMouseButtonDown(0) && Input.mouseX > _button3.x && Input.mouseX < _button3.x + _button3.width && Input.mouseY > _button3.y && Input.mouseY < _button3.y + _button3.height)
        {
            switch (_text3)
            {
                case "… … …":
                    _charater.currentFrame = _uninterestedEmotionSam;
                    _text1 = _question4;
                    _text2 = _question5;
                    _text3 = _question6;
                    _textboxText = _answers3;
                    _dateSuccess -= 1;
                    break;
                case "What do you like to do on the weekends?":
                    _charater.currentFrame = _shyEmotionSam;
                    _text1 = _question4;
                    _text2 = _question5;
                    _text3 = _subQuestion5;
                    _textboxText = _answers6;
                    _dateSuccess += 1;
                    break;
                case "Oh those things…":
                    _charater.currentFrame = _insultedEmotionSam;
                    _text1 = _question7;
                    _text2 = _question8;
                    _text3 = _question9;
                    _textboxText = _subAnswer4;
                    _dateSuccess -= 2;
                    break;
                case "What kind of books do you read?":
                    _charater.currentFrame = _shyEmotionSam;
                    _text1 = _subQuestion6;
                    _text2 = _subQuestion7;
                    _text3 = _subQuestion8;
                    _textboxText = _subAnswer5;
                    _dateSuccess += 1;
                    break;
                case "Non-fiction.":
                    _charater.currentFrame = _uninterestedEmotionSam;
                    _text1 = _question7;
                    _text2 = _question8;
                    _text3 = _question9;
                    _textboxText = _subAnswer8;
                    _dateSuccess -= 1;
                    break;
                case "What size are you?":
                    _charater.currentFrame = _uninterestedEmotionSam;
                    _text1 = _subQuestion9;
                    _text2 = _subQuestion10;
                    _text3 = _subQuestion11;
                    _textboxText = _answers9;
                    _dateSuccess -= 1;
                    break;
                case "No, your ‘size’.":
                    _charater.currentFrame = _insultedEmotionSam;
                    _text1 = "*Say goodbyes*";
                    _text2 = " ";
                    _text3 = " ";
                    _textboxText = _subAnswer11;
                    _dateSuccess -= 2;
                    break;
                case "DnD? You’re a nerd.":
                    _charater.currentFrame = _insultedEmotionSam;
                    _text1 = "*Say goodbyes*";
                    _text2 = " ";
                    _text3 = " ";
                    _textboxText = _subAnswer14;
                    _dateSuccess -= 1;
                    break;
                case "*Say goodbyes*":
                    _ending = true;
                    break;
                default:
                    break;
            }
        }

        _textBox.UpdateText(_textboxText);
        _button1.UpdateText(_text1);
        _button2.UpdateText(_text2);
        _button3.UpdateText(_text3);
    }

    /// <summary>
    /// Dialogue tree Isabella
    /// </summary>
    void SelectAnswersIsabella()
    {
        if (Input.GetMouseButtonDown(0) && Input.mouseX > _button1.x && Input.mouseX < _button1.x + _button1.width && Input.mouseY > _button1.y && Input.mouseY < _button1.y + _button1.height)
        {
            switch (_text1)
            {
                case "Yeah.":
                    _charater.currentFrame = _excitedEmotionIsabella;
                    _text1 = _question4;
                    _text2 = _question5;
                    _text3 = _question6;
                    _textboxText = _answers1;
                    _dateSuccess += 2;
                    break;
                case "Yeah I love alcohol!":
                    _charater.currentFrame = _shyEmotionIsabella;
                    _text1 = "*Listening*";
                    _text2 = " ";
                    _text3 = " ";
                    _textboxText = _answers4;
                    _dateSuccess -= 1;
                    break;
                case "*Listening*":
                    _charater.currentFrame = _neutralEmotionIsabella;
                    _text1 = _subQuestion4;
                    _text2 = _subQuestion5;
                    _text3 = _subQuestion6;
                    _textboxText = _subAnswer4;
                    break;
                case "Netflix or other series.":
                    _charater.currentFrame = _excitedEmotionIsabella;
                    _text1 = "*Listening*";
                    _text2 = " ";
                    _text3 = " ";
                    _textboxText = _subAnswer1;
                    _dateSuccess += 2;
                    break;
                case "My best friend, I need someone to spend time with.":
                    _charater.currentFrame = _excitedEmotionIsabella;
                    _text1 = _subQuestion7;
                    _text2 = _subQuestion8;
                    _text3 = _question7;
                    _textboxText = _subAnswer5;
                    _dateSuccess += 2;
                    break;
                case "So is your size?":
                    _charater.currentFrame = _shyEmotionIsabella;
                    _text1 = "*Say goodbyes*";
                    _text2 = " ";
                    _text3 = " ";
                    _textboxText = _subAnswer8;
                    break;
                case "Yes.":
                    _charater.currentFrame = _excitedEmotionIsabella;
                    _text1 = "*Say goodbyes*";
                    _text2 = " ";
                    _text3 = " ";
                    _textboxText = _answers9;
                    _dateSuccess += 2;
                    break;
                case "*Say goodbyes*":
                    _ending = true;
                    break;
                case "*Well, damn...*":
                    _ending = true;
                    break;
                default:
                    break;
            }
        }
        else if (Input.GetMouseButtonDown(0) && Input.mouseX > _button2.x && Input.mouseX < _button2.x + _button2.width && Input.mouseY > _button2.y && Input.mouseY < _button2.y + _button2.height)
        {
            switch (_text2)
            {
                case "No.":
                    _charater.currentFrame = _neutralEmotionIsabella;
                    _text1 = _question4;
                    _text2 = _question5;
                    _text3 = _question6;
                    _textboxText = _answers2;
                    break;
                case "Yeah, the opportunity to meet new people and talk \n to friends is great.":
                    _charater.currentFrame = _excitedEmotionIsabella;
                    _text1 = "*Listening*";
                    _text2 = " ";
                    _text3 = " ";
                    _textboxText = _answers5;
                    _dateSuccess += 2;
                    break;
                case "*Listening*":
                    _charater.currentFrame = _neutralEmotionIsabella;
                    _text1 = _subQuestion4;
                    _text2 = _subQuestion5;
                    _text3 = _subQuestion6;
                    _textboxText = _subAnswer4;
                    break;
                case "Just a bit of reading.":
                    _charater.currentFrame = _neutralEmotionIsabella;
                    _text1 = "*Listening*";
                    _text2 = " ";
                    _text3 = " ";
                    _textboxText = _subAnswer2;
                    break;
                case "Phone, even if I can’t call for help I can keep myself \n entertained.":
                    _charater.currentFrame = _neutralEmotionIsabella;
                    _text1 = _subQuestion7;
                    _text2 = _subQuestion8;
                    _text3 = _question7;
                    _textboxText = _subAnswer6;
                    break;
                case "What do you do for a living?":
                    _charater.currentFrame = _excitedEmotionIsabella;
                    _text1 = "*Say goodbyes*";
                    _text2 = " ";
                    _text3 = " ";
                    _textboxText = _answers7;
                    _dateSuccess += 2;
                    break;
                case "No, but I love to do other kinds of sports.":
                    _charater.currentFrame = _neutralEmotionIsabella;
                    _text1 = "*Say goodbyes*";
                    _text2 = " ";
                    _text3 = " ";
                    _textboxText = _subAnswer9;
                    break;
                case "*Say goodbyes*":
                    _ending = true;
                    break;
                default:
                    break;
            }
        }
        else if (Input.GetMouseButtonDown(0) && Input.mouseX > _button3.x && Input.mouseX < _button3.x + _button3.width && Input.mouseY > _button3.y && Input.mouseY < _button3.y + _button3.height)
        {
            switch (_text3)
            {
                case "I talk to a few already.":
                    _charater.currentFrame = _neutralEmotionIsabella;
                    _text1 = _question4;
                    _text2 = _question5;
                    _text3 = _question6;
                    _textboxText = _answers3;
                    break;
                case "No, staying at home is better.":
                    _charater.currentFrame = _insultedEmotionIsabella;
                    _text1 = _subQuestion1;
                    _text2 = _subQuestion2;
                    _text3 = _subQuestion3;
                    _textboxText = _answers6;
                    _dateSuccess -= 2;
                    break;
                case "Staring at the celling contemplating life and existence itself.":
                    _charater.currentFrame = _insultedEmotionIsabella;
                    _text1 = "*Listening*";
                    _text2 = " ";
                    _text3 = " ";
                    _textboxText = _subAnswer3;
                    _dateSuccess -= 2;
                    break;
                case "*Listening*":
                    _charater.currentFrame = _neutralEmotionIsabella;
                    _text1 = _subQuestion4;
                    _text2 = _subQuestion5;
                    _text3 = _subQuestion6;
                    _textboxText = _subAnswer4;
                    break;
                case "A gun, to kill myself and this stupid question.":
                    _charater.currentFrame = _insultedEmotionIsabella;
                    _text1 = _subQuestion7;
                    _text2 = _subQuestion8;
                    _text3 = _subQuestion9;
                    _textboxText = _subAnswer7;
                    _dateSuccess -= 2;
                    break;
                case "What do you like to do on the weekends?":
                    _charater.currentFrame = _excitedEmotionIsabella;
                    _text1 = _question8;
                    _text2 = _question9;
                    _text3 = _subQuestion9;
                    _textboxText = _answers8;
                    _dateSuccess += 2;
                    break;
                case "No, I prefer staying home.":
                    _charater.currentFrame = _uninterestedEmotionIsabella;
                    _text1 = "*Say goodbyes*";
                    _text2 = " ";
                    _text3 = " ";
                    _textboxText = _subAnswer10;
                    _dateSuccess -= 1;
                    break;
                case "*Say goodbyes*":
                    _ending = true;
                    break;
                default:
                    break;
            }
        }

        _textBox.UpdateText(_textboxText);
        _button1.UpdateText(_text1);
        _button2.UpdateText(_text2);
        _button3.UpdateText(_text3);
    }

    static void Main()                          // Main() is the first method that's called when the program is run
    {
        new MyGame().Start();                   // Create a "MyGame" and start it
    }
}