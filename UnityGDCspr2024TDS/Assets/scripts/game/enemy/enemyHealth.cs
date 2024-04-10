using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{

    public int maxHP = 3;
    public int currHP;

    private BoxCollider2D myBC;

    //public GameObject enemy;

    void TakeDamage(int dmg){
        currHP -= dmg;
    }

    private void OnCollisionEnter2D(Collision2D collision){

        //Destroys the gameObject upon colliding with a box collider of some sort
        if(collision.gameObject.name == "Bullet(Clone)"){
            TakeDamage(2);
            
            //We are onto something!
            myBC.enabled = false;
            //gameObject.SetActive(false);
            //gameObject.SetActive(true);
            //myBC.enabled = true;
        }
    }

    void Start()
    {
        currHP = maxHP;
        myBC = gameObject.GetComponent<BoxCollider2D>();
    }

    void Update()
    {

        if(currHP <= 0){
            Destroy(gameObject);
        }
    }
}
