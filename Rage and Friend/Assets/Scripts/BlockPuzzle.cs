using System.Collections;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlockPuzzle : MonoBehaviour
{
    public bool Correct;
    public bool Incorrect;
    public GameObject Door;
    public GameObject SikeAudio;
    public GameObject RickRoll;
    public GameObject Music;
    private GameObject GM;
    private GameManager GameManager;

    private GameObject Player;
    private CharacterControler CharacterControler;

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
            if(Correct) 
            {
                Debug.Log("correct");
                Destroy(Door);
                this.gameObject.SetActive(false);
               
            }

            if(Incorrect) 
            {
                Debug.Log("Incorrect");
                StartCoroutine(KillPlayer());
            }
        }
    }

    public IEnumerator KillPlayer() 
    {
        Music.SetActive(false);
        CharacterControler.enabled = false;
        SikeAudio.SetActive(true);
        yield return new WaitForSeconds(5);
        RickRoll.SetActive(true);
        yield return new WaitForSeconds(4);
        //Destroy(GameObject.FindWithTag("GM"));
        //SceneManager.LoadSceneAsync(2);
        RickRoll.SetActive(false);
        GameManager.LoadNewScene = true;
        GameManager.LevelsCompleted = 1;
 
    }
}
