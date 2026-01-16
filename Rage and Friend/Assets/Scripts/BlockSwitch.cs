using UnityEngine;
using UnityEngine.SceneManagement;

public class BlockSwitch : MonoBehaviour
{
    public string Tag;
    public GameObject Platform;
    public GameObject TpPoint;
    public GameObject Music;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(Tag))
        {
            Debug.Log("Move");
            Platform.transform.position = TpPoint.transform.position;
            Music.SetActive(true);
        }
    }
}
