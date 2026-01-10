using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject GameObject;
    public List<GameObject> GameNames = new List<GameObject>();
    private void Awake()
    {
       DontDestroyOnLoad(this.gameObject);
        
    }

    private void Update()
    {
      
    }



    public void create() 
    {
     Instantiate(gameObject, new Vector3(0,0,0), Quaternion.identity);
    }
}
