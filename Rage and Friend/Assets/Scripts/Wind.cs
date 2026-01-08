using UnityEngine;
using UnityEngine.Rendering;

public class Wind : MonoBehaviour
{
    public string Tag;
    public GameObject VolumeBlur;
    private GameObject Player;
    private CharacterController characterController;


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
            Vector3 move = Player.transform.up * 50f * Time.deltaTime;
            characterController.Move(move);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(Tag))
        {
            VolumeBlur.SetActive(false);
            
        }
    }
}
