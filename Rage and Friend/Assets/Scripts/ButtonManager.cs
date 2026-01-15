using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public GameObject LvlVid;
    public GameObject PlayerVid;
    public float TimePassed;
    public bool VidPlaying;
    public bool VidReset;

    public GameObject[] Buttons;
    public GameObject[] Videos;

    //1611

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
        StartCoroutine(PlayLbVid());  
    }

    public void PLayerVid()
    {

    }

    public void Exit() 
    {
        Application.Quit();
    }

    public IEnumerator PlayLbVid() 
    {
        foreach(var button in Buttons) 
        {
            button.SetActive(false);
            LvlVid.SetActive(true);
            yield return new WaitForSeconds(18);
            LvlVid.SetActive(false);
            button.SetActive(true);
        }
    }

    public IEnumerator PlayPlayerVid() 
    {
        foreach (var button in Buttons)
        {
            button.SetActive(false);
            PlayerVid.SetActive(true);
            yield return new WaitForSeconds(18);
            PlayerVid.SetActive(false);
            button.SetActive(true);
        }
    }
}
