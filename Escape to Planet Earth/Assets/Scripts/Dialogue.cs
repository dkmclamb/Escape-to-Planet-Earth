using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Text))]
public class Dialogue : MonoBehaviour
{
    private Text _textComponent;

    public string[] DialogueStrings;

    public float SecondsBetweenCharacters = 0.01f;
    public float CharacterRateMultiplier = 0.25f;

    public KeyCode DialogueInput = KeyCode.Return;
    public string sceneName;

    private int dialogueCounter = 0;
    private bool _isStringBeingRevealed = false;
    private bool _isDialoguePlaying = false;
    private bool _isEndOfDialogue = false;

    public GameObject ContinueIcon;
    public GameObject StopIcon;

    // Use this for initialization
    void Start()
    {
        _textComponent = GetComponent<Text>();
        _textComponent.text = "";

        HideIcons();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (!_isDialoguePlaying)
            {
                _isDialoguePlaying = true;
                StartCoroutine(StartDialogue());
            }

        }
    }

    private IEnumerator StartDialogue()
    {
        int dialogueLength = DialogueStrings.Length;
        int currentDialogueIndex = 0;

        while (currentDialogueIndex < dialogueLength || !_isStringBeingRevealed)
        {
            if (!_isStringBeingRevealed)
            {
                _isStringBeingRevealed = true;

                if(dialogueCounter >= dialogueLength)
                {
                    SceneManager.LoadScene(sceneName);
                }
                dialogueCounter++;
                StartCoroutine(DisplayString(DialogueStrings[currentDialogueIndex++]));

                if (currentDialogueIndex >= dialogueLength)
                {
                    _isEndOfDialogue = true;
                    //SceneManager.LoadScene(sceneName);
                }
            }

            yield return 0;
        }

        while (true)
        {
            if (Input.GetKeyDown(DialogueInput))
            {
                break;
            }

            yield return 0;
        }


        HideIcons();
        _isEndOfDialogue = false;
        _isDialoguePlaying = false;
    }

    private IEnumerator DisplayString(string stringToDisplay)
    {
        int stringLength = stringToDisplay.Length;
        int currentCharacterIndex = 0;

        HideIcons();

        _textComponent.text = "";

        while (currentCharacterIndex < stringLength)
        {
            if (stringToDisplay[currentCharacterIndex] == '@')
            {
                _textComponent.text += "\n";
                currentCharacterIndex++;
            }
            else
            {
                _textComponent.text += stringToDisplay[currentCharacterIndex];
                currentCharacterIndex++;
            }

            if (currentCharacterIndex < stringLength)
            {
                if (Input.GetKey(DialogueInput))
                {
                    yield return new WaitForSeconds(SecondsBetweenCharacters * CharacterRateMultiplier);
                }
                else
                {
                    yield return new WaitForSeconds(SecondsBetweenCharacters);
                }
            }
            else
            {
                break;
            }
        }

        ShowIcon();

        while (true)
        {
            if (Input.GetKeyDown(DialogueInput))
            {
                break;
            }

            yield return 0;
        }

        HideIcons();

        _isStringBeingRevealed = false;
        _textComponent.text = "";
    }

    private void HideIcons()
    {
        ContinueIcon.SetActive(false);
        StopIcon.SetActive(false);
    }

    private void ShowIcon()
    {
        if (_isEndOfDialogue)
        {
            StopIcon.SetActive(true);
            return;
        }

        ContinueIcon.SetActive(true);
    }
}