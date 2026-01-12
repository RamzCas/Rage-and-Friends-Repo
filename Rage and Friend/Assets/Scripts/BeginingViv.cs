using UnityEngine;

public class BeginingViv : MonoBehaviour
{
    public GameObject OverLayContainer;
    public int TimePassed;
    public bool PlayVid;

    private void Update()
    {
        if (PlayVid) 
        {
            TimePassed += 1;
        }
        

        if(TimePassed > 5368) 
        {
            OverLayContainer.SetActive(true);
            PlayVid = false;
        }
    }
}
