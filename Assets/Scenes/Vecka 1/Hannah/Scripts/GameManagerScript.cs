using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
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
    private Canvas helpCanvas;
    [SerializeField]
    private Button helpButton;


    // Use this for initialization
    void Start ()
    {
        additionCanvas.enabled = false;
        subtractionCanvas.enabled = false;
        multiplicationCanvas.enabled = false;
        LoadingCanvas.enabled = false;
        pauseMenuCanvas.enabled = false;
        helpCanvas.enabled = false;
    }

    void Awake()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if(additionCanvas.enabled || subtractionCanvas.enabled || multiplicationCanvas.enabled)
        {
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                Debug.Log("pause");
                pauseMenuCanvas.enabled = true; 
            }
        }
    }

    public void resume()
    {
        pauseMenuCanvas.enabled = false;
    }

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

    private void buttonPressed(string button)
    {
        Debug.Log("loadingbar loaded");
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
        LoadingCanvas.enabled = false;
        menuCanvas.enabled = true;
    }

    public void toggleHelp()
    {
        helpCanvas.enabled = !helpCanvas.enabled;
    }
}
