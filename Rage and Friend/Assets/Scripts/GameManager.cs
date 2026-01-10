using NUnit.Framework;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
   
    private void Awake()
    {
       DontDestroyOnLoad(this.gameObject);
    }


}
