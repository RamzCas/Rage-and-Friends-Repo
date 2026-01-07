using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextArray : MonoBehaviour
{
    public string[] Questions;
    public TextMeshProUGUI TextMeshProUGUI;

    private void Update()
    {
        TextMeshProUGUI.text = Questions[0];
    }
}
