using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Additionmanager : MonoBehaviour
{
    [SerializeField]
    private Text[] X;

    [SerializeField]
    private Text[] Y;

    [SerializeField]
    private Text helpA;
    [SerializeField]
    private Text helpB;
    [SerializeField]
    private Text helpC;

    private int[] numbersX;


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

        char[] XChars = randX.ToString().ToCharArray();
        for (int i = 0; i < XChars.Length; i++)
        {
            X[XChars.Length - i].text = XChars[i].ToString();
            numbersX[XChars.Length - i] = System.Convert.ToInt32(XChars[i]);
        }

        for(int i = XChars.Length; i < 3; i++)
        {
            X[XChars.Length - i].text = "0";
            numbersX[XChars.Length - i] = 0;
        }
        //ett,tio,hundra
        

    }
}
