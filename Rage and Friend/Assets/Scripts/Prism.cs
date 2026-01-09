using UnityEngine;
using UnityEngine.SceneManagement;

public class Prism : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("killed");
            SceneManager.LoadSceneAsync(2);
            Destroy(GameObject.FindWithTag("GM"));
        }
    }
}
