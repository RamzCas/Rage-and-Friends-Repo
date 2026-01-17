using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    /*[Header("Prefabs")]
    public GameObject Lvl1;
    public GameObject Lvl2;
    public GameObject Lvl3;
    public GameObject Lvl4;
    public GameObject Lvl5;
    public GameObject Lvl6;*/

    [Header("Arrays/List")]
    //public GameObject[] ChosenLvlsStage;
    public List<GameObject> ChosenLvls;
    public List<GameObject> Gms;
    //public LvlBuilder[] lvlBuilders;
    //public List<Transform> SpawnPoints;


    [Header("Game Management")]
    public static GameManager instance;
    //public GameObject CanvasHolder;
    public int LevelsCompleted;
    public bool GameInPlay;
    public bool LoadNewScene;
    public bool ReloadLvls;
    public int Count;

    private GameObject Spawn;
    private void Awake()
    {
       Spawn = GameObject.FindWithTag("Spawn");

        //DontDestroyOnLoad(gameObject);

        if (GameInPlay) 
        {
            Debug.Log("Create lvl");
        }

        if (instance) 
        {
            Destroy(gameObject);
        }

        else 
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Update()
    {
        Resets();
        ReloadScene();
        NextLvl();
    }

    public void NextLvl() 
    {
        if (GameInPlay)
        {

            Cursor.visible = false;

            if (LevelsCompleted == 1)
            {
                ChosenLvls[0].SetActive(true);
                ChosenLvls[1].SetActive(false);
                ChosenLvls[2].SetActive(false);
            }

            if (LevelsCompleted == 2)
            {
                ChosenLvls[0].SetActive(false);
                ChosenLvls[1].SetActive(true);
                ChosenLvls[2].SetActive(false);
            }

            if (LevelsCompleted == 3)
            {
                ChosenLvls[0].SetActive(false);
                ChosenLvls[1].SetActive(false);
                ChosenLvls[2].SetActive(true);
            }
        }

        else 
        {
            Cursor.visible = true;
        }

    }

    public void ReloadScene() 
    {
        if (LoadNewScene) 
        {
            Debug.Log("reload Scene");
            SceneManager.LoadScene("Game");
            LoadNewScene = false;
        }
    }

    public void Resets() 
    {
        if(Count < 3 && GameInPlay) 
        {
            Debug.Log("Wahallah");
            SceneManager.LoadScene(4);
            GameInPlay = false;
            Count = 0;
            ChosenLvls.Clear();
            LevelsCompleted = 0;
            
        }

      
        
    }
}
    


