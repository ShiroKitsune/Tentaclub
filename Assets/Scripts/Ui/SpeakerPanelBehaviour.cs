using UnityEngine;
using UnityEngine.UI;

public class SpeakerPanelBehaviour : MonoBehaviour
{
    public void SetSpeaker(string content = null)
    {
        if (string.IsNullOrEmpty(content))
        {
            gameObject.SetActive(false);
            GetComponent<Text>().text = "";
        }
        else
        {
            gameObject.SetActive(true);
            GetComponent<Text>().text = content;
        }
    }
}
