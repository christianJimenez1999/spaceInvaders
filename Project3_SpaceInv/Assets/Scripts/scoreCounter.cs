using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class scoreCounter : MonoBehaviour
{
    public Text score;
    int current = 0000;
    public highScoreCounter highScore;

    // Start is called before the first frame update
    void Start()
    {
        score.text = "Current score " + '\n' + current.ToString("0000");

      /*       int i = 23;
        print("3 digit num = " + i.ToString("000"));
    */
    }


    public void opsincr()
    {
        current += 50;
        showScore();
    }
    public void genincr()
    {
        current += 40;
        showScore();
    }
    public void privincr()
    {
        current += 30;
        showScore();
    }
    public void recrincr()
    {
        current += 20;
        showScore();
    }
    public void grunincr()
    {
        current += 10;
        showScore();
    }

    public void showScore()
    {
        
        score.text = "Current score " + '\n' + current.ToString("0000");
        sendtohigh();

    }

    void sendtohigh()
    {
        highScore.check(current);
    }

}
