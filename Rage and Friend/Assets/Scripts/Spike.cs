using UnityEngine;
using UnityEngine.SceneManagement;

public class Spike : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) 
        {
            Debug.Log("killed");
            SceneManager.LoadSceneAsync(2);
        }
    }
}
