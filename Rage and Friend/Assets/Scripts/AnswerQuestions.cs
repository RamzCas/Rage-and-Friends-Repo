using UnityEditor.ShaderGraph;
using UnityEngine;

public class AnswerQuestions : MonoBehaviour
{
    private Controls controls;

    private void Awake()
    {
        controls = new Controls();
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

}
