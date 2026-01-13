using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class LvlBuilder : MonoBehaviour
{
    [Header("Buttons")]
    public Button Button1;
    public Button Button2;
    public Button Button3;
    public Button Button4;
    public Button Button5;
    public Button Button6;

    [Header("Bools")]
    public bool Lvl1Selected;
    public bool Lvl2Selected;
    public bool Lvl3Selected;
    public bool Lvl4Selected;
    public bool Lvl5Selected;
    public bool Lvl6Selected;

    private void Awake()
    {
        
    }

    public void SelectedLvl1() 
    {
        Lvl1Selected = true;
        Lvl2Selected = false;
        Lvl3Selected = false;
        Lvl4Selected = false;
        Lvl5Selected = false;
        Lvl6Selected = false;

        ColorBlock Green = Button1.colors;
        Green.normalColor = Color.green;
        Button1.colors = Green;

        ColorBlock White = Button2.colors;
        White.normalColor = Color.white;
        Button2.colors = White;
        Button3.colors = White;
        Button4.colors = White;
        Button5.colors = White;
        Button6.colors = White;
    }

    public void SelectedLvl2()
    {
        Lvl1Selected = false;
        Lvl2Selected = true;
        Lvl3Selected = false;
        Lvl4Selected = false;
        Lvl5Selected = false;
        Lvl6Selected = false;

        ColorBlock Green = Button2.colors;
        Green.normalColor = Color.green;
        Button2.colors = Green;

        ColorBlock White = Button3.colors;
        White.normalColor = Color.white;
        Button3.colors = White;
        Button1.colors = White;
        Button4.colors = White;
        Button5.colors = White;
        Button6.colors = White;

    }

    public void SelectedLvl3()
    {
        Lvl1Selected = false;
        Lvl2Selected = false;
        Lvl3Selected = true;
        Lvl4Selected = false;
        Lvl5Selected = false;
        Lvl6Selected = false;


        ColorBlock Green = Button3.colors;
        Green.normalColor = Color.green;
        Button3.colors = Green;

        ColorBlock White = Button4.colors;
        White.normalColor = Color.white;
        Button1.colors = White;
        Button2.colors = White;
        Button4.colors = White;
        Button5.colors = White;
        Button6.colors = White;
    }

    public void SelectedLvl4()
    {
        Lvl1Selected = false;
        Lvl2Selected = false;
        Lvl3Selected = false;
        Lvl4Selected = true;
        Lvl5Selected = false;
        Lvl6Selected = false;


        ColorBlock Green = Button4.colors;
        Green.normalColor = Color.green;
        Button4.colors = Green;

        ColorBlock White = Button5.colors;
        White.normalColor = Color.white;
        Button1.colors = White;
        Button2.colors = White;
        Button3.colors = White;
        Button4.colors = White;
        Button6.colors = White;
    }
    public void SelectedLvl5()
    {
        Lvl1Selected = false;
        Lvl2Selected = false;
        Lvl3Selected = false;
        Lvl4Selected = false;
        Lvl5Selected = true;
        Lvl6Selected = false;


        ColorBlock Green = Button5.colors;
        Green.normalColor = Color.green;
        Button5.colors = Green;

        ColorBlock White = Button6.colors;
        White.normalColor = Color.white;
        Button1.colors = White;
        Button2.colors = White;
        Button3.colors = White;
        Button4.colors = White;
        Button6.colors = White;
    }

    public void SelectedLvl6()
    {
        Lvl1Selected = false;
        Lvl2Selected = false;
        Lvl3Selected = false;
        Lvl4Selected = false;
        Lvl5Selected = false;
        Lvl6Selected = true;


        ColorBlock Green = Button6.colors;
        Green.normalColor = Color.green;
        Button6.colors = Green;

        ColorBlock White = Button5.colors;
        White.normalColor = Color.white;
        Button1.colors = White;
        Button2.colors = White;
        Button3.colors = White;
        Button4.colors = White;
        Button5.colors = White;
    }
}
