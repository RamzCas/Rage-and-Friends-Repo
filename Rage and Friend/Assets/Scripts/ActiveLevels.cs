using UnityEngine;

public class ActiveLevels : MonoBehaviour
{
    private GameObject GM;
    private GameManager GameManager;

    private void Awake()
    {
        GM = GameObject.FindWithTag("GM");
        GameManager = GM.GetComponent<GameManager>();
    }
    void Update()
    {
        if (GameManager.GameInPlay)
        {

            if (GameManager.LevelsCompleted == 1)
            {
                GameManager.ChosenLvls[0].SetActive(true);
                GameManager.ChosenLvls[1].SetActive(false);
                GameManager.ChosenLvls[2].SetActive(false);
                //Debug.Log("Play lvl 1");
            }

            if (GameManager.LevelsCompleted == 2)
            {
                GameManager.ChosenLvls[0].SetActive(false);
                GameManager.ChosenLvls[1].SetActive(true);
                GameManager.ChosenLvls[2].SetActive(false);
                Debug.Log("Next Lvl");
            }

            if (GameManager.LevelsCompleted == 3)
            {
                GameManager.ChosenLvls[0].SetActive(false);
                GameManager.ChosenLvls[1].SetActive(false);
                GameManager.ChosenLvls[2].SetActive(true);
            }
        }
    }
}
