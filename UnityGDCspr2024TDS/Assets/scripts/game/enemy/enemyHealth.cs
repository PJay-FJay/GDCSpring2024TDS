using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{

    public int maxHP = 3;
    public int currHP;

    private BoxCollider2D myBC;
    private SpriteRenderer mySR;

    //public GameObject enemy;

    void TakeDamage(int dmg){
        currHP -= dmg;
    }

    public void DelayDamage(){
        myBC.enabled=false;
            gameObject.SetActive(false);
            gameObject.SetActive(true);
        
        Invoke("EnableDamage", 0.1f);
       

    }

    /*public void IFrame(){
        while(myBC == false){
            mySR.enabled = false;
            mySR.enabled = true;
        }
    }*/

    public void EnableDamage(){
        myBC.enabled=true;
    }

    private void OnCollisionEnter2D(Collision2D collision){

        //Destroys the gameObject upon colliding with a box collider of some sort
        if(collision.gameObject.name == "Bullet(Clone)"){
            TakeDamage(2);
            DelayDamage();
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
