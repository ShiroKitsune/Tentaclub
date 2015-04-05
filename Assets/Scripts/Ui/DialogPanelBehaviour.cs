using UnityEngine;
using UnityEngine.UI;

public class DialogPanelBehaviour : MonoBehaviour
{
    public void SetDialog(string content)
    {
        GetComponent<Text>().text = content;
    }
}
