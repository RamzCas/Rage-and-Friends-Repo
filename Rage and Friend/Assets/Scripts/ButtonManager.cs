using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
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
}
