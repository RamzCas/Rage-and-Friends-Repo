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

    public void SelectedLvl1() 
    {
        Button1.Select(); 
        Lvl1Selected = true;
        Lvl2Selected = false;
        Lvl3Selected = false;
        Lvl4Selected = false;
        Lvl5Selected = false;
        Lvl6Selected = false;
    }
}
