using UnityEngine;
using UnityEngine.SceneManagement;

public class BlockSwitch : MonoBehaviour
{
    public string Tag;
    public GameObject Platform;
    public GameObject TpPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(Tag))
        {
            Debug.Log("Move");
            Platform.transform.position = TpPoint.transform.position;
            
        }
    }
}
