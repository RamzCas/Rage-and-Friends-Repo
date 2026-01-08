using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void LoadTut() 
    {
        SceneManager.LoadScene("Tut scene");
    }
}
