using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level2Dialogues : MonoBehaviour
{
    private GameObject panel;
    private string[] startUpLines = {"King Bukac is onto us! There are two puzzles that need to be solved in this room. Keep a lookout for any clues. Good luck! (Press Enter to continue)", 
                                     "I'm on it! (Press Enter to continue)"};
    private static bool isStartUpLinesDone = false;
    private string[] winLines = {"Wow! You're a pro Spud! You can take the shuttle to the dock station now. You have to find a ship. Once you do, your free! (Press Enter to continue)", 
                                 "Thank you! Wish me luck! (Press Enter to continue)", "Guard! Where have you been? (Press Enter to continue)", "Uh..Sorry sir... I was on my lunch break.. (Press Enter to continue)", 
                                 "Nevermind that! Prisoner CA-29 has escaped. Find him and bring him to me NOW! (Press Enter to continue)", "Yes sir... (Press Enter to continue)"};
    private int currentLine = 0;
    private int currentCharacter = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        panel = gameObject.transform.GetChild(3).gameObject;
    }
	
    // Update is called once per frame
    void Update()
    {
        if (!isStartUpLinesDone || LightSwitch.allOn)
        {
            panel.SetActive(true);
            string[] dialogue;
            
            if (!isStartUpLinesDone)
            {
                dialogue = startUpLines;
            }
                
            else
            {
                dialogue = winLines;
            }
            
            if (currentLine < dialogue.Length)
            {
                if (dialogue == startUpLines)
                {
                    switch (currentLine)
                    {
                        case 0:
                            panel.GetComponent<Image>().sprite = Resources.Load<Sprite>("DialogueAssets/guarddialoguebox");
                            break;
                        
                        default:
                            panel.GetComponent<Image>().sprite = Resources.Load<Sprite>("DialogueAssets/spuddialoguebox");
                            break;
                    }
                }
                    
                else
                {
                    switch (currentLine)
                    {
                        case 0:
                            panel.GetComponent<Image>().sprite = Resources.Load<Sprite>("DialogueAssets/guarddialoguebox2");
                            break;
                        
                        case 1:
                            panel.GetComponent<Image>().sprite = Resources.Load<Sprite>("DialogueAssets/spuddialoguebox");
                            break;
                            
                        case 2:
                        case 4:
                            panel.GetComponent<Image>().sprite = Resources.Load<Sprite>("DialogueAssets/kingbukacdialoguebox");
                            break;
                                
                        default:
                            panel.GetComponent<Image>().sprite = Resources.Load<Sprite>("DialogueAssets/guarddialoguebox");
                            break;
                    }
                }
                
                while (currentCharacter < dialogue[currentLine].Length)
                { 
                    panel.transform.GetChild(0).GetComponent<Text>().text += dialogue[currentLine][currentCharacter];
                    currentCharacter++;
                }
            
                if (currentCharacter >= dialogue[currentLine].Length)
                {
                    if (Input.GetKeyDown("return"))
                    {
                        currentLine++;
                        currentCharacter = 0;
                        panel.transform.GetChild(0).GetComponent<Text>().text = "";
                    }
                }
            }
            
            else
            {
                panel.SetActive(false);
                    
                if (!isStartUpLinesDone)
                {
                    isStartUpLinesDone = true;
                }
                    
                else
                {
                    SceneManager.LoadScene("Bridge Transition");
                }
            }
        }
    }
}