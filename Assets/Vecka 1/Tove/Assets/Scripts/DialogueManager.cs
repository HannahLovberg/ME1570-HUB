using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

    public GameObject Dbox;
    public Text dText;

    public bool dialogActive;

    public string[] dialogLines;
    public int currentLine;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (dialogActive && Input.GetKeyUp(KeyCode.Space)) 

        {
            //Dbox.SetActive(false);
            //dialogActive = false;

            currentLine++;
        }

        if(currentLine >= dialogLines.Length)
        {
            Dbox.SetActive(false);
            dialogActive = false;

            currentLine = 0;
        }

        dText.text = dialogLines[currentLine];
    }

    public void ShowBox(string dialogue)
    {
        dialogActive = true;
        Dbox.SetActive(true);
        dText.text = dialogue;

    }

    public void ShowDialogue()
    {
        dialogActive = true;
        Dbox.SetActive(true);
    }
    

}
 