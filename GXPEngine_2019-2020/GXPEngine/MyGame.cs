using System;									// System contains a lot of default C# libraries 
using System.Drawing;                           // System.Drawing contains a library used for canvas drawing below
using GXPEngine;								// GXPEngine contains the engine
using System.Collections;
using System.Collections.Generic;


//=======================================================================
//                                              MyGame Class
//=======================================================================
public class MyGame : Game
{
    Text textBox1;
    Text textBox2;
    Text textBox3;
    Text textBox4;
    Text textBox5;
    Text textBox6;
    Text textBox7;

    Text HobbyTextBox1;
    Text HobbyTextBox2;
    Text HobbyTextBox3;
    Text HobbyTextBox4;
    Text HobbyTextBox5;
    Text HobbyTextBox6;
    Text HobbyTextBox7;

    int _BoxesXHobbies = 500;
    int _BoxesYHobbies = 360;
    int _BoxesXInterests = 500;
    int _BoxesYInterests = 360;

    int _musicVolume;
    int _sfxVolume;

    int ScreenNumber = 0;

    background BackgroundProfile;
    background BackgroundSettings;
    background BackgroundPersonality;

    UpAndDownButton MusicVolumeButton;
    Switch GenderSwitch;
    GeneralText MusicVolumeText;

    UpAndDownButton SFXVolumeButton;
    GeneralText SFXVolumeText;

    List<InterestList> ListOfInterests = new List<InterestList>();
    List<Text> ListOfText = new List<Text>();
    List<Text> InterestList = new List<Text>();
    List<InterestList> ListOfHobbies = new List<InterestList>();
    List<Text> HobbiesList = new List<Text>();

    NextButton Next;

    Boolean _profileActive;
    Boolean _personalityActive;
    Boolean _settingsActive;


    //=======================================================================
    //                                              MyGame();
    //=======================================================================
    public MyGame() : base(1920, 1080, false)       // Create a window that's 800x600 and NOT fullscreen
    {
        Next = new NextButton();
        Next.SetXY(900, 900);
        AddChild(Next);

       
        PersonalityPageLoader();
        ProfilePageLoader();
        SettingsLoader();
     
        BackgroundPersonality.visible = false;
        BackgroundProfile.visible = false;
        BackgroundSettings.visible = false;
    }

    //=======================================================================
    //                                              Update();
    //=======================================================================
    void Update()
    {

        //Console.WriteLine(ScreenNumber);

        SettingsValues();

        if (ScreenNumber == 0)
        {
            PersonalityPage();
        }

        if (ScreenNumber == 1)
        {
            ProfilePage();
        }

        if (ScreenNumber == 2)
        {        
            SettingsPage();
        }



        if (Input.GetKeyDown(Key.Q))
        {
            ScreenNumber = 0;
        }
        if (Input.GetKeyDown(Key.W))
        {
            ScreenNumber = 1;

        }
        if (Input.GetKeyDown(Key.E))
        {
            ScreenNumber = 2;

        }

        HideSettings();
        HideProfile();
        HidePersonality();

       // Console.WriteLine(_settingsActive);


    }


    //=======================================================================
    //                                              Main();
    //=======================================================================
    static void Main()                          // Main() is the first method that's called when the program is run
    {
        new MyGame().Start();                   // Create a "MyGame" and start it
    }

    //=======================================================================//   
    //                                    Methods for Loading                                                     //SettingsValues(); and -Loader(); should be put inside MyGame();, The others in Update();
    //=======================================================================//
    public void SettingsValues()
    {

        _musicVolume = MusicVolumeButton.ReturnValueInt();
        _sfxVolume = SFXVolumeButton.ReturnValueInt();

        MusicVolumeButton._active = _settingsActive;
        SFXVolumeButton._active = _settingsActive;

        for (int i = 0; i < ListOfHobbies.Count; i++)
        {
            ListOfHobbies[i]._active = _profileActive;
            Console.WriteLine(ListOfHobbies[i]._active);

        }

        for (int i = 0; i < ListOfInterests.Count; i++)
        {
            ListOfInterests[i]._active = _personalityActive;
            Console.WriteLine(ListOfInterests[i]._active);

        }

    }
    public void ProfilePageLoader()
    {

        BackgroundProfile = new background("BG profile");
        AddChild(BackgroundProfile);

        for (int j = 0; j < 7; j++)
        {
            if (j <= 4)
            {
                var Hobby = new InterestList(_BoxesXHobbies, _BoxesYHobbies + (70 * j), j + 1, 1);
                AddChild(Hobby);
                ListOfHobbies.Add(Hobby);
            }

            if (j > 4)
            {
                _BoxesXHobbies = 700;
                var Hobby = new InterestList(_BoxesXHobbies, _BoxesYHobbies + (70 * (j - 5)), j + 1, 2);
                AddChild(Hobby);
                ListOfHobbies.Add(Hobby);
            }
        }

        GenderSwitch = new Switch(width / 2 - 268, 878);
        AddChild(GenderSwitch);

        HobbyTextBox1 = new Text(ListOfHobbies[0], "Intellectueel", HobbiesList);
        AddChild(HobbyTextBox1);
        HobbyTextBox2 = new Text(ListOfHobbies[1], "Veel passie", HobbiesList);
        AddChild(HobbyTextBox2);
        HobbyTextBox3 = new Text(ListOfHobbies[2], "Deppresief", HobbiesList);
        AddChild(HobbyTextBox3);
        HobbyTextBox4 = new Text(ListOfHobbies[3], "Langzaam", HobbiesList);
        AddChild(HobbyTextBox4);
        HobbyTextBox5 = new Text(ListOfHobbies[4], "Help, I'm captive", HobbiesList);
        AddChild(HobbyTextBox5);
        HobbyTextBox6 = new Text(ListOfHobbies[5], "Help, I'm 6", HobbiesList);
        AddChild(HobbyTextBox6);
        HobbyTextBox7 = new Text(ListOfHobbies[6], "Help, I'm captive", HobbiesList);
        AddChild(HobbyTextBox7);
    }
    public void SettingsLoader()
    {
        

        BackgroundSettings= new background("BG settings");
        AddChild(BackgroundSettings);

        MusicVolumeButton = new UpAndDownButton();
        MusicVolumeButton.SetXY(1155, 338);
        AddChild(MusicVolumeButton);

        SFXVolumeButton = new UpAndDownButton();
        SFXVolumeButton.SetXY(1155, 456);
        AddChild(SFXVolumeButton);

        MusicVolumeText = new GeneralText(MusicVolumeButton);
        MusicVolumeText.SetXY(MusicVolumeButton.x - 250, MusicVolumeButton.y - 182);
        AddChild(MusicVolumeText);

        SFXVolumeText = new GeneralText(SFXVolumeButton);
        SFXVolumeText.SetXY(SFXVolumeButton.x - 250, SFXVolumeButton.y - 182);
        AddChild(SFXVolumeText);



    }
    public void PersonalityPageLoader()
    {

        BackgroundPersonality = new background("BG personality");
        AddChild(BackgroundPersonality);


        for (int j = 0; j < 7; j++)
        {
            if (j <= 4)
            {
                var Interests = new InterestList(_BoxesXInterests, _BoxesYInterests + (70 * j), j + 1, 1);
                AddChild(Interests);
                ListOfInterests.Add(Interests);
            }

            if (j > 4)
            {
                _BoxesXInterests = 700;
                var Interests = new InterestList(_BoxesXInterests, _BoxesYInterests + (70 * (j - 5)), j + 1, 2);
                AddChild(Interests);
                ListOfInterests.Add(Interests);
            }
        }

        textBox1 = new Text(ListOfInterests[0], "Persoonlijkheid 1", InterestList);
        AddChild(textBox1);
        textBox2 = new Text(ListOfInterests[1], "Persoonlijkheid 2", InterestList);
        AddChild(textBox2);
        textBox3 = new Text(ListOfInterests[2], "Persoonlijkheid 3", InterestList);
        AddChild(textBox3);
        textBox4 = new Text(ListOfInterests[3], "Persoonlijkheid 4", InterestList);
        AddChild(textBox4);
        textBox5 = new Text(ListOfInterests[4], "Persoonlijkheid 5", InterestList);
        AddChild(textBox5);
        textBox6 = new Text(ListOfInterests[5], "Persoonlijkheid 6", InterestList);
        AddChild(textBox6);
        textBox7 = new Text(ListOfInterests[6], "Persoonlijkheid 7", InterestList);
        AddChild(textBox7);

       


    }
    public void ProfilePage()
    {
        HobbyTextBox1.CheckForList(HobbiesList);
        HobbyTextBox2.CheckForList(HobbiesList);
        HobbyTextBox3.CheckForList(HobbiesList);
        HobbyTextBox4.CheckForList(HobbiesList);
        HobbyTextBox5.CheckForList(HobbiesList);
        HobbyTextBox6.CheckForList(HobbiesList);
        HobbyTextBox7.CheckForList(HobbiesList);

        //Console.WriteLine(InterestList.Count);
        if (Input.GetKeyDown(Key.L))
        {
            //InterestList.ToArray();
            Console.WriteLine("it works 1/2");
            for (int i = 0; i < HobbiesList.Count; i++)
            {
                Console.WriteLine(HobbiesList[i].GetDisplayedText());
                Console.WriteLine("it works-ish");
            }
        }
    }
    public void SettingsPage()
    {





    }
    public void PersonalityPage()
    {
        textBox1.CheckForList(InterestList);
        textBox2.CheckForList(InterestList);
        textBox3.CheckForList(InterestList);
        textBox4.CheckForList(InterestList);
        textBox5.CheckForList(InterestList);
        textBox6.CheckForList(InterestList);
        textBox7.CheckForList(InterestList);

        //Console.WriteLine(InterestList.Count);
        if (Input.GetKeyDown(Key.L))
        {
            //InterestList.ToArray();
            Console.WriteLine("it works 1/2");
            for (int i = 0; i < InterestList.Count; i++)
            {
                Console.WriteLine(InterestList[i].GetDisplayedText());
                Console.WriteLine("it works-ish");
            }
        }
    }

    public void HideProfile()
    {
        if (ScreenNumber != 1)
        {
            GenderSwitch.visible = false;
            HobbyTextBox1.visible = false;
            HobbyTextBox2.visible = false;
            HobbyTextBox3.visible = false;
            HobbyTextBox4.visible = false;
            HobbyTextBox5.visible = false;
            HobbyTextBox6.visible = false;
            HobbyTextBox7.visible = false;

            ListOfHobbies[0].visible = false;
            ListOfHobbies[1].visible = false;
            ListOfHobbies[2].visible = false;
            ListOfHobbies[3].visible = false;
            ListOfHobbies[4].visible = false;
            ListOfHobbies[5].visible = false;
            ListOfHobbies[6].visible = false;

            _profileActive = false;


            BackgroundProfile.visible = false;

        }
        else
        {
            GenderSwitch.visible = true;
            HobbyTextBox1.visible = true;
            HobbyTextBox2.visible = true;
            HobbyTextBox3.visible = true;
            HobbyTextBox4.visible = true;
            HobbyTextBox5.visible = true;
            HobbyTextBox6.visible = true;
            HobbyTextBox7.visible = true;

            ListOfHobbies[0].visible = true;
            ListOfHobbies[1].visible = true;
            ListOfHobbies[2].visible = true;
            ListOfHobbies[3].visible = true;
            ListOfHobbies[4].visible = true;
            ListOfHobbies[5].visible = true;
            ListOfHobbies[6].visible = true;

            _profileActive = true;
            BackgroundProfile.visible = true;

        }


    }

    public void HideSettings()
    {
        if (ScreenNumber != 2)
        {
            MusicVolumeButton.visible = false;
            SFXVolumeButton.visible = false;
            MusicVolumeText.visible = false;
            SFXVolumeText.visible = false;
            _settingsActive = false;
            BackgroundSettings.visible = false;
        }
        else
        {
            MusicVolumeButton.visible = true;
            SFXVolumeButton.visible = true;
            MusicVolumeText.visible = true;
            SFXVolumeText.visible = true;

            _settingsActive = true;

            BackgroundSettings.visible = true;
        }
    }

    public void HidePersonality()
    {
        if (ScreenNumber != 0)
        {
            //GenderSwitch.visible = false;
            textBox1.visible = false;
            textBox2.visible = false;
            textBox3.visible = false;
            textBox4.visible = false;
            textBox5.visible = false;
            textBox6.visible = false;
            textBox7.visible = false;
            _personalityActive = false;
            BackgroundPersonality.visible = false;
        }
        else
        {

            
           // GenderSwitch.visible = true;
            textBox1.visible = true;
            textBox2.visible = true;
            textBox3.visible = true;
            textBox4.visible = true;
            textBox5.visible = true;
            textBox6.visible = true;
            textBox7.visible = true;
            _personalityActive = true;
            BackgroundPersonality.visible = true;




        }


    }


}