using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    public bool gameActive = false;

    //Menu
    [SerializeField]
    private Canvas menuCanvas;
    [SerializeField]
    private Button additionButton;
    [SerializeField]
    private Button subtractionButton;
    [SerializeField]
    private Button multiplicationButton;
    [SerializeField]
    private Button exitToHubButton;

    //Load
    [SerializeField]
    private Canvas LoadingCanvas;

    //Addition
    [SerializeField]
    private Canvas additionCanvas;
    [SerializeField]
    private Button exitToMenu;

    //Subtraktion
    [SerializeField]
    private Canvas subtractionCanvas;

    //Multiplikation
    [SerializeField]
    private Canvas multiplicationCanvas;

    //Pause
    [SerializeField]
    private Canvas pauseMenuCanvas;
    [SerializeField]
    private Button resumeButton;
    [SerializeField]
    private Button exitToMenuButton;

    //help
    [SerializeField]
    private Canvas addHelpCanvas;
    [SerializeField]
    private Canvas subHelpCanvas;
    

    //you did it
    [SerializeField]
    private Canvas winCanvas;
    [SerializeField]
    private Button winToMenu;

    //sounds
    [SerializeField]
    private AudioSource source;
    [SerializeField]
    private AudioClip errorSound;
    [SerializeField]
    private AudioClip correctSound;
    [SerializeField]
    private AudioClip accessSound;

    public int nrOfSolved = 0;

    // Use this for initialization
    void Start ()
    {
        additionCanvas.enabled = false;
        subtractionCanvas.enabled = false;
        multiplicationCanvas.enabled = false;
        LoadingCanvas.enabled = false;
        pauseMenuCanvas.enabled = false;
        addHelpCanvas.enabled = false;
        subHelpCanvas.enabled = false;
        winCanvas.enabled = false;
    }

    void Awake()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        gameActive = true;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if(gameActive)
        {
            if (additionCanvas.enabled || subtractionCanvas.enabled || multiplicationCanvas.enabled)
            {
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    Debug.Log("pause");
                    pauseMenuCanvas.enabled = !pauseMenuCanvas.enabled;
                }
            }
        }

        gameActive = false;
        
    }
    //pause and unpause
    public void resume()
    {
        pauseMenuCanvas.enabled = false;
    }
    //menu buttons
    public void ButtonAddition()
    {
        menuCanvas.enabled = false;

        buttonPressed("goToAdd");
    }
    public void ButtonSubtraction()
    {
        menuCanvas.enabled = false;
        buttonPressed("goToSub");
    }
    public void ButtonMultiplication()
    {
        menuCanvas.enabled = false;
        buttonPressed("goToMult");
    }
    public void ButtonWinMenu()
    {
        winCanvas.enabled = false;
        backtoMenu();
    }

    private void buttonPressed(string button)
    {
        LoadingCanvas.enabled = true;
        Invoke(button, 0.3f);
    }

    public void backtoMenu()
    {
        LoadingCanvas.enabled = true;
        Invoke("goToMenu", 3);
    }

    public void goToAdd()
    {
        LoadingCanvas.enabled = false;
        additionCanvas.enabled = true;
    }
    public void goToSub()
    {
        LoadingCanvas.enabled = false;
        subtractionCanvas.enabled = true;
    }
    public void goToMult()
    {
        LoadingCanvas.enabled = false;
        multiplicationCanvas.enabled = true;
    }
    public void goToMenu()
    {
        nrOfSolved = 0;
        additionCanvas.enabled = false;
        subtractionCanvas.enabled = false;
        multiplicationCanvas.enabled = false;
        pauseMenuCanvas.enabled = false;
        LoadingCanvas.enabled = false;
        menuCanvas.enabled = true;
    }

    public void toggleHelp(string type)
    {
        if(type == "sub")
        {
            subHelpCanvas.enabled = !subHelpCanvas.enabled;
        }
        if(type == "add")
        {
            addHelpCanvas.enabled = !addHelpCanvas.enabled;
        }
        
    }
    public void winState()
    {
        playAccessSound();
        winCanvas.enabled = true;
    }

    public void playErrorSound()
    {
        source.PlayOneShot(errorSound);
    }
    public void playCorrectSound()
    {
        source.PlayOneShot(correctSound);
    }
    public void playAccessSound()
    {
        source.PlayOneShot(accessSound);
    }

    public void enterGame()
    {
        gameActive = true;
    }
    public void exitGame()
    {
        gameActive = false;
    }
}
