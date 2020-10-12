using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barricade : MonoBehaviour
{

    private float health = 2;
    public GameObject hitPlayer;
    public GameObject hitEnemy;

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "userBullet")
        {
            health -= 1;
            Destroy(collision.gameObject);
        }
        if(collision.gameObject.tag == "enemy")
        {
            health -= 1;
            Destroy(collision.gameObject);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            Destroy(gameObject);
        }    
    }
}
