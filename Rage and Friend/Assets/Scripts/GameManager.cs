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

    public List<GameObject> ChosenLvlsStage;


    public List<GameObject> LvlSpawns;
    public void BuildLvl1() 
    {
        //Instantiate(Lvl1, transform.position, transform.rotation);
        
    }

}
