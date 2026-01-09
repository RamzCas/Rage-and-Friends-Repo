using UnityEngine;

public class YuuStupid : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("killed");
        }
    }
}
