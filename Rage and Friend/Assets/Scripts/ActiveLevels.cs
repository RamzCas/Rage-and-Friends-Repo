using UnityEngine;

public class ActiveLevels : MonoBehaviour
{
    private GameObject GM;
    private GameManager GameManager;
    public GameObject Paren;

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
                Paren.transform.GetChild(0).gameObject.SetActive(true);
                Paren.transform.GetChild(1).gameObject.SetActive(false);
                Paren.transform.GetChild(2).gameObject.SetActive(false);
            }

            if (GameManager.LevelsCompleted == 2)
            {
                Paren.transform.GetChild(0).gameObject.SetActive(false);
                Paren.transform.GetChild(1).gameObject.SetActive(true);
                Paren.transform.GetChild(2).gameObject.SetActive(false);
            }

            if (GameManager.LevelsCompleted == 3)
            {
                Paren.transform.GetChild(0).gameObject.SetActive(false);
                Paren.transform.GetChild(1).gameObject.SetActive(false);
                Paren.transform.GetChild(2).gameObject.SetActive(true);
            }
        }
       

    }
}
