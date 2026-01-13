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

        //Button1.GetComponent<Image>().color = Color.green;
        ColorBlock colorGreen = Button1.colors;
        colorGreen.pressedColor = Color.green;
        Button1.colors = colorGreen;

    }

    public void SelectedLvl2()
    {
        Lvl1Selected = false;
        Lvl2Selected = true;
        Lvl3Selected = false;
        Lvl4Selected = false;
        Lvl5Selected = false;
        Lvl6Selected = false;
    }

    public void SelectedLvl3()
    {
        Lvl1Selected = false;
        Lvl2Selected = false;
        Lvl3Selected = true;
        Lvl4Selected = false;
        Lvl5Selected = false;
        Lvl6Selected = false;
    }

    public void SelectedLvl4()
    {
        Lvl1Selected = false;
        Lvl2Selected = false;
        Lvl3Selected = false;
        Lvl4Selected = true;
        Lvl5Selected = false;
        Lvl6Selected = false;
    }
    public void SelectedLvl5()
    {
        Lvl1Selected = false;
        Lvl2Selected = false;
        Lvl3Selected = false;
        Lvl4Selected = false;
        Lvl5Selected = true;
        Lvl6Selected = false;
    }

    public void SelectedLvl6()
    {
        Lvl1Selected = false;
        Lvl2Selected = false;
        Lvl3Selected = false;
        Lvl4Selected = false;
        Lvl5Selected = false;
        Lvl6Selected = true;
    }
}
