using UnityEngine;

public class SpawnLvls : MonoBehaviour
{
    private GameObject GM;
    private GameManager GameManager;
    private GameObject Spawn;

    private void Awake()
    {
        GM = GameObject.FindWithTag("GM");
        GameManager = GM.GetComponent<GameManager>();
        Spawn = GameObject.FindWithTag("Spawn");

        Instantiate(GameManager.ChosenLvls[0], Spawn.transform);
        Instantiate(GameManager.ChosenLvls[1], Spawn.transform);
        Instantiate(GameManager.ChosenLvls[2], Spawn.transform);
    }
}
