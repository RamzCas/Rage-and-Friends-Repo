using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject Lvl1;
    public GameObject Lvl2;
    public GameObject Lvl3;
    public GameObject Lvl4;
    public GameObject Lvl5;
    public GameObject Lvl6;

    public GameObject[] ChosenLvlsStage;
    public LvlBuilder[] lvlBuilders;
    public int LevelsCompleted;


    private void Update()
    {
        for (int i = 0; i < ChosenLvlsStage.Length; i++)
        {
            if (LevelsCompleted == 0)
            {
                ChosenLvlsStage[i].SetActive(true); 
            }
        }
    }

}
