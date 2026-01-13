using UnityEngine;

public class MoveKey : MonoBehaviour
{
    public int move;
    public bool OpenDoor;

    public GameObject[] Tps;
    public GameObject Key;
    public GameObject Wall;

    public AudioClip Yeet;
    public AudioClip Correct;
    public AudioSource AudioSource;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") & OpenDoor) 
        {
            Destroy(Wall);
            AudioSource.PlayOneShot(Correct);
            Destroy(Key);
        }

        if (other.gameObject.CompareTag("Player") & !OpenDoor)
        {
            move++;
            AudioSource.PlayOneShot(Yeet);
        }
    }
    void Update()
    {
        if (move == 1) 
        {
            Key.transform.position = Tps[0].transform.position;
          
        }

        if (move == 2)
        {
            Key.transform.position = Tps[1].transform.position;
            
        }

        if (move == 3)
        {
            Key.transform.position = Tps[2].transform.position;
            
        }

        if (move == 4)
        {
            OpenDoor = true;
        }
    }
}
