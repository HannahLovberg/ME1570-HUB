using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Additionmanager : MonoBehaviour
{
    [SerializeField]
    private Text enX;
    [SerializeField]
    private Text tioX;
    [SerializeField]
    private Text hundraX;

    [SerializeField]
    private Text enY;
    [SerializeField]
    private Text tioY;
    [SerializeField]
    private Text hundraY;

    [SerializeField]
    private Text helpA;
    [SerializeField]
    private Text helpB;
    [SerializeField]
    private Text helpC;



    void Start ()
    {
		
	}
	

	void Update ()
    {
		
	}

    private void randomizeX()
    {
        int randX = Random.Range(0, 1000);
        int randY = Random.Range(0, 1000);

        //X
        char[] XChars = randX.ToString().ToCharArray();
        int[] xDigits = new int[XChars.Length];
        for (int i = 0; i < XChars.Length; i++)
        {
            xDigits[i] = (int)XChars[i];
        }

        enX.text = xDigits[xDigits.Length - 1].ToString();
        tioX.text = xDigits[xDigits.Length - 2].ToString();
        hundraX.text = xDigits[xDigits.Length - 3].ToString();

    }
}
