using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highScoreCounter : MonoBehaviour
{

    public Text highschore;
    int current = 0000;
    // Start is called before the first frame update
    void Start()
    {
        highschore.text = "HI-Score " + '\n' + current.ToString("0000");
    }

    public void check(int num)
    {
        if(current < num)
        {
            current = num;
            showhigh();
        }
        else
        {
            showhigh();
        }
    }

    void showhigh()
    {
        highschore.text = "HI-Score " + '\n' + current.ToString("0000");
    }
}
