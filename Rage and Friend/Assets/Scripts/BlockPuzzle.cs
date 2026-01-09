using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlockPuzzle : MonoBehaviour
{
    public bool Correct;
    public bool Incorrect;
    public GameObject Door;
    public GameObject SikeAudio;
    public GameObject RickRoll;


    private GameObject Player;
    private CharacterControler CharacterControler;

    private void Awake()
    {
        Player = GameObject.FindWithTag("Player");
        CharacterControler = Player.GetComponent<CharacterControler>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if(Correct) 
            {
                Debug.Log("correct");
                Destroy(Door);
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
        CharacterControler.enabled = false;
        SikeAudio.SetActive(true);
        yield return new WaitForSeconds(4);
        RickRoll.SetActive(true);
        yield return new WaitForSeconds(4);
        Destroy(GameObject.FindWithTag("GM"));
        SceneManager.LoadSceneAsync(2);
    }
}
