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
            Rick.SetActive(true);
            //SceneManager.LoadSceneAsync(2);
        }
    }
}
