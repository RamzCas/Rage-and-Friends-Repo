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
    [Header("Prefabs")]
    public GameObject Lvl1;
    public GameObject Lvl2;
    public GameObject Lvl3;
    public GameObject Lvl4;
    public GameObject Lvl5;
    public GameObject Lvl6;

    [Header("Arrays/List")]
    //public GameObject[] ChosenLvlsStage;
    public List<GameObject> ChosenLvls;
    public LvlBuilder[] lvlBuilders;
    public List<Transform> SpawnPoints;


    [Header("Game Management")]
    public GameObject CanvasHolder;
    public int LevelsCompleted;
    public bool GameInPlay;
    public bool LoadNewScene;

    private void Awake()
    {
        
        DontDestroyOnLoad(this.gameObject);

        if (GameInPlay) 
        {
            Instantiate(ChosenLvls[0]);
            Instantiate(ChosenLvls[1]);
            Instantiate(ChosenLvls[2]);
        }
    }

    private void Update()
    {
        ReloadScene();
        if (GameInPlay) 
        {
            if (LevelsCompleted == 1)
            {
                ChosenLvls[0].SetActive(true);
                ChosenLvls[1].SetActive(false);
                ChosenLvls[2].SetActive(false);
                //Debug.Log("Play lvl 1");
            }
        }
       
    }

    public void ReloadScene() 
    {
        if (LoadNewScene) 
        {
            Debug.Log("reload Scene");
                
        }
    }

    public void BuildLevel() 
    {
        StartCoroutine(LoadLvl());

       /* GameInPlay = true;
        LevelsCompleted += 1;
        CanvasHolder.SetActive(false);
      
    //========Lvl1==============

        if (lvlBuilders[0].Lvl1Selected) 
        {
            GameObject Lvl =  Instantiate(Lvl1, SpawnPoints[0].transform);
            ChosenLvls.Add(Lvl);
        }

        if (lvlBuilders[0].Lvl2Selected)
        {
            GameObject Lvl = Instantiate(Lvl2, SpawnPoints[0].transform);
            ChosenLvls.Add(Lvl);
        }

        if (lvlBuilders[0].Lvl3Selected)
        {
            GameObject Lvl = Instantiate(Lvl3, SpawnPoints[0].transform.parent);
            ChosenLvls.Add(Lvl);
        }

        if (lvlBuilders[0].Lvl4Selected)
        {
            GameObject Lvl = Instantiate(Lvl4, SpawnPoints[0].transform.parent);
            ChosenLvls.Add(Lvl);
        }

        if (lvlBuilders[0].Lvl5Selected)
        {
            GameObject Lvl = Instantiate(Lvl5, SpawnPoints[0].transform.parent);
            ChosenLvls.Add(Lvl);
        }

        if (lvlBuilders[0].Lvl6Selected)
        {
            GameObject Lvl = Instantiate(Lvl6, SpawnPoints[0].transform.parent);
            ChosenLvls.Add(Lvl);
        }

        //==========Lvl2=================

        if (lvlBuilders[1].Lvl1Selected)
        {
            GameObject Lvl = Instantiate(Lvl1, SpawnPoints[1].transform.parent);
            ChosenLvls.Add(Lvl);
        }

        if (lvlBuilders[1].Lvl2Selected)
        {
            GameObject Lvl = Instantiate(Lvl2, SpawnPoints[1].transform.parent);
            ChosenLvls.Add(Lvl);
        }

        if (lvlBuilders[1].Lvl3Selected)
        {
            GameObject Lvl = Instantiate(Lvl3, SpawnPoints[1].transform.parent);
            ChosenLvls.Add(Lvl);
        }

        if (lvlBuilders[1].Lvl4Selected)
        {
            GameObject Lvl = Instantiate(Lvl4, SpawnPoints[1].transform.parent);
            ChosenLvls.Add(Lvl);
        }

        if (lvlBuilders[1].Lvl5Selected)
        {
            GameObject Lvl = Instantiate(Lvl5, SpawnPoints[1].transform.parent);
            ChosenLvls.Add(Lvl);
        }

        if (lvlBuilders[1].Lvl6Selected)
        {
            GameObject Lvl = Instantiate(Lvl6, SpawnPoints[1].transform.parent);
            ChosenLvls.Add(Lvl);
        }

        //=========Lvl3===============


        if (lvlBuilders[2].Lvl1Selected)
        {
            GameObject Lvl = Instantiate(Lvl1, SpawnPoints[2].transform.parent);
            ChosenLvls.Add(Lvl);
        }

        if (lvlBuilders[2].Lvl2Selected)
        {
            GameObject Lvl = Instantiate(Lvl2, SpawnPoints[2].transform.parent);
            ChosenLvls.Add(Lvl);
        }

        if (lvlBuilders[2].Lvl3Selected)
        {
            GameObject Lvl = Instantiate(Lvl3, SpawnPoints[2].transform.parent);
            ChosenLvls.Add(Lvl);
        }

        if (lvlBuilders[2].Lvl4Selected)
        {
            GameObject Lvl = Instantiate(Lvl4, SpawnPoints[2].transform.parent);
            ChosenLvls.Add(Lvl);
        }

        if (lvlBuilders[2].Lvl5Selected)
        {
            GameObject Lvl = Instantiate(Lvl5, SpawnPoints[2].transform.parent);
            ChosenLvls.Add(Lvl);
        }

        if (lvlBuilders[2].Lvl6Selected)
        {
            GameObject Lvl = Instantiate(Lvl6, SpawnPoints[2].transform.parent);
            ChosenLvls.Add(Lvl);
        }*/

        //SceneManager.LoadSceneAsync(5);
    }


    private IEnumerator LoadLvl() 
    {
        yield return new WaitForSeconds(0);

        GameInPlay = true;
        LevelsCompleted += 1;
        CanvasHolder.SetActive(false);

        //========Lvl1==============

        if (lvlBuilders[0].Lvl1Selected)
        {
            GameObject Lvl = Instantiate(Lvl1, SpawnPoints[0].transform);
            ChosenLvls.Add(Lvl);
        }

        if (lvlBuilders[0].Lvl2Selected)
        {
            GameObject Lvl = Instantiate(Lvl2, SpawnPoints[0].transform);
            ChosenLvls.Add(Lvl);
        }

        if (lvlBuilders[0].Lvl3Selected)
        {
            GameObject Lvl = Instantiate(Lvl3, SpawnPoints[0].transform.parent);
            ChosenLvls.Add(Lvl);
        }

        if (lvlBuilders[0].Lvl4Selected)
        {
            GameObject Lvl = Instantiate(Lvl4, SpawnPoints[0].transform.parent);
            ChosenLvls.Add(Lvl);
        }

        if (lvlBuilders[0].Lvl5Selected)
        {
            GameObject Lvl = Instantiate(Lvl5, SpawnPoints[0].transform.parent);
            ChosenLvls.Add(Lvl);
        }

        if (lvlBuilders[0].Lvl6Selected)
        {
            GameObject Lvl = Instantiate(Lvl6, SpawnPoints[0].transform.parent);
            ChosenLvls.Add(Lvl);
        }

        //==========Lvl2=================

        if (lvlBuilders[1].Lvl1Selected)
        {
            GameObject Lvl = Instantiate(Lvl1, SpawnPoints[1].transform.parent);
            ChosenLvls.Add(Lvl);
        }

        if (lvlBuilders[1].Lvl2Selected)
        {
            GameObject Lvl = Instantiate(Lvl2, SpawnPoints[1].transform.parent);
            ChosenLvls.Add(Lvl);
        }

        if (lvlBuilders[1].Lvl3Selected)
        {
            GameObject Lvl = Instantiate(Lvl3, SpawnPoints[1].transform.parent);
            ChosenLvls.Add(Lvl);
        }

        if (lvlBuilders[1].Lvl4Selected)
        {
            GameObject Lvl = Instantiate(Lvl4, SpawnPoints[1].transform.parent);
            ChosenLvls.Add(Lvl);
        }

        if (lvlBuilders[1].Lvl5Selected)
        {
            GameObject Lvl = Instantiate(Lvl5, SpawnPoints[1].transform.parent);
            ChosenLvls.Add(Lvl);
        }

        if (lvlBuilders[1].Lvl6Selected)
        {
            GameObject Lvl = Instantiate(Lvl6, SpawnPoints[1].transform.parent);
            ChosenLvls.Add(Lvl);
        }

        //=========Lvl3===============


        if (lvlBuilders[2].Lvl1Selected)
        {
            GameObject Lvl = Instantiate(Lvl1, SpawnPoints[2].transform.parent);
            ChosenLvls.Add(Lvl);
        }

        if (lvlBuilders[2].Lvl2Selected)
        {
            GameObject Lvl = Instantiate(Lvl2, SpawnPoints[2].transform.parent);
            ChosenLvls.Add(Lvl);
        }

        if (lvlBuilders[2].Lvl3Selected)
        {
            GameObject Lvl = Instantiate(Lvl3, SpawnPoints[2].transform.parent);
            ChosenLvls.Add(Lvl);
        }

        if (lvlBuilders[2].Lvl4Selected)
        {
            GameObject Lvl = Instantiate(Lvl4, SpawnPoints[2].transform.parent);
            ChosenLvls.Add(Lvl);
        }

        if (lvlBuilders[2].Lvl5Selected)
        {
            GameObject Lvl = Instantiate(Lvl5, SpawnPoints[2].transform.parent);
            ChosenLvls.Add(Lvl);
        }

        if (lvlBuilders[2].Lvl6Selected)
        {
            GameObject Lvl = Instantiate(Lvl6, SpawnPoints[2].transform.parent);
            ChosenLvls.Add(Lvl);
        }

        SceneManager.LoadSceneAsync(5);
    }
}
    


