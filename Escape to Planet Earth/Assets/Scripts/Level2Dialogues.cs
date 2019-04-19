using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level2Dialogues : MonoBehaviour
{
    private string[] startUpLines = {"King Bukac is onto us! There are two puzzles that need to be solved in this room. Keep a lookout for any clues. Good luck!", 
                                     "I'm on it!"};
    private string[] winLines = {"Wow! You're a pro Spud! You can take the shuttle to the dock station now. You have to find a ship. Once you do, your free!", 
                                 "Thank you! Wish me luck!", "Guard! Where have you been?", "Uh..Sorry sir... I was on my lunch break..", 
                                 "Nevermind that! Prisoner CA-29 has escaped. Find him and bring him to me NOW!", "Yes sir..."};
    private int currentLine = 0;
    private int currentCharacter = 0;
    private bool isStartUpLinesDone = false;
    private bool isWinLinesDone = false;
                                 
    // Update is called once per frame
    void Update()
    {
        if (!isStartUpLinesDone)
        {
            if (currentLine < startUpLines.Length)
            {
                if (currentLine == 0)
                {
                    GetComponent<Image>().sprite = Resources.Load<Sprite>("DialogueAssets/guarddialoguebox");
                }
            
                if (currentLine == 1)
                {
                    GetComponent<Image>().sprite = Resources.Load<Sprite>("DialogueAssets/spuddialoguebox");
                }
            
                while (currentCharacter < startUpLines[currentLine].Length)
                {
                    gameObject.transform.GetChild(0).GetComponent<Text>().text += startUpLines[currentLine][currentCharacter];
                    currentCharacter++;
                }
        
                if (Input.GetKeyDown("return"))
                {
                    currentLine++;
                    currentCharacter = 0;
                    gameObject.transform.GetChild(0).GetComponent<Text>().text = "";
                }
            }
        
            else
            {
                gameObject.SetActive(false);
                isStartUpLinesDone = true;
            }
        }
    }
}
