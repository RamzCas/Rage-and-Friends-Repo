using UnityEngine;
using UnityEngine.Rendering;

public class Wind : MonoBehaviour
{
    public string Tag;
    public bool InWind;
    public GameObject VolumeBlur;
    private GameObject Player;
    private CharacterController characterController;
    public float speed;


    private void Awake()
    {
        Player = GameObject.FindWithTag("Player");
        characterController = Player.GetComponent<CharacterController>();
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag(Tag))
        {
            VolumeBlur.SetActive(true);
            Vector3 move = Player.transform.up * speed * Time.deltaTime;
            characterController.Move(move);
            Debug.Log("in Wind");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(Tag))
        {
            VolumeBlur.SetActive(false);
            
        }
    }

    private void Update()
    {
       
    }
}
