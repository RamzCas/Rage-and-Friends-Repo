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
    public int LevelsCompleted;
    public bool GameInPlay;


    private void Update()
    {
        if (GameInPlay) 
        {
            if (LevelsCompleted <= 1)
            {
                ChosenLvls[0].SetActive(true);
                ChosenLvls[1].SetActive(false);
                ChosenLvls[2].SetActive(false);
            }
        }
       
    }

    public void BuildLevel() 
    {
        /*foreach (var lvl in lvlBuilders) 
         {
             if(lvl.Lvl1Selected) 
             {
                 Debug.Log("lvl 1 built");
             }
         }*/

        if (lvlBuilders[0].Lvl1Selected) 
        {
            Instantiate(Lvl1, SpawnPoints[0].transform.parent);
            ChosenLvls.Add(Lvl1);
        }

        if (lvlBuilders[0].Lvl2Selected)
        {
            Instantiate(Lvl2, SpawnPoints[0].transform.parent);
            ChosenLvls.Add(Lvl2);
        }

        if (lvlBuilders[0].Lvl3Selected)
        {
            Instantiate(Lvl3, SpawnPoints[0].transform.parent);
            ChosenLvls.Add(Lvl3);
        }

        if (lvlBuilders[0].Lvl4Selected)
        {
            Instantiate(Lvl4, SpawnPoints[0].transform.parent);
            ChosenLvls.Add(Lvl4);
        }

        if (lvlBuilders[0].Lvl5Selected)
        {
            Instantiate(Lvl5, SpawnPoints[0].transform.parent);
            ChosenLvls.Add(Lvl5);
        }

        if (lvlBuilders[0].Lvl6Selected)
        {
            Instantiate(Lvl6, SpawnPoints[0].transform.parent);
            ChosenLvls.Add(Lvl6);
        }

        //==========Lvl2=================

        if (lvlBuilders[1].Lvl1Selected)
        {
            Instantiate(Lvl1, SpawnPoints[1].transform.parent);
            ChosenLvls.Add(Lvl1);
        }

        if (lvlBuilders[1].Lvl2Selected)
        {
            Instantiate(Lvl2, SpawnPoints[1].transform.parent);
            ChosenLvls.Add(Lvl2);
        }
        if (lvlBuilders[1].Lvl3Selected)
        {
            Instantiate(Lvl3, SpawnPoints[1].transform.parent);
            ChosenLvls.Add(Lvl3);
        }
    }

}
