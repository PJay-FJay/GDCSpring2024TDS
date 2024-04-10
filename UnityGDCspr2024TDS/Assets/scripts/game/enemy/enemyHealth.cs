using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{

    public int maxHP = 3;
    public int currHP;

    void TakeDamage(int dmg){
        currHP -= dmg;
    }

    private void OnCollisionEnter2D(Collision2D collision){

        //Destroys the gameObject upon colliding with a box collider of some sort
        if(collision.gameObject.name == "Bullet(Clone)"){
            TakeDamage(2);
        }
    }

    void Start()
    {
        currHP = maxHP;
    }

    void Update()
    {

        if(currHP <= 0){
            Destroy(gameObject);
        }
    }
}
