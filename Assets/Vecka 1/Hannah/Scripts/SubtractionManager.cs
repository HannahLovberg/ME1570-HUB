using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubtractionManager : MonoBehaviour
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
    private Text answerEn;
    [SerializeField]
    private Text answerTio;
    [SerializeField]
    private Text answerHundra;

    private int[] numbersX = new int[3];
    private int[] numbersY = new int[3];
    private int[] help = new int[3];

    private int[] answer = new int[3];

    private int xInt;
    private int yInt;

    private int minusTen = 0;
    private int minusHundred = 0;

    [SerializeField]
    private GameManagerScript gameManager;
    


    void Start()
    {
        createProblem();
    }


    void Update()
    {
        if (gameManager.nrOfSolved >= 3)
        {
            Debug.Log("OPEN");
            openAddSafe();
            gameManager.nrOfSolved = 0;
        }
    }

    private void randomizeX()
    {
        int randX = Random.Range(0, 1000);
        char[] XChars = randX.ToString().ToCharArray();

        for (int i = 0; i < XChars.Length; i++)
        {
            X[i].text = XChars[XChars.Length - 1 - i].ToString();
            numbersX[i] = (int)XChars[XChars.Length - 1 - i] - 48;
        }

        for (int i = XChars.Length; i < 2; i++)
        {
            X[i].text = "0";
            numbersX[i] = 0;
        }
        //ett,tio,hundra
    }

    private void randomizeY()
    {
        int randY = Random.Range(0, 1000);
        char[] YChars = randY.ToString().ToCharArray();

        for (int i = 0; i < YChars.Length; i++)
        {
            Y[i].text = YChars[YChars.Length - 1 - i].ToString();
            numbersY[i] = (int)YChars[YChars.Length - 1 - i] - 48;
        }

        for (int i = YChars.Length; i < 2; i++)
        {
            Y[i].text = "0";
            numbersY[i] = 0;
        }
        //ett,tio,hundra
    }

    private bool compareXY()
    {
        string compareX = X[2].text + X[1].text + X[0].text;
       // Debug.Log("comparex: " + compareX);
        xInt = System.Int32.Parse(compareX);
      //  Debug.Log("xInt: " + xInt);

        string compareY = Y[2].text + Y[1].text + Y[0].text;
       // Debug.Log("comparey: " + compareY);
        yInt = System.Int32.Parse(compareY);
       // Debug.Log("yInt: " + yInt);

        return (yInt < xInt);
    }

    public void createProblem()
    {
        resetAnswer();
        randomizeX();
        randomizeY();

        while (!compareXY())
        {
            randomizeX();
            randomizeY();
            Debug.Log("Randomize Y");
        }

        for (int i = 0; i < 2; i++)
        {
            help[i] = 0;
        }

        //figure it out
        //en
        if ((numbersX[0] - numbersY[0]) < 0)
        {
            //låna från tiotalet
            helpA.text = "10";
            help[0] = 10;
            X[1].color = Color.red;
            minusTen = 1;

            //vi kollar om tiotalet måste låna från hundratalet
            if((numbersX[1] - minusTen) < numbersY[1])
            {
                //låna från hundratalet
                helpB.text = "10";
                help[1] = 10;
                minusHundred = 1;

                X[2].color = Color.red;
                minusHundred = 1;
            }

            answer[0] = (help[0] + numbersX[0] - numbersY[0]);
        }
        else
        {
            answer[0] = (numbersX[0] - numbersY[0]);
        }
        //tio
        if ((numbersX[1] - numbersY[1]) < 0)
        {
            //låna från hundratalet
            helpB.text = "10";
            help[1] = 10;
            minusHundred = 1;
            X[2].color = Color.red;

            answer[1] = (help[1] + numbersX[1] - minusTen - numbersY[1]);
        }
        else
        {
            answer[1] = (numbersX[1] - minusTen - numbersY[1] );
        }
        //hundra
        if ((numbersX[2] - numbersY[2]) < 0)
        {
            answer[2] = (numbersX[2] - minusHundred - numbersY[2]);
        }
        else
        {
            answer[2] = (numbersX[2] - minusHundred - numbersY[2]);
        }
    }

    public void checkSolution()
    {
        string inputString = answerHundra.text + answerTio.text + answerEn.text;
        Debug.Log("input: " + inputString.ToString());

        string answerString = answer[2].ToString() + answer[1].ToString() + answer[0].ToString();
        Debug.Log("answer: " + answerString.ToString());

        if (inputString == answerString)
        {
            Debug.Log("CORRECT");
            gameManager.playCorrectSound();
            gameManager.nrOfSolved++;
            createProblem();
        }
        else
        {
            gameManager.playErrorSound();
        }
    }

    public void addNumber(string tal)
    {
        switch (tal)
        {
            case "ental":
                int nrEn = int.Parse(answerEn.text);
                if (nrEn >= 9)
                {
                    nrEn = 0;
                }
                else
                {
                    nrEn++;
                }

                answerEn.text = nrEn.ToString();
                break;

            case "tiotal":
                int nrTio = int.Parse(answerTio.text);

                if (nrTio >= 9)
                {
                    nrTio = 0;
                }
                else
                {
                    nrTio++;
                }

                answerTio.text = nrTio.ToString();
                break;

            case "hundratal":
                int nrHundra = int.Parse(answerHundra.text);

                if (nrHundra >= 9)
                {
                    nrHundra = 0;
                }
                else
                {
                    nrHundra++;
                }

                answerHundra.text = nrHundra.ToString();
                break;
        }
    }

    private void resetAnswer()
    {
        answerEn.text = "0";
        answerTio.text = "0";
        answerHundra.text = "0";

        helpA.text = "0";
        helpB.text = "0";

        minusTen = 0;
        minusHundred = 0;

        X[1].color = Color.black;
        X[2].color = Color.black;

    }
    private void openAddSafe()
    {
        gameManager.winState();
    }
}
