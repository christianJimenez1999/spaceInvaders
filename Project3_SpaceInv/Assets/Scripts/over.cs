using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class over : MonoBehaviour
{
    public static bool dead = false;
    private Text GameOver;
    // Start is called before the first frame update
    void Start()
    {
        GameOver = GetComponent<Text>();
        GameOver.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (dead)
        {
            Time.timeScale = 0;
            GameOver.enabled = true;
        }
    }
}
