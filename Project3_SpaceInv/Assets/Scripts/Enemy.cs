using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    private Transform motherShip;
    public GameObject particleEffect;
    public GameObject hit;
    public float speed;
    private GameObject test1;
    public GameObject enemyBullet;
    public float fire = 0.997f;
    public scoreCounter scoreCounter;

    // Start is called before the first frame update
    private void Start()
    {
        InvokeRepeating("Move", 0.1f, 0.3f);
        motherShip = GetComponent<Transform>();
    }

    void Move()
    {
        //moves each enemy in the mothership
        motherShip.position += Vector3.right * speed;
        foreach(Transform enemy in motherShip)
        {
            if(enemy.position.x < -8.5 || enemy.position.x > 8.5)
            {
                speed = -speed;
                motherShip.position += Vector3.down * 1f;
                return;
            }
            
            if(Random.value > fire)
            {
                Instantiate(enemyBullet, enemy.position, enemy.rotation);
            }


            if(enemy.position.y <= -2.5)
            {
                //enemy reached limit
                //INSERT text to show game over
                Time.timeScale = 0; 
            }
        }

        //makes last ship faster
        if(motherShip.childCount == 1)
        {
            CancelInvoke();
            InvokeRepeating("Move", 0.1f, 1f);
        }

        if(motherShip.childCount == 0)
        {
            //INSERT user won in the screen
            Debug.Log("you won");
            Time.timeScale = 0;
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "userBullet") {

            
            Debug.Log("Ouch!");
            GameObject particle = Instantiate(particleEffect, transform.position, Quaternion.identity);
            Debug.Log(particle);
            Destroy(particle, 1f);
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
            Debug.Log(gameObject.name);
            
            if( gameObject.name == "blackops")
            {
                GameObject.Find("MotherShip").GetComponent<Enemy>().opsincr();
                //opsincr();
            }
            if (gameObject.name == "generals")
            {
                GameObject.Find("MotherShip").GetComponent<Enemy>().genincr();
                //genincr();
            }
            if (gameObject.name == "privates")
            {
                GameObject.Find("MotherShip").GetComponent<Enemy>().privincr();
                //privincr();
            }
            if (gameObject.name == "recruits")
            {
                GameObject.Find("MotherShip").GetComponent<Enemy>().recrincr();
                //recrincr();
            }
            if (gameObject.name == "grunts")
            {
                GameObject.Find("MotherShip").GetComponent<Enemy>().grunincr();
                //grunincr();
            }

        }
        
    }

    void opsincr()
    {
        
        scoreCounter.opsincr();
    }
    void genincr()
    {
        scoreCounter.genincr();
    }
    void privincr()
    {
        scoreCounter.privincr();
    }
    void recrincr()
    {
        scoreCounter.recrincr();
    }
    void grunincr()
    {
        Debug.Log("hello");
        scoreCounter.grunincr();
    }

}
