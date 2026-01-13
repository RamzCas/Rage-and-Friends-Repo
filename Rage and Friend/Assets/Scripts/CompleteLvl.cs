using UnityEngine;

public class CompleteLvl : MonoBehaviour
{
    private GameObject GM;
    private GameManager GameManager;

    private void Awake()
    {
        GM = GameObject.FindWithTag("GM");
        GameManager = GM.GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) 
        {
            GameManager.LevelsCompleted += 1;
        }
    }
}
