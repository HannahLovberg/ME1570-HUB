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

    private int[] numbersX = new int[3];
    private int[] numbersY = new int[3];
    private int[] help = new int[3];


    void Start ()
    {
        createProblem();
    }


    void Update ()
    {
		
	}

    private void randomizeX()
    {
        int randX = Random.Range(0, 1000);
        char[] XChars = randX.ToString().ToCharArray();

        Debug.Log(randX);

        for (int i = 0; i < XChars.Length; i++)
        {
            Debug.Log("XChar: " + XChars[i]);
            Debug.Log(XChars.Length - i);

            X[i].text = XChars[XChars.Length - 1 - i].ToString();
            numbersX[i] = (int)XChars[XChars.Length - 1 - i] - 48;
        }
        Debug.Log(numbersX);


        for (int i = XChars.Length; i < 3; i++)
        {
            X[i].text = "0";
            numbersX[i] = 0;
        }
        //ett,tio,hundra
    }

    private void randomizeY()
    {
        int randY = Random.Range(0, 1000);
        Debug.Log(randY);

        char[] YChars = randY.ToString().ToCharArray();
        for (int i = 1; i < YChars.Length + 1; i++)
        {
            Debug.Log("Y: " + YChars[i - 1]);
            Y[YChars.Length - i].text = YChars[i - 1].ToString();
            numbersY[YChars.Length - i] = System.Convert.ToInt32(YChars[i-1]);
        }

        for (int i = YChars.Length; i < 3; i++)
        {
            Y[YChars.Length - i].text = "0";
            numbersY[YChars.Length - i] = 0;
        }
        //ett,tio,hundra
    }

    public void createProblem()
    {
        randomizeX();
        randomizeY();

        for (int i = 0; i < 3; i++)
        {
            help[i] = 0;
        }

        if (numbersX[0] + numbersY[0] > 10)
        {
            helpA.text = "1";
            help[0] = 1;
        }
        if (numbersX[1] + numbersY[1] > 10)
        {
            helpB.text = "1";
            help[1] = 1;
        }
        if (numbersX[2] + numbersY[2] > 10)
        {
            helpC.text = "1";
            help[2] = 1;
        }
    } 
}
