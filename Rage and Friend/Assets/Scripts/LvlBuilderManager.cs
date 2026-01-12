using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlBuilderManager : MonoBehaviour
{
    private GameObject GM;
    private GameManager GameManager;

    [Header("Prefabs")]
    public GameObject Lvl1;
    public GameObject Lvl2;
    public GameObject Lvl3;
    public GameObject Lvl4;
    public GameObject Lvl5;
    public GameObject Lvl6;

    public LvlBuilder[] lvlBuilders;

    private void Awake()
    {
        GM = GameObject.FindWithTag("GM");
        GameManager = GM.GetComponent<GameManager>();
    }



    public void PlayGame() 
    {
        StartCoroutine(LoadLvl());
    }

    private IEnumerator LoadLvl()
    {
        yield return new WaitForSeconds(0);


        //========Lvl1==============

        if (lvlBuilders[0].Lvl1Selected)
        {
            GameManager.ChosenLvls.Add(Lvl1);
        }

        if (lvlBuilders[0].Lvl2Selected)
        {
            GameManager.ChosenLvls.Add(Lvl2);
        }

        if (lvlBuilders[0].Lvl3Selected)
        {
            
            GameManager.ChosenLvls.Add(Lvl3);
        }

        if (lvlBuilders[0].Lvl4Selected)
        {

            GameManager.ChosenLvls.Add(Lvl4);
        }

        if (lvlBuilders[0].Lvl5Selected)
        {

            GameManager.ChosenLvls.Add(Lvl5);
        }

        if (lvlBuilders[0].Lvl6Selected)
        {
            GameManager.ChosenLvls.Add(Lvl6);
        }

        //==========Lvl2=================

        if (lvlBuilders[1].Lvl1Selected)
        {
            GameManager.ChosenLvls.Add(Lvl1);
        }

        if (lvlBuilders[1].Lvl2Selected)
        {
            GameManager.ChosenLvls.Add(Lvl2);
        }

        if (lvlBuilders[1].Lvl3Selected)
        {
            GameManager.ChosenLvls.Add(Lvl3);
        }

        if (lvlBuilders[1].Lvl4Selected)
        {
            GameManager.ChosenLvls.Add(Lvl4);
        }

        if (lvlBuilders[1].Lvl5Selected)
        {
            GameManager.ChosenLvls.Add(Lvl5);
        }

        if (lvlBuilders[1].Lvl6Selected)
        {
            GameManager.ChosenLvls.Add(Lvl6);
        }

        //=========Lvl3===============


        if (lvlBuilders[2].Lvl1Selected)
        {
            GameManager.ChosenLvls.Add(Lvl1);
        }

        if (lvlBuilders[2].Lvl2Selected)
        {
            GameManager.ChosenLvls.Add(Lvl2);
        }

        if (lvlBuilders[2].Lvl3Selected)
        {
            GameManager.ChosenLvls.Add(Lvl3);
        }

        if (lvlBuilders[2].Lvl4Selected)
        {
            GameManager.ChosenLvls.Add(Lvl4);
        }

        if (lvlBuilders[2].Lvl5Selected)
        {
            GameManager.ChosenLvls.Add(Lvl5);
        }

        if (lvlBuilders[2].Lvl6Selected)
        {
            GameManager.ChosenLvls.Add(Lvl6);
        }

        GameManager.GameInPlay = true;
        GameManager.LevelsCompleted += 1;

        SceneManager.LoadSceneAsync(5);
    }
}
