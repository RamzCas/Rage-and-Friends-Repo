using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YuuStupid : MonoBehaviour
{
    private GameObject Player;
    private CharacterControler CharacterControler;
    public GameObject Stupid;
    public GameObject RickRoll;
    public GameObject Clown;
    private GameObject GM;
    private GameManager GameManager;

  
    private void Awake()
    {
        Player = GameObject.FindWithTag("Player");
        CharacterControler = Player.GetComponent<CharacterControler>();
        GM = GameObject.FindWithTag("GM");
        GameManager = GM.GetComponent<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("killed");
            StartCoroutine(KillPlayer());
        }
    }

    public IEnumerator KillPlayer() 
    {
        CharacterControler.enabled = false;
        Stupid.SetActive(true);
        Clown.SetActive(true);
        yield return new WaitForSeconds(4);
        Clown.SetActive(false);
        RickRoll.SetActive(true);
        yield return new WaitForSeconds(4f);
        //Destroy(GameObject.FindWithTag("GM"));
        //SceneManager.LoadSceneAsync(5);
        RickRoll.SetActive(false);
        GameManager.LoadNewScene = true;
        GameManager.LevelsCompleted = 1;
    }
}
