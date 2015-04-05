using UnityEngine;
using UnityEngine.UI;

public class BackgroundBehaviour : MonoBehaviour
{
    public void SetBackground(string path)
    {
        GetComponent<Image>().sprite = Resources.Load<Sprite>(path);
    }
}
