using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    //basic int variables for calculating health
    public int maxHP = 15;
    public int currHP;
    
    //reference to health bar
    public healthBar healthBar;

    //Function for taking damage and updating the health bar when needed with any given value
    void TakeDamage(int dmg){
        currHP -= dmg;
        healthBar.setHealth(currHP);
    }

    // Start is called before the first frame update
    void Start(){
        currHP = maxHP;
        healthBar.setMaxHealth(maxHP);
    }

    // Update is called once per frame
    void Update(){
        //For now temporarily set a key to test the health
        if(Input.GetKeyDown(KeyCode.Tab)){
            TakeDamage(3);
        }
    }

    
}
