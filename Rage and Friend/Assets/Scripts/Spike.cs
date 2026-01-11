using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spike : MonoBehaviour
{
    private GameObject Rick;
    public GameObject RickRoll;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) 
        {
            Debug.Log("killed");
            //Rick = GameObject.FindWithTag("Rick");
            //SceneManager.LoadSceneAsync(2);
            //Destroy(GameObject.FindWithTag("GM"));
            StartCoroutine(KillPlayer());
        }
    }

    public IEnumerator KillPlayer() 
    {
        RickRoll.SetActive(true);
        yield return new WaitForSeconds(4);
        //Destroy(GameObject.FindWithTag("GM"));
        SceneManager.LoadSceneAsync(5);
    }
}
