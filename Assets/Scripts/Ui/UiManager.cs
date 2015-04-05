using UnityEngine;
using UnityEngine.UI;

public class UiManager : DesignPattern.Singleton<UiManager>
{
    private BackgroundBehaviour _background;
    private CharacterBehaviour _character;
    private SpeakerPanelBehaviour _speakerPanel;
    private DialogPanelBehaviour _dialogPanel;
    private ChoicePanelBehaviour _choicePanel;

    void Awake()
    {
        _background = GetComponentInChildren<BackgroundBehaviour>();
        _character = GetComponentInChildren<CharacterBehaviour>();
        _speakerPanel = GetComponentInChildren<SpeakerPanelBehaviour>();
        _dialogPanel = GetComponentInChildren<DialogPanelBehaviour>();
        _choicePanel = GetComponentInChildren<ChoicePanelBehaviour>();
    }

    public void SetBackground(string path)
    {
        _background.SetBackground(path);
    }

    public void SetCharacter(string path)
    {
        _character.SetCharacter(path);
    }

    public void SetSpeaker(string content = null)
    {
        _speakerPanel.SetSpeaker(content);
    }

    public void SetDialog(string content)
    {
        _dialogPanel.SetDialog(content);
    }

    public void DisplayChoices(string[] content)
    {

    }
}
