using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Prism : MonoBehaviour
{
    public bool CanKill;
    public GameObject RickRoll;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && CanKill)
        {
            Debug.Log("killed");
            /*SceneManager.LoadSceneAsync(2);
            Destroy(GameObject.FindWithTag("GM"));*/
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
