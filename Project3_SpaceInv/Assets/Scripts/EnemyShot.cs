using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : MonoBehaviour
{

    private Transform enemyBullet;
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        enemyBullet = GetComponent<Transform>();
        
    }

    private void FixedUpdate()
    {
        enemyBullet.position += Vector3.up * -speed;

        if(enemyBullet.position.y <= -10)
        {
            Destroy(enemyBullet.gameObject);
        }
    }

    /*private void onCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "enemy")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            Time.timeScale = 0;
        }//INSERT function to add basehealth for the barracades!
    }*/

   
}
