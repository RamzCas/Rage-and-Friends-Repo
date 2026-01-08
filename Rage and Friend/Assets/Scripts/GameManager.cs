using NUnit.Framework;
using UnityEditor;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
   
    private void Awake()
    {
       DontDestroyOnLoad(this.gameObject);
        
    }
}
