using UnityEngine;
using UnityEngine.SceneManagement;

public class Spike : MonoBehaviour
{
    private GameObject Rick;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) 
        {
            Debug.Log("killed");
            Rick = GameObject.FindWithTag("Rick");
            //SceneManager.LoadSceneAsync(2);
        }
    }
}
