using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public GameObject LvlVid;
    public GameObject PlayerVid;

    public GameObject[] Buttons;

    private void Awake()
    {
     /*   LvlVid = GameObject.FindWithTag("Lvl Vid");
        PlayerVid = GameObject.FindWithTag("Player Vid");*/
    }
    public void LoadTut() 
    {
        SceneManager.LoadScene("Tut scene");
    }

    public void LoadIntro() 
    {
        SceneManager.LoadScene("Intro");
    }

    public void LoadRealTut() 
    {
        SceneManager.LoadScene("RealIntro");
    }

    public void LoadGame() 
    {
        SceneManager.LoadScene("Lvl Build");
    }

    public void LbVid() 
    {
        foreach (var button in Buttons) 
        {
            button.gameObject.SetActive(false);
        }

        LvlVid.SetActive(true);
    }

    public void PLayerVid()
    {
        foreach (var button in Buttons)
        {
            button.gameObject.SetActive(false);
        }

        PlayerVid.SetActive(true);
    }

    public void Exit() 
    {
        Application.Quit();
    }
}
