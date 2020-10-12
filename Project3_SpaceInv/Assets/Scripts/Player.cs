using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  public GameObject bullet;
  float amplify = 10;
  public GameObject particleEffect;
  private float life = 3;
    //public GameObject player;

  public Transform shottingOffset;

    private void Start()
    {
        //player = player.GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {

        if(this.gameObject.tag == "user")
        {
            if(Mathf.Abs(transform.position.x) < 10)
            {
                transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0, 0) * Time.deltaTime * amplify);
            }
        }

      if (Input.GetKeyDown(KeyCode.Space))
      {
        GameObject shot = Instantiate(bullet, shottingOffset.position, Quaternion.identity);
        Debug.Log("Bang!");

        Destroy(shot, 0.5f);

      }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "enemy")
        {
            Debug.Log("gameOver!");
            GameObject particle = Instantiate(particleEffect, transform.position, Quaternion.identity);
            Debug.Log(particle);
            Destroy(particle, 1f);
            Destroy(gameObject);
            Destroy(collision.gameObject);
            life = life - 1;
            Time.timeScale = 0;

        }

    }


    //for future use in implementing in future
    /*void gameOver()
    {
        Time.timeScale = 0;
    }*/

}
