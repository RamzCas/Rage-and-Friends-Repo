using UnityEngine;
using UnityEngine.Rendering;

public class Wind : MonoBehaviour
{
    public string Tag;
    public GameObject VolumeBlur;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag(Tag))
        {
          VolumeBlur.SetActive(true);
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
