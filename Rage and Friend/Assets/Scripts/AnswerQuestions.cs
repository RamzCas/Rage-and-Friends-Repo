using System.Collections.Generic;
using TMPro;
using UnityEditor.ShaderGraph;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnswerQuestions : MonoBehaviour
{
    private Controls controls;
    private GameObject Player;
    private GameObject Ball;
    public bool CanAnswer;
    public int Ansered;
    public float speed = 5; 


    [Header("Text")]
    public List<string> Questions;
    public TextMeshProUGUI TextMeshProUGUI;


    private void Awake()
    {
        controls = new Controls();
        Player = GameObject.FindWithTag("Player");
        Ball = GameObject.FindWithTag("Back");
    }

    private void OnEnable()
    {
        controls.Player.Enable();
        controls.Player.yes.performed += OnYes;
        controls.Player.no.performed += OnNo;
    }

    private void OnDisable()
    {
        controls.Player.Disable();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) 
        {
            Debug.Log("Can Answer");
            CanAnswer = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Can't Answer");
           CanAnswer = false;
        }
    }

    private void OnYes(InputAction.CallbackContext ctx) 
    {
        AnswerYes();
    }
    
    private void OnNo(InputAction.CallbackContext ctx) 
    {
        AnswerNo();
    }

    public void AnswerYes() 
    {
        if (CanAnswer) 
        {
            Player.transform.Translate(-Player.transform.forward * speed * Time.deltaTime, Space.World);
            Ansered++;
            Questions.RemoveAt(0);
        }
        
    }

    public void AnswerNo() 
    {
        if (CanAnswer)
        {
            Ansered++;
            Questions.RemoveAt(0);
        }
    }


    private void Update()
    {
        TextMeshProUGUI.text = Questions[0];
        if (Ansered > 9) 
        {
            Destroy(GameObject.FindWithTag("AnswerDoor"));
        }
    }
}
