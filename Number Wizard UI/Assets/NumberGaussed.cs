using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class NumberGaussed : MonoBehaviour {
    public Text numberGaussed;
    int max = 100, min = 0, numGuess = 0;
    int numberOfTries = 10;

    // Use this for initialization
     void Start()
    {
        numGuess = Random.Range(0, 100);
        print(numberGaussed);
        numberGaussed.text = numGuess.ToString();//Nullpointer exception but still change the text..
        print(numGuess);
        print("Start Method called !!!");
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    public void higherNum(Text numberGaussed)
    {
        print("HigherNum Method called !!!");
        if (numberOfTries != 0)
        {
            min = numGuess;
            numGuess = Random.Range(min,max);
            numberGaussed.text = numGuess.ToString();
            numberOfTries--;
        } else{Application.LoadLevel("Win");
        }
    }

    public void lowerNum(Text numberGaussed)
    {
        print("LowerNum Method called !!!" + numGuess);
        if (numberOfTries != 0)
        {
            print("The guessed number is " + numGuess);
            max = numGuess;
            print("Min:" + min + " to Max:" + max);
            numGuess = Random.Range(min, max);
            numberGaussed.text = numGuess.ToString();
            numberOfTries--;
        }
        else { Application.LoadLevel("Win");}
    }
}
