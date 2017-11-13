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
    //[SerializeField]
    //private loadingbar loadingBar;

    //Addition
    [SerializeField]
    private Canvas additionCanvas;
    [SerializeField]
    private Button exitToMenu;


    [SerializeField]
    private Canvas subtractionCanvas;
    [SerializeField]
    private Canvas multiplicationCanvas;


    // Use this for initialization
    void Start ()
    {

    }

    void Awake()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
	
	// Update is called once per frame
	void Update ()
    {
        
    }

    public void StartAddition()
    {
        menuCanvas.enabled = false;
        additionButton.enabled = false;
        subtractionButton.enabled = false;
        multiplicationButton.enabled = false;
        exitToHubButton.enabled = false;

        buttonPressed("goToAdd");
    }

    private void buttonPressed(string button)
    {
        Debug.Log("loadingbar loaded");
        LoadingCanvas.enabled = true;
        Invoke(button, 10);
    }

    public void goToAdd()
    {
        LoadingCanvas.enabled = false;
        additionCanvas.enabled = true;
    }
}
