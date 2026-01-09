using UnityEngine;
using UnityEngine.Rendering;

public class Wind : MonoBehaviour
{
    public string Tag;
    public bool InWind;
    public GameObject VolumeBlur;
    private GameObject Player;
    private CharacterController characterController;
    private CharacterControler characterControler;
    public float speed;


    private void Awake()
    {
        Player = GameObject.FindWithTag("Player");
        characterController = Player.GetComponent<CharacterController>();
        characterControler = Player.GetComponent<CharacterControler>();
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag(Tag))
        {
            VolumeBlur.SetActive(true);
            InWind = true;
            Debug.Log("in Wind");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(Tag))
        {
            VolumeBlur.SetActive(false);
            InWind = false;
            characterControler.CurrentGravity = characterControler.gravity;
            speed = 5;
        }
    }

    private void Update()
    {
        if (InWind) 
        {
            Vector3 move = Player.transform.up * speed * Time.deltaTime;
            characterController.Move(move);
            characterControler.CurrentGravity = characterControler.ZeroGravity;
            speed += 0.5f * Time.deltaTime;
        }
       
    }
}
