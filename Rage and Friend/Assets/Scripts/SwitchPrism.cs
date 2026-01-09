using UnityEngine;

public class SwitchPrism : MonoBehaviour
{
    public bool Kill;
    public MeshRenderer MeshRenderer;
    public Material KillMat;
    public Material NoKillMat;
    public Prism prism;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) 
        {
            if (!Kill) 
            {
                MeshRenderer.material = NoKillMat;
                prism.CanKill = false;
                prism.enabled = false;
            }

            if (Kill) 
            {
                MeshRenderer.material = KillMat;
                prism.CanKill = true;
                prism.enabled = true;
            }
        }
    }
}
