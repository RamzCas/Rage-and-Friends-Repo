using UnityEditor.ShaderGraph;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnswerQuestions : MonoBehaviour
{
    private Controls controls;
    private GameObject Player;
    public int Ansered;

    private void Awake()
    {
        controls = new Controls();
        Player = GameObject.FindWithTag("Player");
    }

    private void OnEnable()
    {
   
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) 
        {
            Debug.Log("Can Answer");
            controls.Player.Enable();
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Can't Answer");
            controls.Player.Disable();
        }
    }

    public void AnswerYes() 
    {
        Player.transform.transform.position = new Vector3 (0,0,-2); 
        Ansered++;
    }

    public void AnswerNo() 
    {
        Player.transform.transform.position = new Vector3(0, 0, -2);
        Ansered++;
    }
    
}
