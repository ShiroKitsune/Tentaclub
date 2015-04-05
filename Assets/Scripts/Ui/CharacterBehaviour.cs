using UnityEngine;
using UnityEngine.UI;

public class CharacterBehaviour : MonoBehaviour
{
    public void SetCharacter(string path)
    {
        GetComponent<Image>().sprite = Resources.Load<Sprite>(path);
    }
}
