using UnityEngine;
using UnityEngine.SceneManagement;

public class Prism : MonoBehaviour
{
    public bool CanKill;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && CanKill)
        {
            Debug.Log("killed");
            SceneManager.LoadSceneAsync(2);
            Destroy(GameObject.FindWithTag("GM"));
        }
    }
}
