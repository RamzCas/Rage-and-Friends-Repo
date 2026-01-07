using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public string Tag;
    public int Scene;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(Tag)) 
        {
            Debug.Log("Next Scene");
            SceneManager.LoadSceneAsync(Scene);
        }
    }
}
